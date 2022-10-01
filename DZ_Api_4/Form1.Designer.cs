
namespace DZ_Api_4
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
            this.btn_Start = new System.Windows.Forms.Button();
            this.countBars = new System.Windows.Forms.TrackBar();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.btn_startHorse = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_startFib = new System.Windows.Forms.Button();
            this.num_EndFib = new System.Windows.Forms.NumericUpDown();
            this.lst_Fibo = new System.Windows.Forms.ListBox();
            this.btn_OpenFIle = new System.Windows.Forms.Button();
            this.btn_startCounterWords = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbl_CountWords = new System.Windows.Forms.Label();
            this.txb_Word = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.countBars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_EndFib)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(13, 13);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // countBars
            // 
            this.countBars.Location = new System.Drawing.Point(3, 55);
            this.countBars.Name = "countBars";
            this.countBars.Size = new System.Drawing.Size(104, 45);
            this.countBars.TabIndex = 1;
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Location = new System.Drawing.Point(4, 39);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(103, 13);
            this.lbl_Count.TabIndex = 2;
            this.lbl_Count.Text = "Count Progress Bars";
            // 
            // btn_startHorse
            // 
            this.btn_startHorse.Location = new System.Drawing.Point(113, 13);
            this.btn_startHorse.Name = "btn_startHorse";
            this.btn_startHorse.Size = new System.Drawing.Size(75, 23);
            this.btn_startHorse.TabIndex = 3;
            this.btn_startHorse.Text = "StartHorse";
            this.btn_startHorse.UseVisualStyleBackColor = true;
            this.btn_startHorse.Click += new System.EventHandler(this.btn_startHorse_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(194, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(89, 82);
            this.listBox1.TabIndex = 4;
            // 
            // btn_startFib
            // 
            this.btn_startFib.Location = new System.Drawing.Point(289, 12);
            this.btn_startFib.Name = "btn_startFib";
            this.btn_startFib.Size = new System.Drawing.Size(92, 23);
            this.btn_startFib.TabIndex = 5;
            this.btn_startFib.Text = "StartFibonachi";
            this.btn_startFib.UseVisualStyleBackColor = true;
            this.btn_startFib.Click += new System.EventHandler(this.btn_startFib_Click);
            // 
            // num_EndFib
            // 
            this.num_EndFib.Location = new System.Drawing.Point(290, 39);
            this.num_EndFib.Name = "num_EndFib";
            this.num_EndFib.Size = new System.Drawing.Size(91, 20);
            this.num_EndFib.TabIndex = 6;
            // 
            // lst_Fibo
            // 
            this.lst_Fibo.FormattingEnabled = true;
            this.lst_Fibo.Location = new System.Drawing.Point(292, 65);
            this.lst_Fibo.Name = "lst_Fibo";
            this.lst_Fibo.Size = new System.Drawing.Size(89, 186);
            this.lst_Fibo.TabIndex = 7;
            // 
            // btn_OpenFIle
            // 
            this.btn_OpenFIle.Location = new System.Drawing.Point(416, 13);
            this.btn_OpenFIle.Name = "btn_OpenFIle";
            this.btn_OpenFIle.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenFIle.TabIndex = 8;
            this.btn_OpenFIle.Text = "OpenFile";
            this.btn_OpenFIle.UseVisualStyleBackColor = true;
            this.btn_OpenFIle.Click += new System.EventHandler(this.btn_OpenFIle_Click);
            // 
            // btn_startCounterWords
            // 
            this.btn_startCounterWords.Location = new System.Drawing.Point(497, 13);
            this.btn_startCounterWords.Name = "btn_startCounterWords";
            this.btn_startCounterWords.Size = new System.Drawing.Size(75, 23);
            this.btn_startCounterWords.TabIndex = 9;
            this.btn_startCounterWords.Text = "Start";
            this.btn_startCounterWords.UseVisualStyleBackColor = true;
            this.btn_startCounterWords.Click += new System.EventHandler(this.btn_startCounterWords_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbl_CountWords
            // 
            this.lbl_CountWords.AutoSize = true;
            this.lbl_CountWords.Location = new System.Drawing.Point(416, 43);
            this.lbl_CountWords.Name = "lbl_CountWords";
            this.lbl_CountWords.Size = new System.Drawing.Size(0, 13);
            this.lbl_CountWords.TabIndex = 10;
            // 
            // txb_Word
            // 
            this.txb_Word.Location = new System.Drawing.Point(419, 65);
            this.txb_Word.Name = "txb_Word";
            this.txb_Word.Size = new System.Drawing.Size(100, 20);
            this.txb_Word.TabIndex = 11;
            this.txb_Word.TextChanged += new System.EventHandler(this.txb_Word_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txb_Word);
            this.Controls.Add(this.lbl_CountWords);
            this.Controls.Add(this.btn_startCounterWords);
            this.Controls.Add(this.btn_OpenFIle);
            this.Controls.Add(this.lst_Fibo);
            this.Controls.Add(this.num_EndFib);
            this.Controls.Add(this.btn_startFib);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_startHorse);
            this.Controls.Add(this.lbl_Count);
            this.Controls.Add(this.countBars);
            this.Controls.Add(this.btn_Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countBars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_EndFib)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.TrackBar countBars;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.Button btn_startHorse;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_startFib;
        private System.Windows.Forms.NumericUpDown num_EndFib;
        private System.Windows.Forms.ListBox lst_Fibo;
        private System.Windows.Forms.Button btn_OpenFIle;
        private System.Windows.Forms.Button btn_startCounterWords;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbl_CountWords;
        private System.Windows.Forms.TextBox txb_Word;
    }
}

