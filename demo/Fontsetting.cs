using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class Fontsetting : UserControl
    {
        RichTextBox rtb;

        //是否加粗
        bool isBold = false;
        //是否倾斜
        bool isItalic = false;
        //是否有下划线
        bool isUnderline = false;

        public RichTextBox Rtb
        {
            get
            {
                return rtb;
            }

            set
            {
                rtb = value;
            }
        }

        public Fontsetting()
        {
            InitializeComponent();
        }

        private void tsbtn_bold_Click(object sender, EventArgs e)
        {
            changetextfont("Bold",Rtb);
        }
        private void tsbtn_Italic_Click(object sender, EventArgs e)
        {
            changetextfont("Italic", Rtb);
        }

        private void tsbtn_Underline_Click(object sender, EventArgs e)
        {
            changetextfont("Underline", Rtb);
        }
        private void changetextfont(string fontstyle,RichTextBox rtb)
        {
            switch (fontstyle)
            {
                case "Bold":
                    if (isBold)
                    {
                        //加粗状态下,取消加粗
                        isBold = false;
                        tsbtn_bold.BackColor = Color.Transparent;
                        if (isItalic)
                        {
                            //倾斜的时候
                            if (isUnderline)
                            {
                                //加粗倾斜且有下划线,此时设置倾斜+下划线
                                rtb.SelectionFont = new Font(Font, FontStyle.Italic | FontStyle.Underline);
                            }
                            else
                            {
                                //加粗倾斜且没有下划线,此时设置倾斜
                                rtb.SelectionFont = new Font(Font, FontStyle.Italic);
                            }
                        }
                        else
                        if (isUnderline)
                        {
                            //加粗且有下划线,此时设置下划线
                            rtb.SelectionFont = new Font(Font, FontStyle.Underline);
                        }
                        else
                        {
                            rtb.SelectionFont = new Font(Font, FontStyle.Regular);
                        }
                    }
                    else
                    {
                        //不是加粗的情况下,加粗
                        isBold = true;
                        tsbtn_bold.BackColor = Color.Orange;
                        if (isItalic)
                        {
                            //倾斜的时候
                            if (isUnderline)
                            {
                                //加粗倾斜且有下划线,此时设置加粗+倾斜+下划线
                                rtb.SelectionFont = new Font(Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                            }
                            else
                            {
                                //加粗倾斜且没有下划线,此时设置加粗+倾斜
                                rtb.SelectionFont = new Font(Font, FontStyle.Bold | FontStyle.Italic);
                            }
                        }
                        else
                        if (isUnderline)
                        {
                            //加粗且有下划线,此时设置加粗+下划线
                            rtb.SelectionFont = new Font(Font, FontStyle.Bold | FontStyle.Underline);
                        }
                        else
                        {
                            rtb.SelectionFont = new Font(Font, FontStyle.Bold);
                        }
                    }
                    break;
                case "Italic":
                    if (isItalic)
                    {
                        //倾斜状态下,取消倾斜
                        isItalic = false;
                        tsbtn_Italic.BackColor = Color.Transparent;
                        if (isBold)
                        {
                            //加粗的时候
                            if (isUnderline)
                            {
                                //加粗倾斜且有下划线,此时设置加粗+下划线
                                rtb.SelectionFont = new Font(Font, FontStyle.Bold | FontStyle.Underline);
                            }
                            else
                            {
                                //加粗倾斜且没有下划线,此时设置加粗
                                rtb.SelectionFont = new Font(Font, FontStyle.Bold);
                            }
                        }
                        else
                        if (isUnderline)
                        {
                            //倾斜且有下划线,此时设置下划线
                            rtb.SelectionFont = new Font(Font, FontStyle.Underline);
                        }
                        else
                        {
                            rtb.SelectionFont = new Font(Font, FontStyle.Regular);
                        }
                    }
                    else
                    {
                        //不是倾斜的情况下,倾斜
                        isItalic = true;
                        tsbtn_Italic.BackColor = Color.Orange;
                        if (isBold)
                        {
                            //加粗的时候
                            if (isUnderline)
                            {
                                //加粗+下划线,此时设置加粗+倾斜+下划线
                                rtb.SelectionFont = new Font(Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                            }
                            else
                            {
                                //加粗倾斜且没有下划线,此时设置加粗+倾斜
                                rtb.SelectionFont = new Font(Font, FontStyle.Bold | FontStyle.Italic);
                            }
                        }
                        else
                        if (isUnderline)
                        {
                            //下划线,此时设置倾斜+下划线
                            rtb.SelectionFont = new Font(Font, FontStyle.Italic | FontStyle.Underline);
                        }
                        else
                        {
                            rtb.SelectionFont = new Font(Font, FontStyle.Italic);
                        }
                    }
                    break;
                case "Underline":
                    if (isUnderline)
                    {
                        //下划线状态下,取消下划线
                        isUnderline = false;
                        tsbtn_Underline.BackColor = Color.Transparent;
                        if (isItalic)
                        {
                            //倾斜的时候
                            if (isBold)
                            {
                                //加粗+倾斜+下划线,此时设置加粗+倾斜
                                rtb.SelectionFont = new Font(Font, FontStyle.Bold | FontStyle.Italic);
                            }
                            else
                            {
                                //倾斜+下划线,此时设置下划线
                                rtb.SelectionFont = new Font(Font, FontStyle.Italic);
                            }
                        }
                        //下面考虑是否加粗
                        if (isBold)
                        {
                            //加粗且有下划线,此时设置加粗
                            rtb.SelectionFont = new Font(Font, FontStyle.Bold);
                        }
                        else
                        {
                            rtb.SelectionFont = new Font(Font, FontStyle.Regular);
                        }
                    }
                    else
                    {
                        //不是下划线的情况下,设置下划线
                        isUnderline = true;
                        tsbtn_Underline.BackColor = Color.Orange;
                        if (isItalic)
                        {
                            //加粗的时候
                            if (isBold)
                            {
                                //加粗+倾斜,此时设置加粗+倾斜+下划线
                                rtb.SelectionFont = new Font(Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                            }
                            else
                            {
                                //倾斜,此时设置倾斜+下划线
                                rtb.SelectionFont = new Font(Font, FontStyle.Underline | FontStyle.Italic);
                            }
                        }
                        else
                        if (isBold)
                        {
                            //加粗,此时设置加粗+下划线
                            rtb.SelectionFont = new Font(Font, FontStyle.Bold | FontStyle.Underline);
                        }
                        else
                        {
                            rtb.SelectionFont = new Font(Font, FontStyle.Underline);
                        }
                    }

                    break;
            }


        }

        
    }
}
