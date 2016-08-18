using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class ToLineForm : Form
    {
        private RichTextBox rtb = new RichTextBox();
        public ToLineForm()
        {
            InitializeComponent();
        }

        private void btn_toline_ok_Click(object sender, EventArgs e)
        {
            int row = int.Parse(textBox1.Text);
            int pos = 0;
            string[] str = rtb.Text.Split('\r', '\n');

            if (row < 1 || row > str.Length)
                MessageBox.Show("行数超出范围", "记事本 - 跳行", MessageBoxButtons.OK);
            else
            {
                for (int i = 1; i < row; i++)
                    pos = pos + str[i - 1].Length + 1;
                this.Close();
                rtb.Focus();
                rtb.SelectionStart = pos;
            }
        }

        private void ToLineForm_Load(object sender, EventArgs e)
        {
            NotepadForm main = (NotepadForm)this.Owner;
            this.rtb = main.rtb;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
                MessageBox.Show("只能接收数字", "记事本", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_toline_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
