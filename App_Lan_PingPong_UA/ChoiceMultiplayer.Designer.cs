
namespace App_Lan_PingPong_UA
{
    partial class ChoiceMultiplayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoiceMultiplayer));
            this.button1 = new System.Windows.Forms.Button();
            this.label_PlayerName = new System.Windows.Forms.Label();
            this.textBox_EnterName = new System.Windows.Forms.TextBox();
            this.button_BacktoMainMenu = new System.Windows.Forms.Button();
            this.textBox_EnterIP = new System.Windows.Forms.TextBox();
            this.label_IP = new System.Windows.Forms.Label();
            this.button_EnterIP = new System.Windows.Forms.Button();
            this.button_Admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(267, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ENTER";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label_PlayerName
            // 
            this.label_PlayerName.AutoSize = true;
            this.label_PlayerName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_PlayerName.Location = new System.Drawing.Point(32, 80);
            this.label_PlayerName.Name = "label_PlayerName";
            this.label_PlayerName.Size = new System.Drawing.Size(86, 13);
            this.label_PlayerName.TabIndex = 1;
            this.label_PlayerName.Text = "PLAYER NAME:";
            // 
            // textBox_EnterName
            // 
            this.textBox_EnterName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox_EnterName.Location = new System.Drawing.Point(124, 77);
            this.textBox_EnterName.Name = "textBox_EnterName";
            this.textBox_EnterName.Size = new System.Drawing.Size(137, 20);
            this.textBox_EnterName.TabIndex = 2;
            // 
            // button_BacktoMainMenu
            // 
            this.button_BacktoMainMenu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_BacktoMainMenu.Location = new System.Drawing.Point(141, 261);
            this.button_BacktoMainMenu.Name = "button_BacktoMainMenu";
            this.button_BacktoMainMenu.Size = new System.Drawing.Size(106, 23);
            this.button_BacktoMainMenu.TabIndex = 3;
            this.button_BacktoMainMenu.Text = "EXIT";
            this.button_BacktoMainMenu.UseVisualStyleBackColor = false;
            this.button_BacktoMainMenu.Click += new System.EventHandler(this.button_BacktoMainMenu_Click);
            // 
            // textBox_EnterIP
            // 
            this.textBox_EnterIP.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox_EnterIP.Location = new System.Drawing.Point(124, 141);
            this.textBox_EnterIP.Name = "textBox_EnterIP";
            this.textBox_EnterIP.Size = new System.Drawing.Size(137, 20);
            this.textBox_EnterIP.TabIndex = 6;
            // 
            // label_IP
            // 
            this.label_IP.AutoSize = true;
            this.label_IP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_IP.Location = new System.Drawing.Point(95, 144);
            this.label_IP.Name = "label_IP";
            this.label_IP.Size = new System.Drawing.Size(23, 13);
            this.label_IP.TabIndex = 5;
            this.label_IP.Text = "IP :";
            // 
            // button_EnterIP
            // 
            this.button_EnterIP.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_EnterIP.Location = new System.Drawing.Point(267, 139);
            this.button_EnterIP.Name = "button_EnterIP";
            this.button_EnterIP.Size = new System.Drawing.Size(75, 23);
            this.button_EnterIP.TabIndex = 4;
            this.button_EnterIP.Text = "ENTER";
            this.button_EnterIP.UseVisualStyleBackColor = false;
            this.button_EnterIP.Click += new System.EventHandler(this.button__Click);
            // 
            // button_Admin
            // 
            this.button_Admin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_Admin.Location = new System.Drawing.Point(155, 196);
            this.button_Admin.Name = "button_Admin";
            this.button_Admin.Size = new System.Drawing.Size(75, 23);
            this.button_Admin.TabIndex = 7;
            this.button_Admin.Text = "ADMIN";
            this.button_Admin.UseVisualStyleBackColor = false;
            this.button_Admin.Click += new System.EventHandler(this.button_Admin_Click);
            // 
            // ChoiceMultiplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(395, 296);
            this.Controls.Add(this.button_Admin);
            this.Controls.Add(this.textBox_EnterIP);
            this.Controls.Add(this.label_IP);
            this.Controls.Add(this.button_EnterIP);
            this.Controls.Add(this.button_BacktoMainMenu);
            this.Controls.Add(this.textBox_EnterName);
            this.Controls.Add(this.label_PlayerName);
            this.Controls.Add(this.button1);
            this.Name = "ChoiceMultiplayer";
            this.Text = "ChoiceMultiplayer";
            this.Load += new System.EventHandler(this.ChoiceMultiplayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_PlayerName;
        private System.Windows.Forms.TextBox textBox_EnterName;
        private System.Windows.Forms.Button button_BacktoMainMenu;
        private System.Windows.Forms.TextBox textBox_EnterIP;
        private System.Windows.Forms.Label label_IP;
        private System.Windows.Forms.Button button_EnterIP;
        private System.Windows.Forms.Button button_Admin;
    }
}