namespace demo
{
    partial class SearchForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_search_findnext = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rdo_up = new System.Windows.Forms.RadioButton();
            this.rdo_down = new System.Windows.Forms.RadioButton();
            this.btn_search_cancle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "查找内容(N):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 21);
            this.textBox1.TabIndex = 1;
            // 
            // btn_search_findnext
            // 
            this.btn_search_findnext.Location = new System.Drawing.Point(374, 23);
            this.btn_search_findnext.Name = "btn_search_findnext";
            this.btn_search_findnext.Size = new System.Drawing.Size(75, 23);
            this.btn_search_findnext.TabIndex = 2;
            this.btn_search_findnext.Text = "查找下一个(F)";
            this.btn_search_findnext.UseVisualStyleBackColor = true;
            this.btn_search_findnext.Click += new System.EventHandler(this.btn_search_findnext_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 103);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 16);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "区分大小写(C)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // rdo_up
            // 
            this.rdo_up.AutoSize = true;
            this.rdo_up.Checked = true;
            this.rdo_up.Location = new System.Drawing.Point(16, 22);
            this.rdo_up.Name = "rdo_up";
            this.rdo_up.Size = new System.Drawing.Size(65, 16);
            this.rdo_up.TabIndex = 4;
            this.rdo_up.TabStop = true;
            this.rdo_up.Text = "向上(U)";
            this.rdo_up.UseVisualStyleBackColor = true;
            // 
            // rdo_down
            // 
            this.rdo_down.AutoSize = true;
            this.rdo_down.Location = new System.Drawing.Point(87, 22);
            this.rdo_down.Name = "rdo_down";
            this.rdo_down.Size = new System.Drawing.Size(65, 16);
            this.rdo_down.TabIndex = 5;
            this.rdo_down.Text = "向下(D)";
            this.rdo_down.UseVisualStyleBackColor = true;
            // 
            // btn_search_cancle
            // 
            this.btn_search_cancle.Location = new System.Drawing.Point(374, 59);
            this.btn_search_cancle.Name = "btn_search_cancle";
            this.btn_search_cancle.Size = new System.Drawing.Size(75, 23);
            this.btn_search_cancle.TabIndex = 7;
            this.btn_search_cancle.Text = "取消";
            this.btn_search_cancle.UseVisualStyleBackColor = true;
            this.btn_search_cancle.Click += new System.EventHandler(this.btn_search_cancle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_up);
            this.groupBox1.Controls.Add(this.rdo_down);
            this.groupBox1.Location = new System.Drawing.Point(168, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 60);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "方向";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 131);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_search_cancle);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_search_findnext);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.Text = "查找";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_search_findnext;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton rdo_up;
        private System.Windows.Forms.RadioButton rdo_down;
        private System.Windows.Forms.Button btn_search_cancle;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}