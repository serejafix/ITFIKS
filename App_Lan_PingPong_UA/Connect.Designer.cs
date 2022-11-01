
namespace App_Lan_PingPong_UA
{
    partial class Connect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_con = new System.Windows.Forms.GroupBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.txb_IP = new System.Windows.Forms.TextBox();
            this.lbl_Ip = new System.Windows.Forms.Label();
            this.button_Admin = new System.Windows.Forms.Button();
            this.groupBox_con.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_con
            // 
            this.groupBox_con.Controls.Add(this.lbl_Ip);
            this.groupBox_con.Controls.Add(this.txb_IP);
            this.groupBox_con.Controls.Add(this.btn_Connect);
            this.groupBox_con.Location = new System.Drawing.Point(13, 13);
            this.groupBox_con.Name = "groupBox_con";
            this.groupBox_con.Size = new System.Drawing.Size(448, 103);
            this.groupBox_con.TabIndex = 0;
            this.groupBox_con.TabStop = false;
            this.groupBox_con.Text = "Подключалка";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(348, 41);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 0;
            this.btn_Connect.Text = "Старт!";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // txb_IP
            // 
            this.txb_IP.Location = new System.Drawing.Point(75, 41);
            this.txb_IP.Name = "txb_IP";
            this.txb_IP.Size = new System.Drawing.Size(232, 20);
            this.txb_IP.TabIndex = 1;
            // 
            // lbl_Ip
            // 
            this.lbl_Ip.AutoSize = true;
            this.lbl_Ip.Location = new System.Drawing.Point(17, 47);
            this.lbl_Ip.Name = "lbl_Ip";
            this.lbl_Ip.Size = new System.Drawing.Size(41, 13);
            this.lbl_Ip.TabIndex = 2;
            this.lbl_Ip.Text = "АЙПИ:";
            // 
            // button_Admin
            // 
            this.button_Admin.Location = new System.Drawing.Point(13, 122);
            this.button_Admin.Name = "button_Admin";
            this.button_Admin.Size = new System.Drawing.Size(448, 38);
            this.button_Admin.TabIndex = 3;
            this.button_Admin.Text = "Я АДМИН! ЖДУН";
            this.button_Admin.UseVisualStyleBackColor = true;
            this.button_Admin.Click += new System.EventHandler(this.button_Admin_Click);
            // 
            // Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 172);
            this.Controls.Add(this.button_Admin);
            this.Controls.Add(this.groupBox_con);
            this.Name = "Connect";
            this.Text = "Connect";
            this.groupBox_con.ResumeLayout(false);
            this.groupBox_con.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_con;
        private System.Windows.Forms.Label lbl_Ip;
        private System.Windows.Forms.TextBox txb_IP;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button button_Admin;
    }
}