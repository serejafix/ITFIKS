
namespace EKZ_System_1
{
    partial class FormCompleted
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lbl_pathToFolder = new System.Windows.Forms.Label();
            this.ReportCountWords = new System.Windows.Forms.Label();
            this.reports = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(365, 251);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(423, 38);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(365, 251);
            this.listBox2.TabIndex = 1;
            // 
            // lbl_pathToFolder
            // 
            this.lbl_pathToFolder.AutoSize = true;
            this.lbl_pathToFolder.Location = new System.Drawing.Point(13, 309);
            this.lbl_pathToFolder.Name = "lbl_pathToFolder";
            this.lbl_pathToFolder.Size = new System.Drawing.Size(166, 13);
            this.lbl_pathToFolder.TabIndex = 2;
            this.lbl_pathToFolder.Text = "Folder with Files C:\\EkzTempFiles";
            this.toolTip1.SetToolTip(this.lbl_pathToFolder, "Double Click Open Folder");
            this.lbl_pathToFolder.DoubleClick += new System.EventHandler(this.lbl_pathToFolder_DoubleClick);
            // 
            // ReportCountWords
            // 
            this.ReportCountWords.AutoSize = true;
            this.ReportCountWords.Location = new System.Drawing.Point(13, 13);
            this.ReportCountWords.Name = "ReportCountWords";
            this.ReportCountWords.Size = new System.Drawing.Size(98, 13);
            this.ReportCountWords.TabIndex = 3;
            this.ReportCountWords.Text = "ReportCountWords";
            // 
            // reports
            // 
            this.reports.AutoSize = true;
            this.reports.Location = new System.Drawing.Point(431, 13);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(44, 13);
            this.reports.TabIndex = 4;
            this.reports.Text = "Reports";
            // 
            // FormCompleted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(795, 330);
            this.Controls.Add(this.reports);
            this.Controls.Add(this.ReportCountWords);
            this.Controls.Add(this.lbl_pathToFolder);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "FormCompleted";
            this.Text = "FormCompleted";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lbl_pathToFolder;
        private System.Windows.Forms.Label ReportCountWords;
        private System.Windows.Forms.Label reports;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}