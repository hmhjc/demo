namespace demo
{
    partial class Fontsetting
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fontsetting));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtn_bold = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Italic = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Underline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_bold,
            this.tsbtn_Italic,
            this.tsbtn_Underline,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(88, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtn_bold
            // 
            this.tsbtn_bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_bold.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_bold.Image")));
            this.tsbtn_bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_bold.Name = "tsbtn_bold";
            this.tsbtn_bold.Size = new System.Drawing.Size(23, 22);
            this.tsbtn_bold.Text = "toolStripButton1";
            this.tsbtn_bold.Click += new System.EventHandler(this.tsbtn_bold_Click);
            // 
            // tsbtn_Italic
            // 
            this.tsbtn_Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_Italic.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Italic.Image")));
            this.tsbtn_Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Italic.Name = "tsbtn_Italic";
            this.tsbtn_Italic.Size = new System.Drawing.Size(23, 24);
            this.tsbtn_Italic.Text = "toolStripButton2";
            this.tsbtn_Italic.Click += new System.EventHandler(this.tsbtn_Italic_Click);
            // 
            // tsbtn_Underline
            // 
            this.tsbtn_Underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_Underline.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Underline.Image")));
            this.tsbtn_Underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Underline.Name = "tsbtn_Underline";
            this.tsbtn_Underline.Size = new System.Drawing.Size(23, 24);
            this.tsbtn_Underline.Text = "toolStripButton3";
            this.tsbtn_Underline.Click += new System.EventHandler(this.tsbtn_Underline_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // Fontsetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Name = "Fontsetting";
            this.Size = new System.Drawing.Size(88, 25);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtn_bold;
        private System.Windows.Forms.ToolStripButton tsbtn_Italic;
        private System.Windows.Forms.ToolStripButton tsbtn_Underline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}
