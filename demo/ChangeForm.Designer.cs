namespace demo
{
    partial class ChangeForm
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
            this.btn_change_find = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_change_change = new System.Windows.Forms.Button();
            this.btn_change_cancel = new System.Windows.Forms.Button();
            this.btn_change_changeall = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_change_find
            // 
            this.btn_change_find.Location = new System.Drawing.Point(373, 27);
            this.btn_change_find.Name = "btn_change_find";
            this.btn_change_find.Size = new System.Drawing.Size(100, 23);
            this.btn_change_find.TabIndex = 0;
            this.btn_change_find.Text = "查找下一个(F)";
            this.btn_change_find.UseVisualStyleBackColor = true;
            this.btn_change_find.Click += new System.EventHandler(this.btn_change_find_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "查找内容(N):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(255, 21);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(21, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "替换为(P):";
            // 
            // btn_change_change
            // 
            this.btn_change_change.Location = new System.Drawing.Point(373, 54);
            this.btn_change_change.Name = "btn_change_change";
            this.btn_change_change.Size = new System.Drawing.Size(100, 23);
            this.btn_change_change.TabIndex = 3;
            this.btn_change_change.Text = "替换(R)";
            this.btn_change_change.UseVisualStyleBackColor = true;
            this.btn_change_change.Click += new System.EventHandler(this.btn_change_change_Click);
            // 
            // btn_change_cancel
            // 
            this.btn_change_cancel.Location = new System.Drawing.Point(373, 110);
            this.btn_change_cancel.Name = "btn_change_cancel";
            this.btn_change_cancel.Size = new System.Drawing.Size(100, 23);
            this.btn_change_cancel.TabIndex = 7;
            this.btn_change_cancel.Text = "取消";
            this.btn_change_cancel.UseVisualStyleBackColor = true;
            this.btn_change_cancel.Click += new System.EventHandler(this.btn_change_cancel_Click);
            // 
            // btn_change_changeall
            // 
            this.btn_change_changeall.Location = new System.Drawing.Point(373, 83);
            this.btn_change_changeall.Name = "btn_change_changeall";
            this.btn_change_changeall.Size = new System.Drawing.Size(100, 23);
            this.btn_change_changeall.TabIndex = 6;
            this.btn_change_changeall.Text = "全部替换(A)";
            this.btn_change_changeall.UseVisualStyleBackColor = true;
            this.btn_change_changeall.Click += new System.EventHandler(this.btn_change_changeall_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 114);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 16);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "区分大小写(c)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 155);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_change_cancel);
            this.Controls.Add(this.btn_change_changeall);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_change_change);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_change_find);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeForm";
            this.Text = "替换";
            this.Load += new System.EventHandler(this.ChangeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_change_find;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_change_change;
        private System.Windows.Forms.Button btn_change_cancel;
        private System.Windows.Forms.Button btn_change_changeall;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}