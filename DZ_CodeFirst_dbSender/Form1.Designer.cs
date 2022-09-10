
namespace DZ_CodeFirst_dbSender
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.btn_allClients = new System.Windows.Forms.Button();
            this.lbl_AllClients = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.btn_AllEmail = new System.Windows.Forms.Button();
            this.lbl_ByCity = new System.Windows.Forms.Label();
            this.btn_ByCity = new System.Windows.Forms.Button();
            this.txb_SearchByCity = new System.Windows.Forms.TextBox();
            this.txb_SearchByCountry = new System.Windows.Forms.TextBox();
            this.lbl_ByCoutry = new System.Windows.Forms.Label();
            this.btn_ByCountry = new System.Windows.Forms.Button();
            this.lbl_showALlDiscont = new System.Windows.Forms.Label();
            this.btn_AllDiscont = new System.Windows.Forms.Button();
            this.lbl_DisccontByCountry = new System.Windows.Forms.Label();
            this.btn_DisctontByCountry = new System.Windows.Forms.Button();
            this.txb_SearchDiscontByCountry = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(12, 111);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.Size = new System.Drawing.Size(776, 327);
            this.dgvTable.TabIndex = 0;
            // 
            // btn_allClients
            // 
            this.btn_allClients.Location = new System.Drawing.Point(13, 43);
            this.btn_allClients.Name = "btn_allClients";
            this.btn_allClients.Size = new System.Drawing.Size(75, 23);
            this.btn_allClients.TabIndex = 1;
            this.btn_allClients.Text = "Execute";
            this.btn_allClients.UseVisualStyleBackColor = true;
            this.btn_allClients.Click += new System.EventHandler(this.btn_allClients_Click);
            // 
            // lbl_AllClients
            // 
            this.lbl_AllClients.AutoSize = true;
            this.lbl_AllClients.Location = new System.Drawing.Point(13, 13);
            this.lbl_AllClients.Name = "lbl_AllClients";
            this.lbl_AllClients.Size = new System.Drawing.Size(80, 13);
            this.lbl_AllClients.TabIndex = 2;
            this.lbl_AllClients.Text = "Show All Cients";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(96, 13);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(76, 13);
            this.lbl_Email.TabIndex = 4;
            this.lbl_Email.Text = "Show All Email";
            // 
            // btn_AllEmail
            // 
            this.btn_AllEmail.Location = new System.Drawing.Point(96, 43);
            this.btn_AllEmail.Name = "btn_AllEmail";
            this.btn_AllEmail.Size = new System.Drawing.Size(75, 23);
            this.btn_AllEmail.TabIndex = 3;
            this.btn_AllEmail.Text = "Execute";
            this.btn_AllEmail.UseVisualStyleBackColor = true;
            this.btn_AllEmail.Click += new System.EventHandler(this.btn_AllEmail_Click);
            // 
            // lbl_ByCity
            // 
            this.lbl_ByCity.AutoSize = true;
            this.lbl_ByCity.Location = new System.Drawing.Point(178, 13);
            this.lbl_ByCity.Name = "lbl_ByCity";
            this.lbl_ByCity.Size = new System.Drawing.Size(68, 13);
            this.lbl_ByCity.TabIndex = 6;
            this.lbl_ByCity.Text = "Show All City";
            // 
            // btn_ByCity
            // 
            this.btn_ByCity.Location = new System.Drawing.Point(178, 43);
            this.btn_ByCity.Name = "btn_ByCity";
            this.btn_ByCity.Size = new System.Drawing.Size(75, 23);
            this.btn_ByCity.TabIndex = 5;
            this.btn_ByCity.Text = "Execute";
            this.btn_ByCity.UseVisualStyleBackColor = true;
            this.btn_ByCity.Click += new System.EventHandler(this.btn_ByCity_Click);
            // 
            // txb_SearchByCity
            // 
            this.txb_SearchByCity.Location = new System.Drawing.Point(259, 43);
            this.txb_SearchByCity.Name = "txb_SearchByCity";
            this.txb_SearchByCity.Size = new System.Drawing.Size(81, 20);
            this.txb_SearchByCity.TabIndex = 7;
            // 
            // txb_SearchByCountry
            // 
            this.txb_SearchByCountry.Location = new System.Drawing.Point(434, 43);
            this.txb_SearchByCountry.Name = "txb_SearchByCountry";
            this.txb_SearchByCountry.Size = new System.Drawing.Size(76, 20);
            this.txb_SearchByCountry.TabIndex = 10;
            // 
            // lbl_ByCoutry
            // 
            this.lbl_ByCoutry.AutoSize = true;
            this.lbl_ByCoutry.Location = new System.Drawing.Point(351, 11);
            this.lbl_ByCoutry.Name = "lbl_ByCoutry";
            this.lbl_ByCoutry.Size = new System.Drawing.Size(88, 13);
            this.lbl_ByCoutry.TabIndex = 9;
            this.lbl_ByCoutry.Text = "Show By Country";
            // 
            // btn_ByCountry
            // 
            this.btn_ByCountry.Location = new System.Drawing.Point(351, 41);
            this.btn_ByCountry.Name = "btn_ByCountry";
            this.btn_ByCountry.Size = new System.Drawing.Size(75, 23);
            this.btn_ByCountry.TabIndex = 8;
            this.btn_ByCountry.Text = "Execute";
            this.btn_ByCountry.UseVisualStyleBackColor = true;
            this.btn_ByCountry.Click += new System.EventHandler(this.btn_ByCountry_Click);
            // 
            // lbl_showALlDiscont
            // 
            this.lbl_showALlDiscont.AutoSize = true;
            this.lbl_showALlDiscont.Location = new System.Drawing.Point(528, 12);
            this.lbl_showALlDiscont.Name = "lbl_showALlDiscont";
            this.lbl_showALlDiscont.Size = new System.Drawing.Size(90, 13);
            this.lbl_showALlDiscont.TabIndex = 12;
            this.lbl_showALlDiscont.Text = "Show All Disctont";
            // 
            // btn_AllDiscont
            // 
            this.btn_AllDiscont.Location = new System.Drawing.Point(528, 42);
            this.btn_AllDiscont.Name = "btn_AllDiscont";
            this.btn_AllDiscont.Size = new System.Drawing.Size(75, 23);
            this.btn_AllDiscont.TabIndex = 11;
            this.btn_AllDiscont.Text = "Execute";
            this.btn_AllDiscont.UseVisualStyleBackColor = true;
            this.btn_AllDiscont.Click += new System.EventHandler(this.btn_AllDiscont_Click);
            // 
            // lbl_DisccontByCountry
            // 
            this.lbl_DisccontByCountry.AutoSize = true;
            this.lbl_DisccontByCountry.Location = new System.Drawing.Point(621, 11);
            this.lbl_DisccontByCountry.Name = "lbl_DisccontByCountry";
            this.lbl_DisccontByCountry.Size = new System.Drawing.Size(130, 13);
            this.lbl_DisccontByCountry.TabIndex = 14;
            this.lbl_DisccontByCountry.Text = "Show Disctont By Country";
            // 
            // btn_DisctontByCountry
            // 
            this.btn_DisctontByCountry.Location = new System.Drawing.Point(618, 41);
            this.btn_DisctontByCountry.Name = "btn_DisctontByCountry";
            this.btn_DisctontByCountry.Size = new System.Drawing.Size(75, 23);
            this.btn_DisctontByCountry.TabIndex = 13;
            this.btn_DisctontByCountry.Text = "Execute";
            this.btn_DisctontByCountry.UseVisualStyleBackColor = true;
            this.btn_DisctontByCountry.Click += new System.EventHandler(this.button1_Click);
            // 
            // txb_SearchDiscontByCountry
            // 
            this.txb_SearchDiscontByCountry.Location = new System.Drawing.Point(695, 43);
            this.txb_SearchDiscontByCountry.Name = "txb_SearchDiscontByCountry";
            this.txb_SearchDiscontByCountry.Size = new System.Drawing.Size(93, 20);
            this.txb_SearchDiscontByCountry.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txb_SearchDiscontByCountry);
            this.Controls.Add(this.lbl_DisccontByCountry);
            this.Controls.Add(this.btn_DisctontByCountry);
            this.Controls.Add(this.lbl_showALlDiscont);
            this.Controls.Add(this.btn_AllDiscont);
            this.Controls.Add(this.txb_SearchByCountry);
            this.Controls.Add(this.lbl_ByCoutry);
            this.Controls.Add(this.btn_ByCountry);
            this.Controls.Add(this.txb_SearchByCity);
            this.Controls.Add(this.lbl_ByCity);
            this.Controls.Add(this.btn_ByCity);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.btn_AllEmail);
            this.Controls.Add(this.lbl_AllClients);
            this.Controls.Add(this.btn_allClients);
            this.Controls.Add(this.dgvTable);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Button btn_allClients;
        private System.Windows.Forms.Label lbl_AllClients;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Button btn_AllEmail;
        private System.Windows.Forms.Label lbl_ByCity;
        private System.Windows.Forms.Button btn_ByCity;
        private System.Windows.Forms.TextBox txb_SearchByCity;
        private System.Windows.Forms.TextBox txb_SearchByCountry;
        private System.Windows.Forms.Label lbl_ByCoutry;
        private System.Windows.Forms.Button btn_ByCountry;
        private System.Windows.Forms.Label lbl_showALlDiscont;
        private System.Windows.Forms.Button btn_AllDiscont;
        private System.Windows.Forms.Label lbl_DisccontByCountry;
        private System.Windows.Forms.Button btn_DisctontByCountry;
        private System.Windows.Forms.TextBox txb_SearchDiscontByCountry;
    }
}

