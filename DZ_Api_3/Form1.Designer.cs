
namespace DZ_Api_3
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
            this.btn_Tusk1 = new System.Windows.Forms.Button();
            this.num_rndStart = new System.Windows.Forms.NumericUpDown();
            this.num_rnd_End = new System.Windows.Forms.NumericUpDown();
            this.lst_rnd_Tusk1 = new System.Windows.Forms.ListBox();
            this.lst_fibonachi = new System.Windows.Forms.ListBox();
            this.num_EndFibo = new System.Windows.Forms.NumericUpDown();
            this.btn_Thread2Abort = new System.Windows.Forms.Button();
            this.lbl_randomNumbers = new System.Windows.Forms.Label();
            this.lbl_Fibonachi = new System.Windows.Forms.Label();
            this.lbl_Start = new System.Windows.Forms.Label();
            this.lbl_end = new System.Windows.Forms.Label();
            this.lbl_EndFibo = new System.Windows.Forms.Label();
            this.btn_Thread1Abort = new System.Windows.Forms.Button();
            this.btn_pause2 = new System.Windows.Forms.Button();
            this.btn_Pause1 = new System.Windows.Forms.Button();
            this.btn_Resume1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_restart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_rndStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_rnd_End)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_EndFibo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Tusk1
            // 
            this.btn_Tusk1.Location = new System.Drawing.Point(10, 11);
            this.btn_Tusk1.Name = "btn_Tusk1";
            this.btn_Tusk1.Size = new System.Drawing.Size(79, 23);
            this.btn_Tusk1.TabIndex = 0;
            this.btn_Tusk1.Text = "Tusk Start";
            this.btn_Tusk1.UseVisualStyleBackColor = true;
            this.btn_Tusk1.Click += new System.EventHandler(this.btn_Tusk1_Click);
            // 
            // num_rndStart
            // 
            this.num_rndStart.Location = new System.Drawing.Point(13, 53);
            this.num_rndStart.Name = "num_rndStart";
            this.num_rndStart.Size = new System.Drawing.Size(31, 20);
            this.num_rndStart.TabIndex = 1;
            // 
            // num_rnd_End
            // 
            this.num_rnd_End.Location = new System.Drawing.Point(57, 53);
            this.num_rnd_End.Name = "num_rnd_End";
            this.num_rnd_End.Size = new System.Drawing.Size(31, 20);
            this.num_rnd_End.TabIndex = 2;
            // 
            // lst_rnd_Tusk1
            // 
            this.lst_rnd_Tusk1.FormattingEnabled = true;
            this.lst_rnd_Tusk1.Location = new System.Drawing.Point(13, 187);
            this.lst_rnd_Tusk1.Name = "lst_rnd_Tusk1";
            this.lst_rnd_Tusk1.Size = new System.Drawing.Size(75, 238);
            this.lst_rnd_Tusk1.TabIndex = 3;
            // 
            // lst_fibonachi
            // 
            this.lst_fibonachi.FormattingEnabled = true;
            this.lst_fibonachi.Location = new System.Drawing.Point(94, 187);
            this.lst_fibonachi.Name = "lst_fibonachi";
            this.lst_fibonachi.Size = new System.Drawing.Size(75, 238);
            this.lst_fibonachi.TabIndex = 7;
            // 
            // num_EndFibo
            // 
            this.num_EndFibo.Location = new System.Drawing.Point(115, 55);
            this.num_EndFibo.Name = "num_EndFibo";
            this.num_EndFibo.Size = new System.Drawing.Size(31, 20);
            this.num_EndFibo.TabIndex = 6;
            // 
            // btn_Thread2Abort
            // 
            this.btn_Thread2Abort.Location = new System.Drawing.Point(93, 133);
            this.btn_Thread2Abort.Name = "btn_Thread2Abort";
            this.btn_Thread2Abort.Size = new System.Drawing.Size(75, 23);
            this.btn_Thread2Abort.TabIndex = 4;
            this.btn_Thread2Abort.Text = "Stop2";
            this.btn_Thread2Abort.UseVisualStyleBackColor = true;
            this.btn_Thread2Abort.Click += new System.EventHandler(this.btn_Thread2Abort_Click);
            // 
            // lbl_randomNumbers
            // 
            this.lbl_randomNumbers.AutoSize = true;
            this.lbl_randomNumbers.Location = new System.Drawing.Point(13, 171);
            this.lbl_randomNumbers.Name = "lbl_randomNumbers";
            this.lbl_randomNumbers.Size = new System.Drawing.Size(75, 13);
            this.lbl_randomNumbers.TabIndex = 8;
            this.lbl_randomNumbers.Text = "RandomNumb";
            // 
            // lbl_Fibonachi
            // 
            this.lbl_Fibonachi.AutoSize = true;
            this.lbl_Fibonachi.Location = new System.Drawing.Point(101, 171);
            this.lbl_Fibonachi.Name = "lbl_Fibonachi";
            this.lbl_Fibonachi.Size = new System.Drawing.Size(53, 13);
            this.lbl_Fibonachi.TabIndex = 9;
            this.lbl_Fibonachi.Text = "Fibonachi";
            // 
            // lbl_Start
            // 
            this.lbl_Start.AutoSize = true;
            this.lbl_Start.Location = new System.Drawing.Point(15, 37);
            this.lbl_Start.Name = "lbl_Start";
            this.lbl_Start.Size = new System.Drawing.Size(29, 13);
            this.lbl_Start.TabIndex = 10;
            this.lbl_Start.Text = "Start";
            this.lbl_Start.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Location = new System.Drawing.Point(58, 37);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(26, 13);
            this.lbl_end.TabIndex = 11;
            this.lbl_end.Text = "End";
            this.lbl_end.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_EndFibo
            // 
            this.lbl_EndFibo.AutoSize = true;
            this.lbl_EndFibo.Location = new System.Drawing.Point(105, 39);
            this.lbl_EndFibo.Name = "lbl_EndFibo";
            this.lbl_EndFibo.Size = new System.Drawing.Size(49, 13);
            this.lbl_EndFibo.TabIndex = 12;
            this.lbl_EndFibo.Text = "End Fibo";
            this.lbl_EndFibo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Thread1Abort
            // 
            this.btn_Thread1Abort.Location = new System.Drawing.Point(9, 133);
            this.btn_Thread1Abort.Name = "btn_Thread1Abort";
            this.btn_Thread1Abort.Size = new System.Drawing.Size(75, 23);
            this.btn_Thread1Abort.TabIndex = 13;
            this.btn_Thread1Abort.Text = "Stop1";
            this.btn_Thread1Abort.UseVisualStyleBackColor = true;
            this.btn_Thread1Abort.Click += new System.EventHandler(this.btn_Thread1Abort_Click);
            // 
            // btn_pause2
            // 
            this.btn_pause2.Location = new System.Drawing.Point(94, 80);
            this.btn_pause2.Name = "btn_pause2";
            this.btn_pause2.Size = new System.Drawing.Size(75, 23);
            this.btn_pause2.TabIndex = 14;
            this.btn_pause2.Text = "Pause2";
            this.btn_pause2.UseVisualStyleBackColor = true;
            this.btn_pause2.Click += new System.EventHandler(this.btn_pause2_Click);
            // 
            // btn_Pause1
            // 
            this.btn_Pause1.Location = new System.Drawing.Point(9, 79);
            this.btn_Pause1.Name = "btn_Pause1";
            this.btn_Pause1.Size = new System.Drawing.Size(75, 23);
            this.btn_Pause1.TabIndex = 15;
            this.btn_Pause1.Text = "Pause1";
            this.btn_Pause1.UseVisualStyleBackColor = true;
            this.btn_Pause1.Click += new System.EventHandler(this.btn_Pause1_Click);
            // 
            // btn_Resume1
            // 
            this.btn_Resume1.Location = new System.Drawing.Point(9, 108);
            this.btn_Resume1.Name = "btn_Resume1";
            this.btn_Resume1.Size = new System.Drawing.Size(75, 23);
            this.btn_Resume1.TabIndex = 16;
            this.btn_Resume1.Text = "Resume1";
            this.btn_Resume1.UseVisualStyleBackColor = true;
            this.btn_Resume1.Click += new System.EventHandler(this.btn_Resume1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(93, 108);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Resume2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_restart
            // 
            this.btn_restart.Location = new System.Drawing.Point(91, 11);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(80, 23);
            this.btn_restart.TabIndex = 18;
            this.btn_restart.Text = "Tusk Restart";
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 441);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_Resume1);
            this.Controls.Add(this.btn_Pause1);
            this.Controls.Add(this.btn_pause2);
            this.Controls.Add(this.btn_Thread1Abort);
            this.Controls.Add(this.lbl_EndFibo);
            this.Controls.Add(this.lbl_end);
            this.Controls.Add(this.lbl_Start);
            this.Controls.Add(this.lbl_Fibonachi);
            this.Controls.Add(this.lbl_randomNumbers);
            this.Controls.Add(this.lst_fibonachi);
            this.Controls.Add(this.num_EndFibo);
            this.Controls.Add(this.btn_Thread2Abort);
            this.Controls.Add(this.lst_rnd_Tusk1);
            this.Controls.Add(this.num_rnd_End);
            this.Controls.Add(this.num_rndStart);
            this.Controls.Add(this.btn_Tusk1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.num_rndStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_rnd_End)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_EndFibo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Tusk1;
        private System.Windows.Forms.NumericUpDown num_rndStart;
        private System.Windows.Forms.NumericUpDown num_rnd_End;
        private System.Windows.Forms.ListBox lst_rnd_Tusk1;
        private System.Windows.Forms.ListBox lst_fibonachi;
        private System.Windows.Forms.NumericUpDown num_EndFibo;
        private System.Windows.Forms.Button btn_Thread2Abort;
        private System.Windows.Forms.Label lbl_randomNumbers;
        private System.Windows.Forms.Label lbl_Fibonachi;
        private System.Windows.Forms.Label lbl_Start;
        private System.Windows.Forms.Label lbl_end;
        private System.Windows.Forms.Label lbl_EndFibo;
        private System.Windows.Forms.Button btn_Thread1Abort;
        private System.Windows.Forms.Button btn_pause2;
        private System.Windows.Forms.Button btn_Pause1;
        private System.Windows.Forms.Button btn_Resume1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_restart;
    }
}

