using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_DatabaseFirst_DBgames
{
 

    public partial class Form1 : Form
    {
        GamesEntities gamesEntitiesDB;
        
        public Form1()
        {
            InitializeComponent();

            gamesEntitiesDB = new GamesEntities();

        }

        private void btn_searchByName_Click(object sender, EventArgs e)
        {
            
            dgv_Query.DataSource = gamesEntitiesDB.Games.Where(n => n.Name == txb_SearchByName.Text).ToList();
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            dgv_Query.DataSource = gamesEntitiesDB.Games.ToList();
        }

        private void btn_SearchByStudio_Click(object sender, EventArgs e)
        {
            var res = (from g in gamesEntitiesDB.Games
                       where g.GameStyle.Name == txb_SearchByStyle.Text
                       select new
                       {
                           Id = g.id,
                           GameName = g.Name,
                           Style = g.GameStyle.Name,
                           Studio = g.StudioName,
                           Release = g.DateRelease
                       }).ToList();

            dgv_Query.DataSource = res;
        }

        private void btn_SearchByStudioName_Click(object sender, EventArgs e)
        {
            dgv_Query.DataSource = gamesEntitiesDB.Games.Where(n => n.Name == txb_StudioName.Text).ToList();
        }

        private void btn_DateRelease_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           
            dgv_Query.DataSource = gamesEntitiesDB.Games.Where(d => d.DateRelease == monthCalendar1.SelectionRange.Start).ToList();
        }
    }
}
