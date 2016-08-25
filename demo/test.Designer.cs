namespace demo
{
    partial class test
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
            this.fontsetting1 = new ClassLibrary1.Fontsetting();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // fontsetting1
            // 
            this.fontsetting1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fontsetting1.Location = new System.Drawing.Point(0, 0);
            this.fontsetting1.Name = "fontsetting1";
            this.fontsetting1.Rtb = null;
            this.fontsetting1.Size = new System.Drawing.Size(689, 25);
            this.fontsetting1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(689, 399);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 424);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.fontsetting1);
            this.Name = "test";
            this.Text = "test";
            this.Load += new System.EventHandler(this.test_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ClassLibrary1.Fontsetting fontsetting1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}