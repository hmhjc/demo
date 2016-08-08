namespace demo
{
    partial class MultiplicationtableForm
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
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmb_ChooseNumber = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.lbl_TextView = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(92, 87);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowTemplate.Height = 23;
            this.DataGridView1.Size = new System.Drawing.Size(336, 300);
            this.DataGridView1.TabIndex = 0;
            // 
            // ListView1
            // 
            this.ListView1.Location = new System.Drawing.Point(503, 87);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(345, 300);
            this.ListView1.TabIndex = 1;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.List;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 433);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(800, 138);
            this.textBox1.TabIndex = 2;
            // 
            // cmb_ChooseNumber
            // 
            this.cmb_ChooseNumber.FormattingEnabled = true;
            this.cmb_ChooseNumber.Location = new System.Drawing.Point(395, 31);
            this.cmb_ChooseNumber.Name = "cmb_ChooseNumber";
            this.cmb_ChooseNumber.Size = new System.Drawing.Size(126, 20);
            this.cmb_ChooseNumber.TabIndex = 3;
            this.cmb_ChooseNumber.Text = "ChooseNumber";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Multiplicationtable:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "DataGridView:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "ListView:";
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(540, 29);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 7;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // lbl_TextView
            // 
            this.lbl_TextView.AutoSize = true;
            this.lbl_TextView.Location = new System.Drawing.Point(90, 409);
            this.lbl_TextView.Name = "lbl_TextView";
            this.lbl_TextView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_TextView.Size = new System.Drawing.Size(59, 12);
            this.lbl_TextView.TabIndex = 8;
            this.lbl_TextView.Text = "TextView:";
            this.lbl_TextView.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MultiplicationtableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 616);
            this.Controls.Add(this.lbl_TextView);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_ChooseNumber);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.DataGridView1);
            this.Name = "MultiplicationtableForm";
            this.Text = "MultiplicationtableForm";
            this.Load += new System.EventHandler(this.MultiplicationtableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.ListView ListView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmb_ChooseNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label lbl_TextView;
    }
}