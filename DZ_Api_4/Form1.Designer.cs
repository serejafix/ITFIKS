
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Tusk5OpenPath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txb_wordsForeSearch = new System.Windows.Forms.TextBox();
            this.lbl_showPath = new System.Windows.Forms.Label();
            this.btn_Tusk5Start = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.countBars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_EndFib)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.btn_startHorse.Location = new System.Drawing.Point(6, 19);
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
            this.listBox1.Location = new System.Drawing.Point(87, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(89, 82);
            this.listBox1.TabIndex = 4;
            // 
            // btn_startFib
            // 
            this.btn_startFib.Location = new System.Drawing.Point(4, 25);
            this.btn_startFib.Name = "btn_startFib";
            this.btn_startFib.Size = new System.Drawing.Size(92, 23);
            this.btn_startFib.TabIndex = 5;
            this.btn_startFib.Text = "StartFibonachi";
            this.btn_startFib.UseVisualStyleBackColor = true;
            this.btn_startFib.Click += new System.EventHandler(this.btn_startFib_Click);
            // 
            // num_EndFib
            // 
            this.num_EndFib.Location = new System.Drawing.Point(5, 52);
            this.num_EndFib.Name = "num_EndFib";
            this.num_EndFib.Size = new System.Drawing.Size(91, 20);
            this.num_EndFib.TabIndex = 6;
            // 
            // lst_Fibo
            // 
            this.lst_Fibo.FormattingEnabled = true;
            this.lst_Fibo.Location = new System.Drawing.Point(7, 78);
            this.lst_Fibo.Name = "lst_Fibo";
            this.lst_Fibo.Size = new System.Drawing.Size(89, 186);
            this.lst_Fibo.TabIndex = 7;
            // 
            // btn_OpenFIle
            // 
            this.btn_OpenFIle.Location = new System.Drawing.Point(6, 19);
            this.btn_OpenFIle.Name = "btn_OpenFIle";
            this.btn_OpenFIle.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenFIle.TabIndex = 8;
            this.btn_OpenFIle.Text = "OpenFile";
            this.btn_OpenFIle.UseVisualStyleBackColor = true;
            this.btn_OpenFIle.Click += new System.EventHandler(this.btn_OpenFIle_Click);
            // 
            // btn_startCounterWords
            // 
            this.btn_startCounterWords.Location = new System.Drawing.Point(87, 19);
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
            this.lbl_CountWords.Location = new System.Drawing.Point(6, 49);
            this.lbl_CountWords.Name = "lbl_CountWords";
            this.lbl_CountWords.Size = new System.Drawing.Size(0, 13);
            this.lbl_CountWords.TabIndex = 10;
            // 
            // txb_Word
            // 
            this.txb_Word.Location = new System.Drawing.Point(9, 71);
            this.txb_Word.Name = "txb_Word";
            this.txb_Word.Size = new System.Drawing.Size(100, 20);
            this.txb_Word.TabIndex = 11;
            this.txb_Word.TextChanged += new System.EventHandler(this.txb_Word_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.CausesValidation = false;
            this.groupBox1.Controls.Add(this.btn_OpenFIle);
            this.groupBox1.Controls.Add(this.txb_Word);
            this.groupBox1.Controls.Add(this.btn_startCounterWords);
            this.groupBox1.Controls.Add(this.lbl_CountWords);
            this.groupBox1.Location = new System.Drawing.Point(407, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Задание 4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_startHorse);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(107, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 101);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Задание 2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lst_Fibo);
            this.groupBox3.Controls.Add(this.btn_startFib);
            this.groupBox3.Controls.Add(this.num_EndFib);
            this.groupBox3.Location = new System.Drawing.Point(294, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(107, 276);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Задание 3";
            // 
            // btn_Tusk5OpenPath
            // 
            this.btn_Tusk5OpenPath.Location = new System.Drawing.Point(407, 119);
            this.btn_Tusk5OpenPath.Name = "btn_Tusk5OpenPath";
            this.btn_Tusk5OpenPath.Size = new System.Drawing.Size(75, 23);
            this.btn_Tusk5OpenPath.TabIndex = 12;
            this.btn_Tusk5OpenPath.Text = "Open Path";
            this.btn_Tusk5OpenPath.UseVisualStyleBackColor = true;
            this.btn_Tusk5OpenPath.Click += new System.EventHandler(this.btn_Tusk5_Click);
            // 
            // txb_wordsForeSearch
            // 
            this.txb_wordsForeSearch.Location = new System.Drawing.Point(407, 173);
            this.txb_wordsForeSearch.Name = "txb_wordsForeSearch";
            this.txb_wordsForeSearch.Size = new System.Drawing.Size(100, 20);
            this.txb_wordsForeSearch.TabIndex = 15;
            this.txb_wordsForeSearch.TextChanged += new System.EventHandler(this.txb_wordsForeSearch_TextChanged);
            // 
            // lbl_showPath
            // 
            this.lbl_showPath.AutoSize = true;
            this.lbl_showPath.Location = new System.Drawing.Point(413, 145);
            this.lbl_showPath.Name = "lbl_showPath";
            this.lbl_showPath.Size = new System.Drawing.Size(0, 13);
            this.lbl_showPath.TabIndex = 16;
            // 
            // btn_Tusk5Start
            // 
            this.btn_Tusk5Start.Location = new System.Drawing.Point(494, 119);
            this.btn_Tusk5Start.Name = "btn_Tusk5Start";
            this.btn_Tusk5Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Tusk5Start.TabIndex = 17;
            this.btn_Tusk5Start.Text = "Start";
            this.btn_Tusk5Start.UseVisualStyleBackColor = true;
            this.btn_Tusk5Start.Click += new System.EventHandler(this.btn_Tusk5Start_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(407, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(269, 88);
            this.dataGridView1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Tusk5Start);
            this.Controls.Add(this.lbl_showPath);
            this.Controls.Add(this.txb_wordsForeSearch);
            this.Controls.Add(this.btn_Tusk5OpenPath);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_Count);
            this.Controls.Add(this.countBars);
            this.Controls.Add(this.btn_Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countBars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_EndFib)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Tusk5OpenPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txb_wordsForeSearch;
        private System.Windows.Forms.Label lbl_showPath;
        private System.Windows.Forms.Button btn_Tusk5Start;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

