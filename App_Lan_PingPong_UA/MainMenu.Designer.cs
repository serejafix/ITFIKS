
namespace App_Lan_PingPong_UA
{
    partial class MainMenu
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
            this.button_Multiplayer = new System.Windows.Forms.Button();
            this.Button_SinglePlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Multiplayer
            // 
            this.button_Multiplayer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_Multiplayer.Location = new System.Drawing.Point(259, 181);
            this.button_Multiplayer.Name = "button_Multiplayer";
            this.button_Multiplayer.Size = new System.Drawing.Size(158, 28);
            this.button_Multiplayer.TabIndex = 3;
            this.button_Multiplayer.Text = "MULTIPLAYER";
            this.button_Multiplayer.UseVisualStyleBackColor = false;
            this.button_Multiplayer.Click += new System.EventHandler(this.button_Admin_Click);
            // 
            // Button_SinglePlayer
            // 
            this.Button_SinglePlayer.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Button_SinglePlayer.Location = new System.Drawing.Point(259, 147);
            this.Button_SinglePlayer.Name = "Button_SinglePlayer";
            this.Button_SinglePlayer.Size = new System.Drawing.Size(158, 28);
            this.Button_SinglePlayer.TabIndex = 4;
            this.Button_SinglePlayer.Text = "SINGLEPLAYER";
            this.Button_SinglePlayer.UseVisualStyleBackColor = false;
            // 
            // Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::App_Lan_PingPong_UA.Properties.Resources.image;
            this.ClientSize = new System.Drawing.Size(656, 339);
            this.Controls.Add(this.Button_SinglePlayer);
            this.Controls.Add(this.button_Multiplayer);
            this.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.Name = "Connect";
            this.Text = "Connect";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Multiplayer;
        private System.Windows.Forms.Button Button_SinglePlayer;
    }
}