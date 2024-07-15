namespace GovDataAnalysis
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(775, 425);
            this.textBox1.TabIndex = 0;
            // 
            // listBoxMonths
            // 
            listBoxMonths.FormattingEnabled = true;
            listBoxMonths.ItemHeight = 15;
            listBoxMonths.Location = new Point(33, 57);
            listBoxMonths.Name = "listBoxMonths";
            listBoxMonths.Size = new Size(120, 94);
            listBoxMonths.TabIndex = 1;
            // 
            // listBoxYears
            // 
            listBoxYears.FormattingEnabled = true;
            listBoxYears.ItemHeight = 15;
            listBoxYears.Location = new Point(213, 76);
            listBoxYears.Name = "listBoxYears";
            listBoxYears.Size = new Size(120, 94);
            listBoxYears.TabIndex = 2;
            // 
            // listBoxIndicators
            // 
            listBoxIndicators.FormattingEnabled = true;
            listBoxIndicators.ItemHeight = 15;
            listBoxIndicators.Location = new Point(45, 202);
            listBoxIndicators.Name = "listBoxIndicators";
            listBoxIndicators.Size = new Size(120, 94);
            listBoxIndicators.TabIndex = 3;
            // 
            // listBoxSectors
            // 
            listBoxSectors.FormattingEnabled = true;
            listBoxSectors.ItemHeight = 15;
            listBoxSectors.Location = new Point(238, 242);
            listBoxSectors.Name = "listBoxSectors";
            listBoxSectors.Size = new Size(120, 94);
            listBoxSectors.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private TextBox textBox1;
    }
}
