namespace demo
{
    partial class DatabaseForm
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
            this.lbl_DatabaseName = new System.Windows.Forms.Label();
            this.cmb_DatabaseName = new System.Windows.Forms.ComboBox();
            this.txt_DatabaseName = new System.Windows.Forms.TextBox();
            this.txt_TableName = new System.Windows.Forms.TextBox();
            this.cmb_TableName = new System.Windows.Forms.ComboBox();
            this.lbl_TableName = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_isconnected = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_isStringConnected = new System.Windows.Forms.Label();
            this.lbl_DB_Connect_String = new System.Windows.Forms.Label();
            this.txt_DB_Connect_String = new System.Windows.Forms.TextBox();
            this.btn_StringConnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_DatabaseName
            // 
            this.lbl_DatabaseName.AutoSize = true;
            this.lbl_DatabaseName.Location = new System.Drawing.Point(89, 26);
            this.lbl_DatabaseName.Name = "lbl_DatabaseName";
            this.lbl_DatabaseName.Size = new System.Drawing.Size(83, 12);
            this.lbl_DatabaseName.TabIndex = 0;
            this.lbl_DatabaseName.Text = "DatabaseName:";
            // 
            // cmb_DatabaseName
            // 
            this.cmb_DatabaseName.FormattingEnabled = true;
            this.cmb_DatabaseName.Location = new System.Drawing.Point(372, 23);
            this.cmb_DatabaseName.Name = "cmb_DatabaseName";
            this.cmb_DatabaseName.Size = new System.Drawing.Size(211, 20);
            this.cmb_DatabaseName.TabIndex = 1;
            this.cmb_DatabaseName.SelectedIndexChanged += new System.EventHandler(this.cmb_DatabaseName_SelectedIndexChanged);
            // 
            // txt_DatabaseName
            // 
            this.txt_DatabaseName.Location = new System.Drawing.Point(177, 22);
            this.txt_DatabaseName.Name = "txt_DatabaseName";
            this.txt_DatabaseName.Size = new System.Drawing.Size(189, 21);
            this.txt_DatabaseName.TabIndex = 2;
            // 
            // txt_TableName
            // 
            this.txt_TableName.Location = new System.Drawing.Point(177, 83);
            this.txt_TableName.Name = "txt_TableName";
            this.txt_TableName.Size = new System.Drawing.Size(189, 21);
            this.txt_TableName.TabIndex = 5;
            // 
            // cmb_TableName
            // 
            this.cmb_TableName.FormattingEnabled = true;
            this.cmb_TableName.Location = new System.Drawing.Point(372, 83);
            this.cmb_TableName.Name = "cmb_TableName";
            this.cmb_TableName.Size = new System.Drawing.Size(211, 20);
            this.cmb_TableName.TabIndex = 4;
            this.cmb_TableName.SelectedIndexChanged += new System.EventHandler(this.cmb_TableName_SelectedIndexChanged);
            // 
            // lbl_TableName
            // 
            this.lbl_TableName.AutoSize = true;
            this.lbl_TableName.Location = new System.Drawing.Point(106, 87);
            this.lbl_TableName.Name = "lbl_TableName";
            this.lbl_TableName.Size = new System.Drawing.Size(65, 12);
            this.lbl_TableName.TabIndex = 3;
            this.lbl_TableName.Text = "TableName:";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(589, 21);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 6;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(589, 80);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(75, 23);
            this.btn_Select.TabIndex = 7;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(763, 450);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // lbl_isconnected
            // 
            this.lbl_isconnected.AutoSize = true;
            this.lbl_isconnected.Location = new System.Drawing.Point(667, 27);
            this.lbl_isconnected.Name = "lbl_isconnected";
            this.lbl_isconnected.Size = new System.Drawing.Size(0, 12);
            this.lbl_isconnected.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 450);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_isStringConnected);
            this.panel2.Controls.Add(this.lbl_DB_Connect_String);
            this.panel2.Controls.Add(this.txt_DB_Connect_String);
            this.panel2.Controls.Add(this.btn_StringConnect);
            this.panel2.Controls.Add(this.cmb_DatabaseName);
            this.panel2.Controls.Add(this.lbl_isconnected);
            this.panel2.Controls.Add(this.lbl_DatabaseName);
            this.panel2.Controls.Add(this.btn_Select);
            this.panel2.Controls.Add(this.txt_DatabaseName);
            this.panel2.Controls.Add(this.btn_Connect);
            this.panel2.Controls.Add(this.lbl_TableName);
            this.panel2.Controls.Add(this.txt_TableName);
            this.panel2.Controls.Add(this.cmb_TableName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 113);
            this.panel2.TabIndex = 11;
            // 
            // lbl_isStringConnected
            // 
            this.lbl_isStringConnected.AutoSize = true;
            this.lbl_isStringConnected.Location = new System.Drawing.Point(667, 55);
            this.lbl_isStringConnected.Name = "lbl_isStringConnected";
            this.lbl_isStringConnected.Size = new System.Drawing.Size(0, 12);
            this.lbl_isStringConnected.TabIndex = 14;
            // 
            // lbl_DB_Connect_String
            // 
            this.lbl_DB_Connect_String.AutoSize = true;
            this.lbl_DB_Connect_String.Location = new System.Drawing.Point(60, 60);
            this.lbl_DB_Connect_String.Name = "lbl_DB_Connect_String";
            this.lbl_DB_Connect_String.Size = new System.Drawing.Size(113, 12);
            this.lbl_DB_Connect_String.TabIndex = 10;
            this.lbl_DB_Connect_String.Text = "DB Connect String:";
            // 
            // txt_DB_Connect_String
            // 
            this.txt_DB_Connect_String.Location = new System.Drawing.Point(177, 51);
            this.txt_DB_Connect_String.Name = "txt_DB_Connect_String";
            this.txt_DB_Connect_String.Size = new System.Drawing.Size(406, 21);
            this.txt_DB_Connect_String.TabIndex = 12;
            // 
            // btn_StringConnect
            // 
            this.btn_StringConnect.Location = new System.Drawing.Point(589, 49);
            this.btn_StringConnect.Name = "btn_StringConnect";
            this.btn_StringConnect.Size = new System.Drawing.Size(75, 23);
            this.btn_StringConnect.TabIndex = 13;
            this.btn_StringConnect.Text = "Connect";
            this.btn_StringConnect.UseVisualStyleBackColor = true;
            this.btn_StringConnect.Click += new System.EventHandler(this.btn_StringConnect_Click);
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 560);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DatabaseForm";
            this.Text = "DatabaseForm";
            this.Load += new System.EventHandler(this.DatabaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_DatabaseName;
        private System.Windows.Forms.ComboBox cmb_DatabaseName;
        private System.Windows.Forms.TextBox txt_DatabaseName;
        private System.Windows.Forms.TextBox txt_TableName;
        private System.Windows.Forms.ComboBox cmb_TableName;
        private System.Windows.Forms.Label lbl_TableName;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_isconnected;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_isStringConnected;
        private System.Windows.Forms.Label lbl_DB_Connect_String;
        private System.Windows.Forms.TextBox txt_DB_Connect_String;
        private System.Windows.Forms.Button btn_StringConnect;
    }
}