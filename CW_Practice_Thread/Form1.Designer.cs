
namespace CW_Practice_Thread
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
            this.btn_Thread = new System.Windows.Forms.Button();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.lbl_workThread = new System.Windows.Forms.Label();
            this.num_Count = new System.Windows.Forms.NumericUpDown();
            this.lst_waitthread = new System.Windows.Forms.ListBox();
            this.lst_CreateThread = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_createThread = new System.Windows.Forms.Label();
            this.lbl_waitThread = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Thread
            // 
            this.btn_Thread.Location = new System.Drawing.Point(176, 348);
            this.btn_Thread.Name = "btn_Thread";
            this.btn_Thread.Size = new System.Drawing.Size(107, 23);
            this.btn_Thread.TabIndex = 0;
            this.btn_Thread.Text = "Создать поток";
            this.btn_Thread.UseVisualStyleBackColor = true;
            this.btn_Thread.Click += new System.EventHandler(this.btn_Thread_Click);
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Location = new System.Drawing.Point(13, 332);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(158, 13);
            this.lbl_Count.TabIndex = 1;
            this.lbl_Count.Text = "Количество мест в семафоре";
            // 
            // lbl_workThread
            // 
            this.lbl_workThread.AutoSize = true;
            this.lbl_workThread.Location = new System.Drawing.Point(13, 41);
            this.lbl_workThread.Name = "lbl_workThread";
            this.lbl_workThread.Size = new System.Drawing.Size(110, 13);
            this.lbl_workThread.TabIndex = 3;
            this.lbl_workThread.Text = "Работающие потоки";
            // 
            // num_Count
            // 
            this.num_Count.Location = new System.Drawing.Point(16, 348);
            this.num_Count.Name = "num_Count";
            this.num_Count.Size = new System.Drawing.Size(120, 20);
            this.num_Count.TabIndex = 4;
            this.num_Count.ValueChanged += new System.EventHandler(this.num_Count_ValueChanged);
            // 
            // lst_waitthread
            // 
            this.lst_waitthread.FormattingEnabled = true;
            this.lst_waitthread.Location = new System.Drawing.Point(279, 59);
            this.lst_waitthread.Name = "lst_waitthread";
            this.lst_waitthread.Size = new System.Drawing.Size(247, 264);
            this.lst_waitthread.TabIndex = 6;
            // 
            // lst_CreateThread
            // 
            this.lst_CreateThread.FormattingEnabled = true;
            this.lst_CreateThread.Location = new System.Drawing.Point(536, 59);
            this.lst_CreateThread.Name = "lst_CreateThread";
            this.lst_CreateThread.Size = new System.Drawing.Size(247, 264);
            this.lst_CreateThread.TabIndex = 7;
            this.lst_CreateThread.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lst_CreateThread_MouseDoubleClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(247, 272);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lbl_createThread
            // 
            this.lbl_createThread.AutoSize = true;
            this.lbl_createThread.Location = new System.Drawing.Point(533, 43);
            this.lbl_createThread.Name = "lbl_createThread";
            this.lbl_createThread.Size = new System.Drawing.Size(102, 13);
            this.lbl_createThread.TabIndex = 10;
            this.lbl_createThread.Text = "Созданные потоки";
            // 
            // lbl_waitThread
            // 
            this.lbl_waitThread.AutoSize = true;
            this.lbl_waitThread.Location = new System.Drawing.Point(276, 43);
            this.lbl_waitThread.Name = "lbl_waitThread";
            this.lbl_waitThread.Size = new System.Drawing.Size(108, 13);
            this.lbl_waitThread.TabIndex = 11;
            this.lbl_waitThread.Text = "Ожидающие потоки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_waitThread);
            this.Controls.Add(this.lbl_createThread);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lst_CreateThread);
            this.Controls.Add(this.lst_waitthread);
            this.Controls.Add(this.num_Count);
            this.Controls.Add(this.lbl_workThread);
            this.Controls.Add(this.lbl_Count);
            this.Controls.Add(this.btn_Thread);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.num_Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Thread;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.Label lbl_workThread;
        private System.Windows.Forms.NumericUpDown num_Count;
        private System.Windows.Forms.ListBox lst_waitthread;
        private System.Windows.Forms.ListBox lst_CreateThread;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_createThread;
        private System.Windows.Forms.Label lbl_waitThread;
    }
}

