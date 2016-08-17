using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace demo
{
    public partial class NotepadForm : Form
    {
        //记录是否被修改过
        bool ischanged = false;
        //保存文件名
        string filename = null;
        public NotepadForm()
        {
            InitializeComponent();
        }
        #region ★ Event

        #region tsmi_new_Click(object sender, EventArgs e) :: new file;新建文件
        /// <summary>
        /// new file;新建文件
        /// 是否需要保存对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_new_Click(object sender, EventArgs e)
        {
            if (ischanged)
            {
                //如果已经修改过之后,保存
                string s = this.Text.ToString();
                string[] s1 = s.Split('-');
                s = s1[0];
                DialogResult dr;
                dr = MessageBox.Show("是否将内容保存到 " + s, "记事本", MessageBoxButtons.YesNoCancel,
               MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.Yes)
                {
                    //保存
                    tsmi_save_Click(null, null);
                }
                else if (dr == DialogResult.No)
                {
                    //不保存就清空内容
                    rtb.Text = "";
                    this.Text = "无标题 - 记事本";
                }
                else if (dr == DialogResult.Cancel)
                {
                    return;
                }
                else
                {
                    return;
                }
            }
            else
            {
                rtb.Text = "";
                this.Text = "无标题 - 记事本";
            }
        }
        #endregion

        #region tsmi_open_Click(object sender, EventArgs e) :: open file;打开文件
        /// <summary>
        /// open file;打开文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                FileInfo finfo = new FileInfo(filename);
                this.Text = finfo.Name;
                this.Text += "-记事本";
                StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.UTF8);
                rtb.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
        #endregion

        #region tsmi_save_Click(object sender, EventArgs e) :: save file;保存文件
        /// <summary>
        /// save file;保存文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_save_Click(object sender, EventArgs e)
        {
            if (this.Text.Equals("无标题 - 记事本"))
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //保存的时候把文件名放到全局变量filename中
                    StreamWriter c = new StreamWriter(saveFileDialog1.FileName);
                    filename = saveFileDialog1.FileName;
                    c.Write(rtb.Text);
                    c.Close();
                    this.Text = saveFileDialog1.FileName.ToString().Substring(saveFileDialog1.FileName.ToString().LastIndexOf("\\") + 1);
                }
            }
            else
            {
                StreamWriter c = new StreamWriter(filename);
                c.Write(rtb.Text);
                c.Close();
            }
        }
        #endregion

        #region tsmi_saveas_Click(object sender, EventArgs e) :: save as;另存为
        /// <summary>
        /// save as;另存为
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_saveas_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //读取的时候设置字符编码为Default
                StreamWriter c = new StreamWriter(saveFileDialog1.FileName);
                c.Write(rtb.Text);
                c.Close();
                this.Text = saveFileDialog1.FileName.ToString().Substring(saveFileDialog1.FileName.ToString().LastIndexOf("\\") + 1);
            }
        }
        #endregion

        #region tsmi_pageset_Click(object sender, EventArgs e) :: paper setting;页面设置
        /// <summary>
        /// paper setting;页面设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_pageset_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region tsmi_print_Click(object sender, EventArgs e) :: print;打印
        /// <summary>
        /// print;打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_print_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region tsmi_exit_Click(object sender, EventArgs e) :: exit:推出
        /// <summary>
        /// exit:推出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_exit_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region tsmi_revocation_Click(object sender, EventArgs e) :: revocation;撤销
        /// <summary>
        /// revocation;撤销
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_revocation_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region tsmi_cut_Click(object sender, EventArgs e) :: cut;剪切
        /// <summary>
        /// cut;剪切
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_cut_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region tsmi_copy_Click(object sender, EventArgs e) ::  copy;复制
        /// <summary>
        /// copy;复制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_copy_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region tsmi_paste_Click(object sender, EventArgs e) :: paste;粘贴
        /// <summary>
        /// paste;粘贴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_paste_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region tsmi_find_Click(object sender, EventArgs e) :: find;查找
        /// <summary>
        /// find;查找
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_find_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region tsmi_findnext_Click(object sender, EventArgs e) :: findnext;查找下一个
        /// <summary>
        /// findnext;查找下一个
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_findnext_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region tsmi_replace_Click(object sender, EventArgs e) :: replace;替换
        /// <summary>
        /// replace;替换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_replace_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region tsmi_toline_Click(object sender, EventArgs e) :: toline;转到
        /// <summary>
        /// toline;转到
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_toline_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region tsmi_allselect_Click(object sender, EventArgs e) :: allselect;全选
        /// <summary>
        /// allselect;全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_allselect_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region tsmi_time_Click(object sender, EventArgs e) :: insert time;插入时间
        /// <summary>
        /// insert time;插入时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_time_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region tsmi_autochangeline_Click(object sender, EventArgs e) :: autochangeline;自动换行
        /// <summary>
        /// autochangeline;自动换行   
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_autochangeline_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region tsmi_font_Click(object sender, EventArgs e) :: font setting;字体设置
        /// <summary>
        /// font setting;字体设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_font_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region tsmi_about_Click(object sender, EventArgs e) :: about;关于
        /// <summary>
        /// about;关于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_about_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #endregion

        private void rtb_TextChanged(object sender, EventArgs e)
        {
            ischanged = true;
        }
    }
}
