
namespace DZ_WINFORM_CHESS
{
    partial class myElem
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // myElem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "myElem";
            this.Load += new System.EventHandler(this.myElem_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.myElem_Paint);
            this.MouseEnter += new System.EventHandler(this.myElem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.myElem_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
