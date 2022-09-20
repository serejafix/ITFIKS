using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_Barber_DatebaseFirst
{
    public partial class Form1 : Form
    {
        BarberShopEntities db;

        public Form1()
        {
            InitializeComponent();
            db = new BarberShopEntities();
            //addAllPositions();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            txb_PhoneNumber.MaxLength = 10;

            cmb_ArchiveBarbersId.DataSource = (from a in db.Barbers select new { a.Id, Names = a.FIO }).ToList();
            cmb_ArchiveBarbersId.DisplayMember = "Names";
            cmb_ArchiveBarbersId.ValueMember = "Id";

            cmb_ArchiveCltId.DataSource = (from a in db.Clients select new { a.Id, Names = a.FIO }).ToList();
            cmb_ArchiveCltId.DisplayMember = "Names";
            cmb_ArchiveCltId.ValueMember = "Id";

            cmb_servicesIdArchive.DataSource = (from a in db.servicesLists select new { a.Id, Names = a.Name }).ToList();
            cmb_servicesIdArchive.DisplayMember = "Names";
            cmb_servicesIdArchive.ValueMember = "Id";

            cmb_BarbersPostionId.DataSource =  (from b in db.Positions   
                                                //where  b.Name != "Чиф"
                                               select new { b.Id, Names = b.Name }).ToList();
            cmb_BarbersPostionId.DisplayMember = "Names";
            cmb_BarbersPostionId.ValueMember = "Id";

            cmb_BarbersId.DataSource = (from a in db.Barbers select new { a.Id, Names = a.FIO }).ToList();
            cmb_BarbersId.DisplayMember = "Names";
            cmb_BarbersId.ValueMember = "Id";

            cmb_BarberIdSchedules.DataSource = (from a in db.Barbers select new { a.Id, Names = a.FIO }).ToList();
            cmb_BarberIdSchedules.DisplayMember = "Names";
            cmb_BarberIdSchedules.ValueMember = "Id";

            cmb_serviceId.DataSource = (from a in db.servicesLists select new { a.Id, Names = a.Name }).ToList();
            cmb_serviceId.DisplayMember = "Names";
            cmb_serviceId.ValueMember = "Id";

            dgv_Barbers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Clients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Archive.SelectionMode =  DataGridViewSelectionMode.FullRowSelect;
            dgv_BS.SelectionMode =  DataGridViewSelectionMode.FullRowSelect;
            dgv_Schedules.SelectionMode =  DataGridViewSelectionMode.FullRowSelect;
            dgv_Services.SelectionMode =  DataGridViewSelectionMode.FullRowSelect;

        }

        private void button_AllBarber_Click(object sender, EventArgs e)
        {
            dgv_Query.DataSource = db.Barbers.ToList();
        }

        private void btn_FioOnly_Click(object sender, EventArgs e)
        {
            dgv_Query.DataSource = db.Barbers.Select(b => new { Fio = b.FIO }).ToList();
        }

        private void btn_Tradicionaly_Click(object sender, EventArgs e)
        {
            var query = from b in db.Barbers
                        from bs in db.BarberServices
                        from s in db.servicesLists
                        from p in db.Positions
                        where b.Id == bs.BarberId &&
                              s.Id == bs.ServiceId &&
                              b.PostionId == p.Id

                        where s.Name == "Традиционное Бритье"
                        select
                        new { Барберы = b.FIO, Позиция = p.Name };
            dgv_Query.DataSource = query.ToList();
        }

        private void btn_SearchByService_Click(object sender, EventArgs e)
        {

            var querysearch = from b in db.Barbers
                              from bs in db.BarberServices
                              from s in db.servicesLists
                              from p in db.Positions
                              from sch in db.Schedules
                              where b.Id == bs.BarberId &&
                                    s.Id == bs.ServiceId &&
                                    b.PostionId == p.Id &&
                                    b.Id == sch.BarberId
                              where s.Name.Contains(txb_searchByService.Text)
                              select
                              new { b.FIO, p.Name, Service = s.Name, sch.FreeDate, sch.FreeTime };

            dgv_Query.DataSource = querysearch.ToList();
        }

        private void btn_SearchByCountYear_Click(object sender, EventArgs e)
        {
            var querysearchbyYear = from b in db.Barbers
                                    where b.DateAdmission.Year + num_SearchByCountYear.Value > DateTime.Now.Year
                                    select new { b.FIO };
            dgv_Query.DataSource = querysearchbyYear.ToList();
        }

        private void btn_CountBarbers_Click(object sender, EventArgs e)
        {
            var s = db.Barbers.GroupBy(x => new { x.Position.Name, x.PostionId }).Where(a => a.Key.PostionId != 2)
                              .Select(g => new { g.Key.Name, Count = g.Count() }).ToList();

            dgv_Query.DataSource = s;
        }

        private void btn_SearchClientsCount_Click(object sender, EventArgs e)
        {
            var s = db.ArchiveVisits.GroupBy(x => new { x.Client.FIO, x.ClientId })
                              .Select(g => new { g.Key.FIO, Count = g.Count() == num_SearchClientsCount.Value }).ToList();
            dgv_Query.DataSource = s;
        }

        private void btn_AddNewBarbers_Click(object sender, EventArgs e)
        {
            var chif = from p in db.Positions
                       where p.Name == "Чиф"
                       select p.Id;
            if (String.IsNullOrEmpty(txb_Email.Text)
                && String.IsNullOrEmpty(txb_PhoneNumber.Text)
                && String.IsNullOrEmpty(txb_AddNewBarbersFIO.Text)
                && dateTime_Birthday.Value.Year > (DateTime.Now.Year - 21))
            {

                MessageBox.Show("Неправильны ввод или пустые поля или барбер младше 21 года");
            }
            else
            {
                foreach (var item in chif)
                {
                    if (dgv_Barbers.CurrentRow.Cells[7].Value.ToString() == item.ToString())
                    {
                        MessageBox.Show("Чиф барбер может быть только один");
                    }
                    else
                    {
                        btn_AddNewBarbers.Enabled = true;
                        btn_deleteBarber.Enabled = true;
                    }
                }


                Barber ba = new Barber()
                {
                    FIO = txb_AddNewBarbersFIO.Text,
                    Gender = GenderCheck.Checked,
                    PhoneNumber = Convert.ToInt32(txb_PhoneNumber.Text),
                    Email = txb_Email.Text,
                    Birthday = Convert.ToDateTime(dateTime_Birthday.Value.ToShortDateString()),
                    DateAdmission = Convert.ToDateTime(dateTimeDateAdmission.Value.ToShortDateString()),                   
                    PostionId = Convert.ToInt32(cmb_BarbersPostionId.SelectedValue)
                };
                db.Barbers.Add(ba);
                db.SaveChanges();
            }

        }

        private void GenderCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (GenderCheck.Checked == true)
            {
                lbl_genders.Text = "Мужчина";
            }
            else { lbl_genders.Text = "Женщина"; }
        }

        private void txb_PhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_ShowBar_Click(object sender, EventArgs e)
        {
            dgv_Barbers.DataSource = db.Barbers.ToList();
            dgv_Barbers.Columns["Position"].Visible = false;
            dgv_Barbers.Columns["ArchiveVisits"].Visible = false;
            dgv_Barbers.Columns["Schedules"].Visible = false;
            dgv_Barbers.Columns["BarberServices"].Visible = false;
        }
        int id;
        private void dgv_Barbers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgv_Barbers.CurrentRow.Cells[0].Value);
            txb_AddNewBarbersFIO.Text = dgv_Barbers.CurrentRow.Cells[1].Value.ToString();
            GenderCheck.Checked = Convert.ToBoolean(dgv_Barbers.CurrentRow.Cells[2].Value);
            txb_PhoneNumber.Text = dgv_Barbers.CurrentRow.Cells[3].Value.ToString();
            txb_Email.Text = dgv_Barbers.CurrentRow.Cells[4].Value.ToString();
            dateTime_Birthday.Value = Convert.ToDateTime(dgv_Barbers.CurrentRow.Cells[5].Value);
            dateTimeDateAdmission.Value = Convert.ToDateTime(dgv_Barbers.CurrentRow.Cells[6].Value);
            cmb_BarbersPostionId.SelectedValue = dgv_Barbers.CurrentRow.Cells[7].Value;

            var chif = from p in db.Positions
                       where p.Name == "Чиф"
                       select p.Id;

            var bchif = from b in db.Barbers
                        from a in db.Positions                        
                        where b.PostionId == a.Id
                        && a.Name == "Чиф"
                        select b.FIO;

            if (bchif == null)
            {
                btn_AddNewBarbers.Enabled = true;
            }
            else
            {
                btn_AddNewBarbers.Enabled = false;
            }
            foreach (var item in chif)
            {
                if (dgv_Barbers.CurrentRow.Cells[7].Value.ToString() == item.ToString())
                {
                    btn_AddNewBarbers.Enabled = false;
                    btn_deleteBarber.Enabled = false;
                }
                else
                {
                    btn_AddNewBarbers.Enabled = true;
                    btn_deleteBarber.Enabled = true;
                }
            }

            
        }

        private void btn_UpdateBarber_Click(object sender, EventArgs e)
        {
            Barber b = db.Barbers.FirstOrDefault(ba => ba.Id.Equals(id));
            b.FIO = txb_AddNewBarbersFIO.Text;
            b.Gender = GenderCheck.Checked;
            b.PhoneNumber = Convert.ToInt32(txb_PhoneNumber.Text);
            b.Email = txb_Email.Text;
            b.Birthday = Convert.ToDateTime(dateTime_Birthday.Value.ToShortDateString());
            b.DateAdmission = Convert.ToDateTime(dateTimeDateAdmission.Value.ToShortDateString());
            b.PostionId = Convert.ToInt32(cmb_BarbersPostionId.SelectedValue);
            db.SaveChanges();
        }
        private void btn_deleteBarber_Click(object sender, EventArgs e)
        {
            Barber b = dgv_Barbers.SelectedRows[0].DataBoundItem as Barber;
            if (b == null)
            { return; }
            db.Barbers.Remove(b);
            db.SaveChanges();
            dgv_Barbers.DataSource = db.Barbers.ToList();
        }

        private void btn_showAllClients_Click(object sender, EventArgs e)
        {
            dgv_Clients.DataSource = db.Clients.ToList();
            dgv_Clients.Columns["ArchiveVisits"].Visible = false;
        }

        private void btn_AddNewClient_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txb_ClientEmail.Text)
                           && String.IsNullOrEmpty(txb_ClientPhone.Text)
                           && String.IsNullOrEmpty(txb_ClientFio.Text))
            {
                MessageBox.Show("Неправильны ввод или пустые поля");
            }
            else
            {
                Client c = new Client()
                {
                    FIO = txb_ClientFio.Text,
                    PhoneNumber = Convert.ToInt32(txb_ClientPhone.Text),
                    Email = txb_ClientEmail.Text,
                    DateAdmission = Convert.ToDateTime(dateTimeClientDate.Value.ToShortDateString()),
                };
                db.Clients.Add(c);
                db.SaveChanges();
            }

        }

        private void txb_ClientPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dgv_Clients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgv_Clients.CurrentRow.Cells[0].Value);
            txb_ClientFio.Text = dgv_Clients.CurrentRow.Cells[1].Value.ToString();
            txb_ClientPhone.Text = dgv_Clients.CurrentRow.Cells[2].Value.ToString();
            txb_ClientEmail.Text = dgv_Clients.CurrentRow.Cells[3].Value.ToString();
            dateTimeClientDate.Value = Convert.ToDateTime(dgv_Clients.CurrentRow.Cells[4].Value);
        }

        private void btn_UpdateClient_Click(object sender, EventArgs e)
        {
            Client c = db.Clients.FirstOrDefault(ba => ba.Id.Equals(id));
            c.FIO = txb_ClientFio.Text;
            c.PhoneNumber = Convert.ToInt32(txb_ClientPhone.Text);
            c.Email = txb_ClientEmail.Text;          
            c.DateAdmission = Convert.ToDateTime(dateTimeClientDate.Value.ToShortDateString());
            db.SaveChanges();
        }

        private void btn_deleteClient_Click(object sender, EventArgs e)
        {
            Client c = dgv_Clients.SelectedRows[0].DataBoundItem as Client;
            if (c == null)
            { return; }
            db.Clients.Remove(c);
            db.SaveChanges();
            dgv_Barbers.DataSource = db.Clients.ToList();
        }

        private void btn_showAllBS_Click(object sender, EventArgs e)
        {
            dgv_BS.DataSource = db.BarberServices.ToList();
            dgv_BS.Columns["servicesList"].Visible = false;
            dgv_BS.Columns["barber"].Visible = false;
        }

        private void btn_addNewBS_Click(object sender, EventArgs e)
        {
            BarberService bs = new BarberService()
                {
                    BarberId = Convert.ToInt32(cmb_BarbersId.SelectedValue),
                    ServiceId = Convert.ToInt32(cmb_serviceId.SelectedValue)
                };
                db.BarberServices.Add(bs);
                db.SaveChanges();
        }

        private void btn_UpdateBS_Click(object sender, EventArgs e)
        {
            BarberService bs = db.BarberServices.FirstOrDefault(ba => ba.Id.Equals(id));
            bs.BarberId = Convert.ToInt32(cmb_BarbersId.SelectedValue);
            bs.ServiceId = Convert.ToInt32(cmb_serviceId.SelectedValue);
            db.SaveChanges();
        }

        private void btn_DeleteBS_Click(object sender, EventArgs e)
        {
            BarberService bs = dgv_BS.SelectedRows[0].DataBoundItem as BarberService;
            if (bs == null)
            { return; }
            db.BarberServices.Remove(bs);
            db.SaveChanges();
        }
        private void addAllPositions()
        {
            Position p1 = new Position()
            {
                Name = "Джун"
            };
            Position p2 = new Position()
            {
                Name = "Сеньор"
            };
            Position p3 = new Position()
            {
                Name = "Чиф"
            };
            db.Positions.Add(p1);
            db.Positions.Add(p2);
            db.Positions.Add(p3);
            db.SaveChanges();
        }
        private void btn_showAllSchedules_Click(object sender, EventArgs e)
        {
            dgv_Schedules.DataSource = db.Schedules.ToList();
            dgv_Schedules.Columns["barber"].Visible = false;
        }

        private void btn_addNewSchedules_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            var t = new TimeSpan((int)num_freeTimeSchedulesHour.Value, (int)num_freeTimeSchedulesMinute.Value, (int)num_freeTimeSchedulesSEc.Value);

            Schedule sc = new Schedule()
            {
                BarberId = Convert.ToInt32(cmb_BarberIdSchedules.SelectedValue),
                FreeDate = Convert.ToDateTime(dateTimeSchedules.Value.ToShortDateString()),
                FreeTime = t
            };
                db.Schedules.Add(sc);
                db.SaveChanges();  
        }

        private void btn_UpdateSchedules_Click(object sender, EventArgs e)
        {
            var t = new TimeSpan((int)num_freeTimeSchedulesHour.Value, (int)num_freeTimeSchedulesMinute.Value, (int)num_freeTimeSchedulesSEc.Value);
            Schedule sc = db.Schedules.FirstOrDefault(ba => ba.Id.Equals(id));
            sc.BarberId = Convert.ToInt32(cmb_BarbersId.SelectedValue);
            sc.FreeDate = Convert.ToDateTime(dateTimeSchedules.Value.ToShortDateString());
            sc.FreeTime = t;
            db.SaveChanges();
        }

        private void btn_deleteSchedules_Click(object sender, EventArgs e)
        {
            Schedule sc = dgv_Schedules.SelectedRows[0].DataBoundItem as Schedule;
            if (sc == null)
            { return; }
            db.Schedules.Remove(sc);
            db.SaveChanges();
        }

        private void dgv_Schedules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgv_Schedules.CurrentRow.Cells[0].Value);
            cmb_BarberIdSchedules.SelectedValue = dgv_Schedules.CurrentRow.Cells[1].Value;
            dateTimeSchedules.Value = Convert.ToDateTime(dgv_Schedules.CurrentRow.Cells[2].Value);
        }

        private void dgv_BS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          cmb_BarbersId.SelectedValue = Convert.ToInt32(dgv_BS.CurrentRow.Cells[1].Value);
          cmb_serviceId.SelectedValue = Convert.ToInt32(dgv_BS.CurrentRow.Cells[2].Value);        
        }

        private void txb_ServicePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_ShowAllServices_Click(object sender, EventArgs e)
        {
            dgv_Services.DataSource = db.servicesLists.ToList();
            dgv_Services.Columns["ArchiveVisits"].Visible = false;
            dgv_Services.Columns["BarberServices"].Visible = false;
        }

        private void btn_addNewServices_Click(object sender, EventArgs e)
        {
            var t = new TimeSpan((int)num_ServiceHour.Value, (int)num_ServiceMinute.Value, (int)num_ServiceMinute.Value);
            if (String.IsNullOrEmpty(txb_ServicesName.Text)
                           && t == null
                           && String.IsNullOrEmpty(txb_ServicePrice.Text))
            {
                MessageBox.Show("Неправильны ввод или пустые поля");
            }
            else
            {
                servicesList sl = new servicesList()
                {
                   Name = txb_ServicesName.Text,
                   Price = Convert.ToInt32(txb_ServicePrice.Text),
                   Time = t
                };
                db.servicesLists.Add(sl);
                db.SaveChanges();
            }
        }

        private void btn_ServiceUpdate_Click(object sender, EventArgs e)
        {
            var t = new TimeSpan((int)num_ServiceHour.Value, (int)num_ServiceMinute.Value, (int)num_ServiceMinute.Value);
            servicesList sc = db.servicesLists.FirstOrDefault(ba => ba.Id.Equals(id));
            sc.Name = txb_ServicesName.Text;
            sc.Price = Convert.ToInt32(txb_ServicePrice.Text);
            sc.Time = t;
            db.SaveChanges();
        }

        private void btn_deleteServices_Click(object sender, EventArgs e)
        {
            servicesList sl = dgv_Schedules.SelectedRows[0].DataBoundItem as servicesList;
            if (sl == null)
            { return; }
            db.servicesLists.Remove(sl);
            db.SaveChanges();
        }

        private void btn_ShowAllVisits_Click(object sender, EventArgs e)
        {
            dgv_Archive.DataSource = db.ArchiveVisits.ToList();
            dgv_Archive.Columns["Barber"].Visible = false;
            dgv_Archive.Columns["Client"].Visible = false;
            dgv_Archive.Columns["servicesList"].Visible = false;
        }

        private void btn_addNewArchive_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txb_PriceArchive.Text)                     
                           && String.IsNullOrEmpty(txb_ServicePrice.Text)
                           && String.IsNullOrEmpty(txb_ArchiveFeedback.Text))
            {
                MessageBox.Show("Неправильны ввод или пустые поля");
            }
            else
            {
                ArchiveVisit av = new ArchiveVisit()
                {
                    ClientId = Convert.ToInt32(cmb_ArchiveCltId.SelectedValue),
                    BarberId = Convert.ToInt32(cmb_ArchiveBarbersId.SelectedValue),
                    Date = Convert.ToDateTime(dateTimeArchiveDate.Value.ToShortDateString()),
                    Price = Convert.ToInt32(txb_PriceArchive.Text),
                    Rating = Convert.ToInt32(num_ArchiveRating.Value),
                    Feedback = txb_ArchiveFeedback.Text,                   
                    ServiceId = Convert.ToInt32(cmb_servicesIdArchive.SelectedValue)

                };
                db.ArchiveVisits.Add(av);
                db.SaveChanges();
            }
        }

        private void btn_updateArchive_Click(object sender, EventArgs e)
        {

            ArchiveVisit av = db.ArchiveVisits.FirstOrDefault(ba => ba.Id.Equals(id));

            av.ClientId = Convert.ToInt32(cmb_ArchiveCltId.SelectedValue);
            av.BarberId = Convert.ToInt32(cmb_ArchiveBarbersId.SelectedValue);
            av.Date = Convert.ToDateTime(dateTimeArchiveDate.Value.ToShortDateString());
            av.Price = Convert.ToInt32(txb_PriceArchive.Text);
            av.Rating = Convert.ToInt32(num_ArchiveRating.Value);
            av.Feedback = txb_ArchiveFeedback.Text;
            av.ServiceId = Convert.ToInt32(cmb_servicesIdArchive.SelectedValue);
            db.SaveChanges();
        }

        private void btn_deleteArchive_Click(object sender, EventArgs e)
        {
            ArchiveVisit av = dgv_Schedules.SelectedRows[0].DataBoundItem as ArchiveVisit;
            if (av == null)
            { return; }
            db.ArchiveVisits.Remove(av);
            db.SaveChanges();
        }

        private void dgv_Archive_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgv_BS.CurrentRow.Cells[0].Value);

            cmb_ArchiveCltId.SelectedValue = Convert.ToInt32(dgv_BS.CurrentRow.Cells[1].Value);
            cmb_ArchiveBarbersId.SelectedValue = Convert.ToInt32(dgv_BS.CurrentRow.Cells[2].Value);
            dateTimeArchiveDate.Value = Convert.ToDateTime(dgv_Archive.CurrentRow.Cells[3].Value);
            txb_PriceArchive.Text = dgv_Archive.CurrentRow.Cells[4].Value.ToString();
            lbl_FeedbackArchive.Text = dgv_Archive.CurrentRow.Cells[6].Value.ToString();
            cmb_servicesIdArchive.SelectedValue = Convert.ToInt32(dgv_BS.CurrentRow.Cells[7].Value);
        }

        private void dgv_Services_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgv_Services.CurrentRow.Cells[0].Value);
            txb_ServicesName.Text = dgv_Services.CurrentRow.Cells[1].Value.ToString();
            txb_ServicePrice.Text = dgv_Services.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
