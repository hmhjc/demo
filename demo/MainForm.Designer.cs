namespace demo
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Multiplicationtable = new System.Windows.Forms.Button();
            this.btn_Calculator = new System.Windows.Forms.Button();
            this.btn_Database = new System.Windows.Forms.Button();
            this.btn_Notepad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Multiplicationtable
            // 
            this.btn_Multiplicationtable.Location = new System.Drawing.Point(52, 35);
            this.btn_Multiplicationtable.Name = "btn_Multiplicationtable";
            this.btn_Multiplicationtable.Size = new System.Drawing.Size(75, 23);
            this.btn_Multiplicationtable.TabIndex = 0;
            this.btn_Multiplicationtable.Text = "Multiplicationtable";
            this.btn_Multiplicationtable.UseVisualStyleBackColor = true;
            this.btn_Multiplicationtable.Click += new System.EventHandler(this.btn_Multiplicationtable_Click);
            // 
            // btn_Calculator
            // 
            this.btn_Calculator.Location = new System.Drawing.Point(52, 82);
            this.btn_Calculator.Name = "btn_Calculator";
            this.btn_Calculator.Size = new System.Drawing.Size(75, 23);
            this.btn_Calculator.TabIndex = 1;
            this.btn_Calculator.Text = "Calculator";
            this.btn_Calculator.UseVisualStyleBackColor = true;
            this.btn_Calculator.Click += new System.EventHandler(this.btn_Calculator_Click);
            // 
            // btn_Database
            // 
            this.btn_Database.Location = new System.Drawing.Point(52, 131);
            this.btn_Database.Name = "btn_Database";
            this.btn_Database.Size = new System.Drawing.Size(75, 23);
            this.btn_Database.TabIndex = 2;
            this.btn_Database.Text = "Database";
            this.btn_Database.UseVisualStyleBackColor = true;
            this.btn_Database.Click += new System.EventHandler(this.btn_Database_Click);
            // 
            // btn_Notepad
            // 
            this.btn_Notepad.Location = new System.Drawing.Point(52, 179);
            this.btn_Notepad.Name = "btn_Notepad";
            this.btn_Notepad.Size = new System.Drawing.Size(75, 23);
            this.btn_Notepad.TabIndex = 3;
            this.btn_Notepad.Text = "Notepad";
            this.btn_Notepad.UseVisualStyleBackColor = true;
            this.btn_Notepad.Click += new System.EventHandler(this.btn_Notepad_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 348);
            this.Controls.Add(this.btn_Notepad);
            this.Controls.Add(this.btn_Database);
            this.Controls.Add(this.btn_Calculator);
            this.Controls.Add(this.btn_Multiplicationtable);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Multiplicationtable;
        private System.Windows.Forms.Button btn_Calculator;
        private System.Windows.Forms.Button btn_Database;
        private System.Windows.Forms.Button btn_Notepad;
    }
}

