
namespace Ekz_System_2
{
    partial class AllReports
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
            this.listBox_StartProg = new System.Windows.Forms.ListBox();
            this.listBox_Keys = new System.Windows.Forms.ListBox();
            this.listBoxBanWords = new System.Windows.Forms.ListBox();
            this.listBox_BanPrograms = new System.Windows.Forms.ListBox();
            this.lbl_BanWords = new System.Windows.Forms.Label();
            this.lbl_BanProgram = new System.Windows.Forms.Label();
            this.gb_Stat = new System.Windows.Forms.GroupBox();
            this.lbl_Keys = new System.Windows.Forms.Label();
            this.lbl_StartProg = new System.Windows.Forms.Label();
            this.gb_Stat.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_StartProg
            // 
            this.listBox_StartProg.FormattingEnabled = true;
            this.listBox_StartProg.Location = new System.Drawing.Point(6, 35);
            this.listBox_StartProg.Name = "listBox_StartProg";
            this.listBox_StartProg.Size = new System.Drawing.Size(411, 95);
            this.listBox_StartProg.TabIndex = 0;
            // 
            // listBox_Keys
            // 
            this.listBox_Keys.FormattingEnabled = true;
            this.listBox_Keys.Location = new System.Drawing.Point(6, 147);
            this.listBox_Keys.Name = "listBox_Keys";
            this.listBox_Keys.Size = new System.Drawing.Size(411, 95);
            this.listBox_Keys.TabIndex = 1;
            // 
            // listBoxBanWords
            // 
            this.listBoxBanWords.FormattingEnabled = true;
            this.listBoxBanWords.Location = new System.Drawing.Point(7, 260);
            this.listBoxBanWords.Name = "listBoxBanWords";
            this.listBoxBanWords.Size = new System.Drawing.Size(413, 95);
            this.listBoxBanWords.TabIndex = 2;
            // 
            // listBox_BanPrograms
            // 
            this.listBox_BanPrograms.FormattingEnabled = true;
            this.listBox_BanPrograms.Location = new System.Drawing.Point(7, 372);
            this.listBox_BanPrograms.Name = "listBox_BanPrograms";
            this.listBox_BanPrograms.Size = new System.Drawing.Size(413, 95);
            this.listBox_BanPrograms.TabIndex = 3;
            // 
            // lbl_BanWords
            // 
            this.lbl_BanWords.AutoSize = true;
            this.lbl_BanWords.Location = new System.Drawing.Point(7, 245);
            this.lbl_BanWords.Name = "lbl_BanWords";
            this.lbl_BanWords.Size = new System.Drawing.Size(57, 13);
            this.lbl_BanWords.TabIndex = 4;
            this.lbl_BanWords.Text = "BanWords";
            // 
            // lbl_BanProgram
            // 
            this.lbl_BanProgram.AutoSize = true;
            this.lbl_BanProgram.Location = new System.Drawing.Point(8, 356);
            this.lbl_BanProgram.Name = "lbl_BanProgram";
            this.lbl_BanProgram.Size = new System.Drawing.Size(70, 13);
            this.lbl_BanProgram.TabIndex = 5;
            this.lbl_BanProgram.Text = "BanPrograms";
            // 
            // gb_Stat
            // 
            this.gb_Stat.Controls.Add(this.lbl_Keys);
            this.gb_Stat.Controls.Add(this.lbl_StartProg);
            this.gb_Stat.Controls.Add(this.listBox_StartProg);
            this.gb_Stat.Controls.Add(this.listBox_BanPrograms);
            this.gb_Stat.Controls.Add(this.lbl_BanProgram);
            this.gb_Stat.Controls.Add(this.listBox_Keys);
            this.gb_Stat.Controls.Add(this.lbl_BanWords);
            this.gb_Stat.Controls.Add(this.listBoxBanWords);
            this.gb_Stat.Location = new System.Drawing.Point(12, 12);
            this.gb_Stat.Name = "gb_Stat";
            this.gb_Stat.Size = new System.Drawing.Size(436, 474);
            this.gb_Stat.TabIndex = 6;
            this.gb_Stat.TabStop = false;
            this.gb_Stat.Text = "Statistics";
            // 
            // lbl_Keys
            // 
            this.lbl_Keys.AutoSize = true;
            this.lbl_Keys.Location = new System.Drawing.Point(8, 133);
            this.lbl_Keys.Name = "lbl_Keys";
            this.lbl_Keys.Size = new System.Drawing.Size(30, 13);
            this.lbl_Keys.TabIndex = 7;
            this.lbl_Keys.Text = "Keys";
            // 
            // lbl_StartProg
            // 
            this.lbl_StartProg.AutoSize = true;
            this.lbl_StartProg.Location = new System.Drawing.Point(9, 20);
            this.lbl_StartProg.Name = "lbl_StartProg";
            this.lbl_StartProg.Size = new System.Drawing.Size(73, 13);
            this.lbl_StartProg.TabIndex = 6;
            this.lbl_StartProg.Text = "StartPrograms";
            // 
            // AllReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(459, 492);
            this.Controls.Add(this.gb_Stat);
            this.Name = "AllReports";
            this.Text = "AllReports";
            this.gb_Stat.ResumeLayout(false);
            this.gb_Stat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_StartProg;
        private System.Windows.Forms.ListBox listBox_Keys;
        private System.Windows.Forms.ListBox listBoxBanWords;
        private System.Windows.Forms.ListBox listBox_BanPrograms;
        private System.Windows.Forms.Label lbl_BanWords;
        private System.Windows.Forms.Label lbl_BanProgram;
        private System.Windows.Forms.GroupBox gb_Stat;
        private System.Windows.Forms.Label lbl_Keys;
        private System.Windows.Forms.Label lbl_StartProg;
    }
}