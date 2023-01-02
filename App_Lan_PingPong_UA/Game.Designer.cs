
namespace App_Lan_PingPong_UA
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.player1 = new System.Windows.Forms.Timer(this.components);
            this.player2 = new System.Windows.Forms.Timer(this.components);
            this.playground = new System.Windows.Forms.Panel();
            this.label_point = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_scorefirst = new System.Windows.Forms.Label();
            this.label_scoreSec = new System.Windows.Forms.Label();
            this.label_playerfirst = new System.Windows.Forms.Label();
            this.label_palyersec = new System.Windows.Forms.Label();
            this.label_SCORE = new System.Windows.Forms.Label();
            this.rocket2 = new System.Windows.Forms.PictureBox();
            this.rocket = new System.Windows.Forms.PictureBox();
            this.timer_AddBonus = new System.Windows.Forms.Timer(this.components);
            this.ball = new App_Lan_PingPong_UA.RoundBall();
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rocket2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.Interval = 1;
            // 
            // playground
            // 
            this.playground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playground.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.label_point);
            this.playground.Controls.Add(this.label1);
            this.playground.Controls.Add(this.label_scorefirst);
            this.playground.Controls.Add(this.label_scoreSec);
            this.playground.Controls.Add(this.label_playerfirst);
            this.playground.Controls.Add(this.label_palyersec);
            this.playground.Controls.Add(this.label_SCORE);
            this.playground.Controls.Add(this.rocket2);
            this.playground.Controls.Add(this.rocket);
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(784, 561);
            this.playground.TabIndex = 0;
            // 
            // label_point
            // 
            this.label_point.AutoSize = true;
            this.label_point.Location = new System.Drawing.Point(378, 274);
            this.label_point.Name = "label_point";
            this.label_point.Size = new System.Drawing.Size(0, 13);
            this.label_point.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "COUNT:";
            // 
            // label_scorefirst
            // 
            this.label_scorefirst.AutoSize = true;
            this.label_scorefirst.Location = new System.Drawing.Point(256, 222);
            this.label_scorefirst.Name = "label_scorefirst";
            this.label_scorefirst.Size = new System.Drawing.Size(0, 13);
            this.label_scorefirst.TabIndex = 9;
            // 
            // label_scoreSec
            // 
            this.label_scoreSec.AutoSize = true;
            this.label_scoreSec.Location = new System.Drawing.Point(468, 222);
            this.label_scoreSec.Name = "label_scoreSec";
            this.label_scoreSec.Size = new System.Drawing.Size(0, 13);
            this.label_scoreSec.TabIndex = 8;
            // 
            // label_playerfirst
            // 
            this.label_playerfirst.AutoSize = true;
            this.label_playerfirst.Location = new System.Drawing.Point(404, 222);
            this.label_playerfirst.Name = "label_playerfirst";
            this.label_playerfirst.Size = new System.Drawing.Size(61, 13);
            this.label_playerfirst.TabIndex = 7;
            this.label_playerfirst.Text = "PLAYER 2:";
            // 
            // label_palyersec
            // 
            this.label_palyersec.AutoSize = true;
            this.label_palyersec.Location = new System.Drawing.Point(297, 222);
            this.label_palyersec.Name = "label_palyersec";
            this.label_palyersec.Size = new System.Drawing.Size(64, 13);
            this.label_palyersec.TabIndex = 6;
            this.label_palyersec.Text = ":1 PLAYER ";
            // 
            // label_SCORE
            // 
            this.label_SCORE.AutoSize = true;
            this.label_SCORE.Location = new System.Drawing.Point(358, 193);
            this.label_SCORE.Name = "label_SCORE";
            this.label_SCORE.Size = new System.Drawing.Size(47, 13);
            this.label_SCORE.TabIndex = 5;
            this.label_SCORE.Text = "SCORE:";
            // 
            // rocket2
            // 
            this.rocket2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rocket2.BackgroundImage = global::App_Lan_PingPong_UA.Properties.Resources.blockWood__1_;
            this.rocket2.Location = new System.Drawing.Point(592, 12);
            this.rocket2.Name = "rocket2";
            this.rocket2.Size = new System.Drawing.Size(189, 18);
            this.rocket2.TabIndex = 2;
            this.rocket2.TabStop = false;
            // 
            // rocket
            // 
            this.rocket.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rocket.BackgroundImage = global::App_Lan_PingPong_UA.Properties.Resources.blockWood__1_;
            this.rocket.Location = new System.Drawing.Point(3, 531);
            this.rocket.Name = "rocket";
            this.rocket.Size = new System.Drawing.Size(189, 18);
            this.rocket.TabIndex = 0;
            this.rocket.TabStop = false;
            // 
            // timer_AddBonus
            // 
            this.timer_AddBonus.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.LightCoral;
            this.ball.Location = new System.Drawing.Point(261, 274);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(27, 23);
            this.ball.TabIndex = 12;
            this.ball.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.playground);
            this.Name = "Game";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rocket2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        public System.Windows.Forms.PictureBox rocket;
        private System.Windows.Forms.Timer player1;
        public System.Windows.Forms.PictureBox rocket2;
        private System.Windows.Forms.Timer player2;
        private System.Windows.Forms.Label label_scorefirst;
        private System.Windows.Forms.Label label_scoreSec;
        private System.Windows.Forms.Label label_playerfirst;
        private System.Windows.Forms.Label label_palyersec;
        private System.Windows.Forms.Label label_SCORE;
        private System.Windows.Forms.Label label_point;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_AddBonus;
        private RoundBall ball;
    }
}

