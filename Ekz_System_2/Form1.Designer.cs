
namespace Ekz_System_2
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
            this.checkBox_statistics = new System.Windows.Forms.CheckBox();
            this.checkBox_Moderirovanie = new System.Windows.Forms.CheckBox();
            this.listBox_ListAllProgram = new System.Windows.Forms.ListBox();
            this.listBox_BannedProgram = new System.Windows.Forms.ListBox();
            this.label_ListInstalProgram = new System.Windows.Forms.Label();
            this.label_ListBannedProgram = new System.Windows.Forms.Label();
            this.button_PathReport = new System.Windows.Forms.Button();
            this.groupBox_Stat = new System.Windows.Forms.GroupBox();
            this.groupBox_moderirovanie = new System.Windows.Forms.GroupBox();
            this.label_BanWords = new System.Windows.Forms.Label();
            this.richTextBox_BanWords = new System.Windows.Forms.RichTextBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.groupBox_Stat.SuspendLayout();
            this.groupBox_moderirovanie.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_statistics
            // 
            this.checkBox_statistics.AutoSize = true;
            this.checkBox_statistics.Location = new System.Drawing.Point(8, 18);
            this.checkBox_statistics.Name = "checkBox_statistics";
            this.checkBox_statistics.Size = new System.Drawing.Size(142, 17);
            this.checkBox_statistics.TabIndex = 0;
            this.checkBox_statistics.Text = "Статистика (вкл\\выкл)";
            this.checkBox_statistics.UseVisualStyleBackColor = true;
            this.checkBox_statistics.CheckedChanged += new System.EventHandler(this.checkBox_statistics_CheckedChanged);
            // 
            // checkBox_Moderirovanie
            // 
            this.checkBox_Moderirovanie.AutoSize = true;
            this.checkBox_Moderirovanie.Location = new System.Drawing.Point(86, 28);
            this.checkBox_Moderirovanie.Name = "checkBox_Moderirovanie";
            this.checkBox_Moderirovanie.Size = new System.Drawing.Size(107, 17);
            this.checkBox_Moderirovanie.TabIndex = 1;
            this.checkBox_Moderirovanie.Text = "Модерирование";
            this.checkBox_Moderirovanie.UseVisualStyleBackColor = true;
            this.checkBox_Moderirovanie.CheckedChanged += new System.EventHandler(this.checkBox_Moderirovanie_CheckedChanged);
            // 
            // listBox_ListAllProgram
            // 
            this.listBox_ListAllProgram.FormattingEnabled = true;
            this.listBox_ListAllProgram.Location = new System.Drawing.Point(6, 64);
            this.listBox_ListAllProgram.Name = "listBox_ListAllProgram";
            this.listBox_ListAllProgram.Size = new System.Drawing.Size(187, 95);
            this.listBox_ListAllProgram.TabIndex = 2;
            this.listBox_ListAllProgram.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_ListAllProgram_MouseDoubleClick);
            // 
            // listBox_BannedProgram
            // 
            this.listBox_BannedProgram.FormattingEnabled = true;
            this.listBox_BannedProgram.Location = new System.Drawing.Point(6, 182);
            this.listBox_BannedProgram.Name = "listBox_BannedProgram";
            this.listBox_BannedProgram.Size = new System.Drawing.Size(187, 95);
            this.listBox_BannedProgram.TabIndex = 3;
            // 
            // label_ListInstalProgram
            // 
            this.label_ListInstalProgram.AutoSize = true;
            this.label_ListInstalProgram.Location = new System.Drawing.Point(5, 48);
            this.label_ListInstalProgram.Name = "label_ListInstalProgram";
            this.label_ListInstalProgram.Size = new System.Drawing.Size(179, 13);
            this.label_ListInstalProgram.TabIndex = 4;
            this.label_ListInstalProgram.Text = "Список программ на компьютере";
            // 
            // label_ListBannedProgram
            // 
            this.label_ListBannedProgram.AutoSize = true;
            this.label_ListBannedProgram.Location = new System.Drawing.Point(3, 165);
            this.label_ListBannedProgram.Name = "label_ListBannedProgram";
            this.label_ListBannedProgram.Size = new System.Drawing.Size(171, 13);
            this.label_ListBannedProgram.TabIndex = 5;
            this.label_ListBannedProgram.Text = "Список запрещенных программ";
            // 
            // button_PathReport
            // 
            this.button_PathReport.Location = new System.Drawing.Point(12, 68);
            this.button_PathReport.Name = "button_PathReport";
            this.button_PathReport.Size = new System.Drawing.Size(200, 23);
            this.button_PathReport.TabIndex = 6;
            this.button_PathReport.Text = "Выберите путь отчета";
            this.button_PathReport.UseVisualStyleBackColor = true;
            this.button_PathReport.Click += new System.EventHandler(this.button_PathReport_Click);
            // 
            // groupBox_Stat
            // 
            this.groupBox_Stat.Controls.Add(this.checkBox_statistics);
            this.groupBox_Stat.Location = new System.Drawing.Point(12, 17);
            this.groupBox_Stat.Name = "groupBox_Stat";
            this.groupBox_Stat.Size = new System.Drawing.Size(156, 45);
            this.groupBox_Stat.TabIndex = 9;
            this.groupBox_Stat.TabStop = false;
            this.groupBox_Stat.Text = "Статистика";
            // 
            // groupBox_moderirovanie
            // 
            this.groupBox_moderirovanie.Controls.Add(this.label_BanWords);
            this.groupBox_moderirovanie.Controls.Add(this.richTextBox_BanWords);
            this.groupBox_moderirovanie.Controls.Add(this.listBox_ListAllProgram);
            this.groupBox_moderirovanie.Controls.Add(this.checkBox_Moderirovanie);
            this.groupBox_moderirovanie.Controls.Add(this.label_ListBannedProgram);
            this.groupBox_moderirovanie.Controls.Add(this.listBox_BannedProgram);
            this.groupBox_moderirovanie.Controls.Add(this.label_ListInstalProgram);
            this.groupBox_moderirovanie.Location = new System.Drawing.Point(12, 104);
            this.groupBox_moderirovanie.Name = "groupBox_moderirovanie";
            this.groupBox_moderirovanie.Size = new System.Drawing.Size(200, 334);
            this.groupBox_moderirovanie.TabIndex = 10;
            this.groupBox_moderirovanie.TabStop = false;
            this.groupBox_moderirovanie.Text = "Модерирование";
            // 
            // label_BanWords
            // 
            this.label_BanWords.AutoSize = true;
            this.label_BanWords.Location = new System.Drawing.Point(6, 281);
            this.label_BanWords.Name = "label_BanWords";
            this.label_BanWords.Size = new System.Drawing.Size(144, 13);
            this.label_BanWords.TabIndex = 7;
            this.label_BanWords.Text = "Список запрещенных слов";
            // 
            // richTextBox_BanWords
            // 
            this.richTextBox_BanWords.Location = new System.Drawing.Point(6, 299);
            this.richTextBox_BanWords.Name = "richTextBox_BanWords";
            this.richTextBox_BanWords.Size = new System.Drawing.Size(185, 30);
            this.richTextBox_BanWords.TabIndex = 6;
            this.richTextBox_BanWords.Text = "";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(174, 17);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(38, 45);
            this.btn_Start.TabIndex = 11;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(218, 439);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.button_PathReport);
            this.Controls.Add(this.groupBox_moderirovanie);
            this.Controls.Add(this.groupBox_Stat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.groupBox_Stat.ResumeLayout(false);
            this.groupBox_Stat.PerformLayout();
            this.groupBox_moderirovanie.ResumeLayout(false);
            this.groupBox_moderirovanie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_statistics;
        private System.Windows.Forms.CheckBox checkBox_Moderirovanie;
        private System.Windows.Forms.ListBox listBox_ListAllProgram;
        private System.Windows.Forms.ListBox listBox_BannedProgram;
        private System.Windows.Forms.Label label_ListInstalProgram;
        private System.Windows.Forms.Label label_ListBannedProgram;
        private System.Windows.Forms.Button button_PathReport;
        private System.Windows.Forms.GroupBox groupBox_Stat;
        private System.Windows.Forms.GroupBox groupBox_moderirovanie;
        private System.Windows.Forms.RichTextBox richTextBox_BanWords;
        private System.Windows.Forms.Label label_BanWords;
        private System.Windows.Forms.Button btn_Start;
    }
}

