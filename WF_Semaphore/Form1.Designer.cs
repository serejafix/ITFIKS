
namespace WF_Semaphore
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
            this.lst_CreateThread = new System.Windows.Forms.ListBox();
            this.lst_waitingThread = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.num_count = new System.Windows.Forms.NumericUpDown();
            this.lbl_createthread = new System.Windows.Forms.Label();
            this.lbl_waitingThread = new System.Windows.Forms.Label();
            this.lbl_workedThread = new System.Windows.Forms.Label();
            this.lbl_countPlace = new System.Windows.Forms.Label();
            this.btn_creatThread = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_count)).BeginInit();
            this.SuspendLayout();
            // 
            // lst_CreateThread
            // 
            this.lst_CreateThread.FormattingEnabled = true;
            this.lst_CreateThread.Location = new System.Drawing.Point(535, 27);
            this.lst_CreateThread.Name = "lst_CreateThread";
            this.lst_CreateThread.Size = new System.Drawing.Size(253, 251);
            this.lst_CreateThread.TabIndex = 0;
            // 
            // lst_waitingThread
            // 
            this.lst_waitingThread.FormattingEnabled = true;
            this.lst_waitingThread.Location = new System.Drawing.Point(270, 27);
            this.lst_waitingThread.Name = "lst_waitingThread";
            this.lst_waitingThread.Size = new System.Drawing.Size(253, 251);
            this.lst_waitingThread.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(252, 251);
            this.dataGridView1.TabIndex = 2;
            // 
            // num_count
            // 
            this.num_count.Location = new System.Drawing.Point(28, 321);
            this.num_count.Name = "num_count";
            this.num_count.Size = new System.Drawing.Size(179, 20);
            this.num_count.TabIndex = 3;
            // 
            // lbl_createthread
            // 
            this.lbl_createthread.AutoSize = true;
            this.lbl_createthread.Location = new System.Drawing.Point(532, 9);
            this.lbl_createthread.Name = "lbl_createthread";
            this.lbl_createthread.Size = new System.Drawing.Size(102, 13);
            this.lbl_createthread.TabIndex = 4;
            this.lbl_createthread.Text = "Созданные потоки";
            // 
            // lbl_waitingThread
            // 
            this.lbl_waitingThread.AutoSize = true;
            this.lbl_waitingThread.Location = new System.Drawing.Point(267, 11);
            this.lbl_waitingThread.Name = "lbl_waitingThread";
            this.lbl_waitingThread.Size = new System.Drawing.Size(108, 13);
            this.lbl_waitingThread.TabIndex = 5;
            this.lbl_waitingThread.Text = "Ожидающие потоки";
            // 
            // lbl_workedThread
            // 
            this.lbl_workedThread.AutoSize = true;
            this.lbl_workedThread.Location = new System.Drawing.Point(12, 11);
            this.lbl_workedThread.Name = "lbl_workedThread";
            this.lbl_workedThread.Size = new System.Drawing.Size(110, 13);
            this.lbl_workedThread.TabIndex = 6;
            this.lbl_workedThread.Text = "Работающие потоки";
            // 
            // lbl_countPlace
            // 
            this.lbl_countPlace.AutoSize = true;
            this.lbl_countPlace.Location = new System.Drawing.Point(28, 305);
            this.lbl_countPlace.Name = "lbl_countPlace";
            this.lbl_countPlace.Size = new System.Drawing.Size(94, 13);
            this.lbl_countPlace.TabIndex = 7;
            this.lbl_countPlace.Text = "Количество мест";
            // 
            // btn_creatThread
            // 
            this.btn_creatThread.Location = new System.Drawing.Point(269, 321);
            this.btn_creatThread.Name = "btn_creatThread";
            this.btn_creatThread.Size = new System.Drawing.Size(106, 23);
            this.btn_creatThread.TabIndex = 8;
            this.btn_creatThread.Text = "Создать поток";
            this.btn_creatThread.UseVisualStyleBackColor = true;
            this.btn_creatThread.Click += new System.EventHandler(this.btn_creatThread_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_creatThread);
            this.Controls.Add(this.lbl_countPlace);
            this.Controls.Add(this.lbl_workedThread);
            this.Controls.Add(this.lbl_waitingThread);
            this.Controls.Add(this.lbl_createthread);
            this.Controls.Add(this.num_count);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lst_waitingThread);
            this.Controls.Add(this.lst_CreateThread);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_CreateThread;
        private System.Windows.Forms.ListBox lst_waitingThread;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown num_count;
        private System.Windows.Forms.Label lbl_createthread;
        private System.Windows.Forms.Label lbl_waitingThread;
        private System.Windows.Forms.Label lbl_workedThread;
        private System.Windows.Forms.Label lbl_countPlace;
        private System.Windows.Forms.Button btn_creatThread;
    }
}

