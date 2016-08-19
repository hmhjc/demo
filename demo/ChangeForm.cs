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
    public partial class ChangeForm : Form
    {
        private RichTextBox rtb = new RichTextBox();
        public ChangeForm()
        {
            InitializeComponent();
        }

        private void ChangeForm_Load(object sender, EventArgs e)
        {
            NotepadForm notepadForm = (NotepadForm)this.Owner;
            this.rtb = notepadForm.rtb;
            btn_change_change.Enabled = false;
            btn_change_changeall.Enabled = false;
            btn_change_find.Enabled = false;
        }

        private void btn_change_find_Click(object sender, EventArgs e)
        {
            string str = rtb.Text;
            string subSearch = textBox1.Text;
            string initString = subSearch;
            int pos = rtb.SelectionStart;

            if (!checkBox1.Checked)
            {
                str = str.ToLower();
                subSearch = subSearch.ToLower();
            }

            if (rtb.SelectionLength > 0)
                pos = pos + 1;
            if ((pos = str.IndexOf(subSearch, pos)) != -1)
            {
                rtb.Focus();
                rtb.SelectionStart = pos;
                rtb.SelectionLength = subSearch.Length;
            }
            else
                MessageBox.Show("找不到\"" + initString + "\"", "记事本",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool flag = textBox1.Text != "";
            btn_change_change.Enabled = flag;
            btn_change_changeall.Enabled = flag;
            btn_change_find.Enabled = flag;
        }

        private void btn_change_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_change_change_Click(object sender, EventArgs e)
        {
            string str = rtb.Text;
            string subSearch = textBox1.Text;
            string initString = subSearch;
            string changeTo = textBox2.Text;
            string front;
            string dest;
            string back;
            int pos = rtb.SelectionStart;

            if (!checkBox1.Checked)
            {
                str = str.ToLower();
                subSearch = subSearch.ToLower();
            }

            if (rtb.SelectionLength > 0)
            {
                if (rtb.SelectedText.Equals(subSearch))
                {
                    //将文本框字符串分段，替换后再组合
                    front = rtb.Text.Substring(0, pos);
                    dest = changeTo;
                    back = rtb.Text.Substring(pos + subSearch.Length, rtb.Text.Length - pos - subSearch.Length);
                    rtb.Text = front + dest + back;
                }
                pos = pos + 1;
            }

            if ((pos = str.IndexOf(subSearch, pos)) != -1)
            {
                rtb.Focus();
                rtb.SelectionStart = pos;
                rtb.SelectionLength = subSearch.Length;
            }
            else
                MessageBox.Show("找不到\"" + initString + "\"", "记事本",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_change_changeall_Click(object sender, EventArgs e)
        {
            string str = rtb.Text;
            string subSearch = textBox1.Text;
            string changeTo = textBox2.Text;
            string front;
            string dest;
            string back;
            int pos = 0;

            if (!checkBox1.Checked)
            {
                str = str.ToLower();
                subSearch = subSearch.ToLower();
            }

            while ((pos = str.IndexOf(subSearch, pos)) != -1)
            {
                front = rtb.Text.Substring(0, pos);
                dest = changeTo;
                back = rtb.Text.Substring(pos + subSearch.Length, rtb.Text.Length - pos - subSearch.Length);
                rtb.Text = front + dest + back;
                if (!checkBox1.Checked)
                    str = rtb.Text.ToLower();
            }
        }
    }
}
