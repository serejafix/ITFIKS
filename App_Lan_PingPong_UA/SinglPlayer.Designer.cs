
namespace App_Lan_PingPong_UA
{
    partial class SinglPlayer
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
            this.components = new System.ComponentModel.Container();
            this.playground = new System.Windows.Forms.Panel();
            this.rocket = new System.Windows.Forms.PictureBox();
            this.timer_Singplayer = new System.Windows.Forms.Timer(this.components);
            this.label_esc = new System.Windows.Forms.Label();
            this.label_Escape = new XanderUI.XUIBanner();
            this.label_Score = new XanderUI.XUIBanner();
            this.label_reloadGame = new XanderUI.XUIBanner();
            this.ball = new App_Lan_PingPong_UA.RoundBall();
            this.Timer_AddBonus = new System.Windows.Forms.Timer(this.components);
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playground.Controls.Add(this.label_reloadGame);
            this.playground.Controls.Add(this.label_Score);
            this.playground.Controls.Add(this.label_Escape);
            this.playground.Controls.Add(this.label_esc);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.rocket);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(800, 450);
            this.playground.TabIndex = 0;
            // 
            // rocket
            // 
            this.rocket.BackgroundImage = global::App_Lan_PingPong_UA.Properties.Resources.blockWood__1_;
            this.rocket.Location = new System.Drawing.Point(282, 418);
            this.rocket.Name = "rocket";
            this.rocket.Size = new System.Drawing.Size(167, 20);
            this.rocket.TabIndex = 0;
            this.rocket.TabStop = false;
            // 
            // timer_Singplayer
            // 
            //this.timer_Singplayer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_esc
            // 
            this.label_esc.AutoSize = true;
            this.label_esc.Location = new System.Drawing.Point(13, 41);
            this.label_esc.Name = "label_esc";
            this.label_esc.Size = new System.Drawing.Size(0, 13);
            this.label_esc.TabIndex = 2;
            // 
            // label_Escape
            // 
            this.label_Escape.BackColor = System.Drawing.Color.Transparent;
            this.label_Escape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.label_Escape.BannerColor = System.Drawing.Color.Black;
            this.label_Escape.BorderColor = System.Drawing.Color.White;
            this.label_Escape.ForeColor = System.Drawing.Color.White;
            this.label_Escape.Location = new System.Drawing.Point(16, 12);
            this.label_Escape.Name = "label_Escape";
            this.label_Escape.Size = new System.Drawing.Size(100, 20);
            this.label_Escape.TabIndex = 3;
            this.label_Escape.Text = "Escape-Close";
            // 
            // label_Score
            // 
            this.label_Score.BackColor = System.Drawing.Color.Transparent;
            this.label_Score.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.label_Score.BannerColor = System.Drawing.Color.Black;
            this.label_Score.BorderColor = System.Drawing.Color.White;
            this.label_Score.ForeColor = System.Drawing.Color.White;
            this.label_Score.Location = new System.Drawing.Point(16, 67);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(100, 20);
            this.label_Score.TabIndex = 4;
            this.label_Score.Text = "Scrore:";
            // 
            // label_reloadGame
            // 
            this.label_reloadGame.BackColor = System.Drawing.Color.Transparent;
            this.label_reloadGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.label_reloadGame.BannerColor = System.Drawing.Color.Black;
            this.label_reloadGame.BorderColor = System.Drawing.Color.White;
            this.label_reloadGame.ForeColor = System.Drawing.Color.White;
            this.label_reloadGame.Location = new System.Drawing.Point(16, 41);
            this.label_reloadGame.Name = "label_reloadGame";
            this.label_reloadGame.Size = new System.Drawing.Size(100, 20);
            this.label_reloadGame.TabIndex = 5;
            this.label_reloadGame.Text = "F1_Reload";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.IndianRed;
            this.ball.Location = new System.Drawing.Point(334, 103);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(31, 26);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // Timer_AddBonus
            // 
            this.Timer_AddBonus.Enabled = true;
            this.Timer_AddBonus.Interval = 1;
            this.Timer_AddBonus.Tick += new System.EventHandler(this.Timer_AddBonus_Tick);
            // 
            // SinglPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playground);
            this.Name = "SinglPlayer";
            this.Text = "SinglPlayer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SinglPlayer_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.PictureBox rocket;
        private RoundBall ball;
        private System.Windows.Forms.Timer timer_Singplayer;
        private System.Windows.Forms.Label label_esc;
        private XanderUI.XUIBanner label_Escape;
        private XanderUI.XUIBanner label_Score;
        private XanderUI.XUIBanner label_reloadGame;
        private System.Windows.Forms.Timer Timer_AddBonus;
    }
}