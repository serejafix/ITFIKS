
namespace GAS_OIL
{
    partial class CHOISE
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
            this.KASSIR = new System.Windows.Forms.Button();
            this.Director = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KASSIR
            // 
            this.KASSIR.Location = new System.Drawing.Point(12, 11);
            this.KASSIR.Name = "KASSIR";
            this.KASSIR.Size = new System.Drawing.Size(127, 62);
            this.KASSIR.TabIndex = 0;
            this.KASSIR.Text = "Кассир";
            this.KASSIR.UseVisualStyleBackColor = true;
            this.KASSIR.Click += new System.EventHandler(this.KASSIR_Click);
            // 
            // Director
            // 
            this.Director.Location = new System.Drawing.Point(148, 12);
            this.Director.Name = "Director";
            this.Director.Size = new System.Drawing.Size(124, 61);
            this.Director.TabIndex = 1;
            this.Director.Text = "ДИРЕКТОР";
            this.Director.UseVisualStyleBackColor = true;
            this.Director.Click += new System.EventHandler(this.Director_Click);
            // 
            // EXIT
            // 
            this.EXIT.Location = new System.Drawing.Point(77, 87);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(127, 62);
            this.EXIT.TabIndex = 2;
            this.EXIT.Text = "Выход";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // CHOISE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.Director);
            this.Controls.Add(this.KASSIR);
            this.Name = "CHOISE";
            this.Text = "CHOISE";
            this.Load += new System.EventHandler(this.CHOISE_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button KASSIR;
        private System.Windows.Forms.Button Director;
        private System.Windows.Forms.Button EXIT;
    }
}