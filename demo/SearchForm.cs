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
    public partial class SearchForm : Form
    {
        private RichTextBox rtb = new RichTextBox();
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            NotepadForm main = (NotepadForm)this.Owner;
            this.rtb = main.rtb;
        }

        #region btn_search_cancle_Click(object sender, EventArgs e) ：： cancle;取消按钮
        private void btn_search_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void btn_search_findnext_Click(object sender, EventArgs e)
        {
            //文件内容
            string str = rtb.Text;
            //查找内容
            string subSearch = textBox1.Text;
            string initString = subSearch;
            int pos = rtb.SelectionStart;
            if (!checkBox1.Checked)
            {
                //不区分大小写的时候转换为小写
                str = str.ToLower();
                subSearch = subSearch.ToLower();
            }
            if (rdo_up.Checked)
            {
                if (rtb.SelectionLength > 0)
                {
                    pos = pos + rtb.SelectionLength - 1;
                }
                str = str.Substring(0, pos);
                if (subSearch != "" && (pos = str.LastIndexOf(subSearch, pos)) != -1)
                {
                    //输入框得到焦点并选中查找内容
                    rtb.Focus();
                    rtb.SelectionStart = pos;
                    rtb.SelectionLength = subSearch.Length;
                }
                else
                {
                    MessageBox.Show("找不到\"" + initString + "\"", "记事本",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (rtb.SelectionLength > 0)
                {
                    pos = pos + 1;
                }
                if (subSearch != "" && (pos = str.IndexOf(subSearch, pos)) != -1)
                {
                    rtb.Focus();
                    rtb.SelectionStart = pos;
                    rtb.SelectionLength = subSearch.Length;
                }
                else
                {
                    MessageBox.Show("找不到\"" + subSearch + "\"", "记事本",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
