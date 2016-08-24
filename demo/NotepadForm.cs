using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace demo
{
    public partial class NotepadForm : Form
    {
        public NotepadForm()
        {
            InitializeComponent();
        }

        #region ★ Var
        //记录是否被修改过
        bool ischanged = false;
        //保存文件名
        string path = "";
        //选中的文字
        string selectText = null;

        private System.Drawing.Text.InstalledFontCollection objFont = new System.Drawing.Text.InstalledFontCollection();
        //是否加粗
        bool isBold = false;
        //是否倾斜
        bool isItalic = false;
        //是否有下划线
        bool isUnderline = false;
        #endregion

        #region ★ Event

        #region tsmi_Click ::菜单栏单击事件 

        #region tsmi_new_Click(object sender, EventArgs e) :: new file;新建文件
        /// <summary>
        /// new file;新建文件
        /// 是否需要保存对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_new_Click(object sender, EventArgs e)
        {
            new_action(ischanged, this.rtb);
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
            open_action(openFileDialog1, this.rtb);
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
            save_action();
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
            saveas_action(saveFileDialog1, path);
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
            pageSetupDialog1.Document = printDocument1;
            pageSetupDialog1.ShowDialog();
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
            print_action();
        }

        private void print_action()
        {
            printDialog1.Document = printDocument1;
            printDialog1.ShowDialog();
        }
        #endregion

        #region tsmi_exit_Click(object sender, EventArgs e) :: exit:退出
        /// <summary>
        /// exit:退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_exit_Click(object sender, EventArgs e)
        {
            this.Close();
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
            revocation(rtb);
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
            cut_action();

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
            copy_action();

        }

        private void copy_action()
        {
            this.rtb.Copy();
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
            paste_action();

        }


        #endregion

        #region tsmi_delete_Click(object sender, EventArgs e) :: delete;删除操作
        /// <summary>
        /// delete;删除操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_delete_Click(object sender, EventArgs e)
        {
            delete_action();
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
            find_action();
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
            find_action();
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
            replace_action();
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
            toline_action();
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
            this.rtb.SelectAll();
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
            inserttime();
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
            autochangeline();
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
            fontsetting_action();
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

        #region tsmi_state_Click(object sender, EventArgs e) :: state;状态栏
        /// <summary>
        /// state;状态栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_state_Click(object sender, EventArgs e)
        {
            if (tsmi_state.Checked)
            {
                tsmi_state.Checked = false;
                statusStrip1.Visible = false;
            }
            else
            {
                tsmi_state.Checked = true;
                statusStrip1.Visible = true;
            }
        }
        #endregion

        #endregion
      
        #region 右击事件

        #region 撤销UToolStripMenuItem_Click(object sender, EventArgs e) :: 撤销UToolStripMenuItem_Click;右键撤销操作
        /// <summary>
        /// 撤销UToolStripMenuItem_Click;右键撤销操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 撤销UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            revocation(rtb);
        }
        #endregion

        #region 剪切TToolStripMenuItem_Click(object sender, EventArgs e) :: 剪切TToolStripMenuItem_Click;右键剪切
        private void 剪切TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cut_action();
        }
        #endregion

        #region 复制CToolStripMenuItem_Click(object sender, EventArgs e) :: 复制CToolStripMenuItem_Click;右键复制操作
        private void 复制CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copy_action();
        }
        #endregion

        #region 粘贴PToolStripMenuItem_Click(object sender, EventArgs e) :: 粘贴PToolStripMenuItem_Click;右键粘贴
        private void 粘贴PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paste_action();
        }
        #endregion

        #region 删除DToolStripMenuItem_Click(object sender, EventArgs e) :: 删除DToolStripMenuItem_Click;右键删除
        private void 删除DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete_action();
        }
        #endregion

        #endregion

        #region rtb_Text :: 文字改变事件

        #region rtb_TextChanged(object sender, EventArgs e) :: 文字是否改变
        /// <summary>
        /// rtb_TextChanged(object sender, EventArgs e);文字变化时,设置全局变量ischanged为true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rtb_TextChanged(object sender, EventArgs e)
        {
            ischanged = true;
            if (this.Text.Equals(""))
            {
                //说明没有内容,查找和查找下一个不可点
                tsmi_find.Enabled = false;
                tsmi_findnext.Enabled = false;
            }
            else
            {
                tsmi_find.Enabled = true;
                tsmi_findnext.Enabled = true;
            }
        }
        #endregion

        #region rtb_SelectionChanged(object sender, EventArgs e);选中文字时的操作
        /// <summary>
        /// rtb_SelectionChanged(object sender, EventArgs e);选中文字时的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rtb_SelectionChanged(object sender, EventArgs e)
        {
            if (this.rtb.SelectedText.Equals(""))
            {
                tsmi_cut.Enabled = false;
                tsmi_copy.Enabled = false;
                tsmi_delete.Enabled = false;
            }
            else
            {
                tsmi_cut.Enabled = true;
                tsmi_copy.Enabled = true;
                tsmi_delete.Enabled = true;
                selectText = rtb.SelectedText;
            }
            string[] str = rtb.Text.Split('\r', '\n');
            int row = 1, column = 1, pos = rtb.SelectionStart;

            foreach (string s in str)
                Console.WriteLine(s);
            Console.WriteLine("pos={0}", pos);

            for (int i = 0; i < str.Length && pos - str[i].Length > 0; i++)
            {
                pos = pos - str[i].Length - 1;
                row = i + 2;
            }
            column = pos + 1;
            toolStripStatusLabel2.Text = "第 " + row + " 行，第 " + column + " 列";
        }

        #endregion

        #endregion

        #region NotepadForm_KeyDown(object sender, KeyEventArgs e) :: NotepadForm_KeyDown;键盘组合键事件
        /// <summary>
        /// NotepadForm_KeyDown;键盘组合键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotepadForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyValue == 78)
            {
                //ctrl+n,新建操作
                new_action(ischanged, this.rtb);
            }
            else if (e.Modifiers == Keys.Control && e.KeyValue == 79)
            {
                //ctrl+o,打开操作
                open_action(openFileDialog1, this.rtb);
            }
            else if (e.Modifiers == Keys.Control && e.KeyValue == 83)
            {
                //ctrl+s,保存操作
                save_action();
            }
            else if (e.Modifiers == Keys.Control && e.KeyValue == 80)
            {
                //ctrl+p,打印操作
                print_action();
            }
            else if (e.Modifiers == Keys.Control && e.KeyValue == 70)
            {
                //ctrl+F,查找操作
                if (!this.Text.Equals(""))
                {
                    find_action();
                }
            }
            else if (e.KeyValue == 114)
            {
                //F3查找下一个
                if (!this.Text.Equals(""))
                {
                    find_action();
                }
            }
            else if (e.Modifiers == Keys.Control && e.KeyValue == 72)
            {
                //Ctrl+H,替换
                replace_action();
            }
            else if (e.Modifiers == Keys.Control && e.KeyValue == 71)
            {
                //Ctrl+G,转到
                toline_action();
            }
            else if (e.KeyValue == 116)
            {
                //F5,日期时间
                inserttime();
            }
        }
        #endregion

        #region NotepadForm_FormClosing(object sender, FormClosingEventArgs e) :: NotepadForm_FormClosing;关闭按钮
        private void NotepadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ischanged)
            {
                //以下是文字改变的情况下的操作
                if (!("".Equals(path)))
                {
                    //有路径,说明是打开的已经存在的文件,提示用户
                    DialogResult dr = MessageBox.Show("是否将更改保存到" + path + "?", "记事本",
                    MessageBoxButtons.YesNoCancel);
                    if (dr == DialogResult.Yes)
                    {
                        StreamWriter c = new StreamWriter(path);
                        c.Write(rtb.Text);
                        c.Close();
                    }
                    else if (dr == DialogResult.No)
                    {
                        e.Cancel = false;
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    //没有路径,说明是新建的文件,这个时候是另存为的操作
                    DialogResult dr = MessageBox.Show("是否将更改保存到 无标题?", "记事本",
                        MessageBoxButtons.YesNoCancel);
                    if (dr == DialogResult.Yes)
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            StreamWriter c = new StreamWriter(saveFileDialog1.FileName);
                            path = saveFileDialog1.FileName;
                            c.Write(rtb.Text);
                            c.Close();
                            this.Text = saveFileDialog1.FileName.ToString().Substring(saveFileDialog1.FileName.ToString().LastIndexOf("\\") + 1);
                        }
                        else
                        {
                            e.Cancel = true;
                        }
                    }
                    else if (dr == DialogResult.No)
                    {
                        e.Cancel = false;
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }

            }
        }
        #endregion

        #endregion

        #region ★ Function

        #region NotepadForm_Load(object sender, EventArgs e) :: NotepadForm_Load;初始化
        /// <summary>
        /// NotepadForm_Load;初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotepadForm_Load(object sender, EventArgs e)
        {
            //foreach (System.Drawing.FontFamily i in objFont.Families)
            //{
            //    cboFont.Items.Add(i.Name.ToString());
            //}
            //cboFont.SelectedIndex = 0;
            //初始化,撤销,剪切,复制,删除不可用
            this.fontsetting1.Rtb = this.rtb;
            this.fontsizewidget.Rtb = this.rtb;
            tsmi_revocation.Enabled = false;
            tsmi_copy.Enabled = false;
            tsmi_cut.Enabled = false;
            tsmi_delete.Enabled = false;
            if (rtb.Equals(""))
            {
                tsmi_find.Enabled = false;
                tsmi_findnext.Enabled = false;
            }
            else
            {
                tsmi_find.Enabled = true;
                tsmi_findnext.Enabled = true;
            }
            if (Clipboard.ContainsText())
            {
                tsmi_paste.Enabled = true;
            }
            else
            {
                tsmi_paste.Enabled = false;
            }
            //默认自动换行,没有状态栏
            tsmi_autochangeline.Checked = true;
            rtb.WordWrap = true;
            tsmi_state.Enabled = false;
            tsmi_state.Checked = false;
            statusStrip1.Visible = false;
            //撤销,剪切,复制,删除,查找,查找下一个,转到不可点
            tsmi_copy.Enabled = false;
            tsmi_cut.Enabled = false;
            tsmi_delete.Enabled = false;
            tsmi_find.Enabled = false;
            tsmi_findnext.Enabled = false;
            tsmi_toline.Enabled = false;
        }
        #endregion

        #region new_action(bool ischanged, RichTextBox rtb) :: new_action();新建操作
        /// <summary>
        /// new_action();新建操作
        /// </summary>
        /// <param name="ischanged">是否已经修改过文本</param>
        /// <param name="rtb">RichTextBox,文本输入控件</param>
        private void new_action(bool ischanged, RichTextBox rtb)
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
                    //保存之后再清空内容
                    tsmi_save_Click(null, null);
                    rtb.Text = "";
                    this.Text = "无标题 - 记事本";
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

        #region revocation(RichTextBox rtb) :: revocation;撤销操作
        /// <summary>
        /// revocation;撤销操作
        /// </summary>
        /// <param name="rtb"></param>
        private void revocation(RichTextBox rtb)
        {
            rtb.Undo();
        }
        #endregion

        #region open_action(OpenFileDialog openFileDialog,RichTextBox richTextBox) :: open_action();打开操作
        /// <summary>
        /// open_action;打开操作
        /// </summary>
        /// <param name="openFileDialog"></param>
        /// <param name="richTextBox"></param>
        private void open_action(OpenFileDialog openFileDialog, RichTextBox richTextBox)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                path = openFileDialog.FileName;
                FileInfo finfo = new FileInfo(path);
                this.Text = finfo.Name;
                this.Text += "-记事本";
                StreamReader sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8);
                richTextBox.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
        #endregion

        #region autochangeline;自动换行
        private void autochangeline()
        {
            if (rtb.WordWrap)
            {
                tsmi_autochangeline.Checked = false;
                rtb.WordWrap = false;
                tsmi_state.Enabled = true;
                tsmi_toline.Enabled = true;
            }
            else
            {
                tsmi_autochangeline.Checked = true;
                rtb.WordWrap = true;
                //自动换行的时候没有状态栏
                tsmi_state.Enabled = false;
                tsmi_state.Checked = false;
                statusStrip1.Visible = false;
                tsmi_toline.Enabled = false;
            }
        }
        #endregion

        #region cut_action() :: cut;剪切操作
        private void cut_action()
        {
            this.rtb.Cut();
        }
        #endregion

        #region paste_action() :: paste;粘贴操作
        private void paste_action()
        {
            this.rtb.Paste();
        }
        #endregion

        #region delete_action() :: 删除操作
        private void delete_action()
        {
            this.rtb.SelectedText = "";
        }
        #endregion

        #region saveas_action() :: saveas_action;另存为操作 
        private void saveas_action(SaveFileDialog saveFileDialog, string path)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //读取的时候设置字符编码为Default
                StreamWriter c = new StreamWriter(saveFileDialog.FileName);
                path = saveFileDialog1.FileName;
                c.Write(rtb.Text);
                c.Close();
                this.Text = saveFileDialog1.FileName.ToString().Substring(saveFileDialog.FileName.ToString().LastIndexOf("\\") + 1);
                ischanged = false;
            }
        }
        #endregion

        #region save_action() :: save_action;保存操作
        private void save_action()
        {
            if (this.Text.Equals("无标题 - 记事本"))
            {
                saveas_action(saveFileDialog1, path);
            }
            else
            {
                StreamWriter c = new StreamWriter(path);
                c.Write(rtb.Text);
                c.Close();
                ischanged = false;
            }


        }
        #endregion

        #region fontsetting_action() :: fontsetting_action;字体设置
        private void fontsetting_action()
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK)
            {
                this.rtb.Font = font.Font;
            }
        }
        #endregion

        #region find_action() :: find;查找
        private void find_action()
        {
            SearchForm search = new SearchForm();
            search.Owner = this;
            search.Show();
        }
        #endregion

        #region toline_action() :: toline;转到指定行
        private void toline_action()
        {
            ToLineForm tl = new ToLineForm();
            tl.Owner = this;
            tl.Show();
        }

        #endregion

        #region replace_action() :: replace_action;替换操作
        private void replace_action()
        {
            ChangeForm cf = new ChangeForm();
            cf.Owner = this;
            cf.Show();
        }
        #endregion

        #region inserttime();插入日期时间操作
        private void inserttime()
        {
            string front = rtb.Text.Substring(0, rtb.SelectionStart);
            string back = rtb.Text.Substring(rtb.SelectionStart,
                rtb.Text.Length - rtb.SelectionStart);
            rtb.Text = front + DateTime.Now.ToString() + back;
            rtb.SelectionStart = rtb.TextLength;
            rtb.Focus();
        }

        #endregion

        private void changetextfont1(string v)
        {
            Font oldFont, newFont;
            oldFont = rtb.SelectionFont;
            if (oldFont.Bold)
            {
                newFont = new Font(oldFont, oldFont.Style ^ FontStyle.Bold);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);
            }
            rtb.SelectionFont = newFont;
            rtb.Focus();
        }

        #endregion
       

        //private void cboFont_MeasureItem(object sender, MeasureItemEventArgs e)
        //{
        //   Font objFonts = new Font(cboFont.Items[e.Index].ToString(), 14);
        //    e.ItemHeight = objFonts.Height;
        //}

        //private void cboFont_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    System.Drawing.Font objFonts = new Font(cboFont.Items[e.Index].ToString(), 14);
        //    e.DrawBackground();
        //    e.Graphics.DrawString(cboFont.Items[e.Index].ToString(), objFonts, new SolidBrush(e.ForeColor), new Point(e.Bounds.Left, e.Bounds.Top));
        //}
    }
}
