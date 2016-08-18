namespace demo
{
    partial class ToLineForm
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
            this.btn_toline_ok = new System.Windows.Forms.Button();
            this.btn_toline_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "行号(L):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btn_toline_ok
            // 
            this.btn_toline_ok.Location = new System.Drawing.Point(120, 82);
            this.btn_toline_ok.Name = "btn_toline_ok";
            this.btn_toline_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_toline_ok.TabIndex = 2;
            this.btn_toline_ok.Text = "转到";
            this.btn_toline_ok.UseVisualStyleBackColor = true;
            this.btn_toline_ok.Click += new System.EventHandler(this.btn_toline_ok_Click);
            // 
            // btn_toline_cancel
            // 
            this.btn_toline_cancel.Location = new System.Drawing.Point(201, 82);
            this.btn_toline_cancel.Name = "btn_toline_cancel";
            this.btn_toline_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_toline_cancel.TabIndex = 3;
            this.btn_toline_cancel.Text = "取消";
            this.btn_toline_cancel.UseVisualStyleBackColor = true;
            this.btn_toline_cancel.Click += new System.EventHandler(this.btn_toline_cancel_Click);
            // 
            // ToLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 124);
            this.Controls.Add(this.btn_toline_cancel);
            this.Controls.Add(this.btn_toline_ok);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToLineForm";
            this.Text = "转到指定行";
            this.Load += new System.EventHandler(this.ToLineForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_toline_ok;
        private System.Windows.Forms.Button btn_toline_cancel;
    }
}