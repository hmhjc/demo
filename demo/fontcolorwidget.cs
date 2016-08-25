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
    public partial class fontcolorwidget : UserControl
    {
        private RichTextBox rtb;
        private Color _SelectedColor;
        public Color SelectedColor

        {

            get { return _SelectedColor; }

            set { _SelectedColor = value; }

        }

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

        public event EventHandler SelectColorChanged;
        public fontcolorwidget()
        {
            InitializeComponent();
            AddComponent();
        }

        private void AddComponent()

        {

            this.comboBox1.DrawMode = DrawMode.OwnerDrawFixed;

            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            //设定ComboBox的高度

            this.comboBox1.ItemHeight = 18;

            this.comboBox1.BeginUpdate();

            this.comboBox1.Items.Clear();

            //加载系统所有的颜色，如果使用自定义颜色初始值时则注销下面的代码

            Array colors = System.Enum.GetValues(typeof(KnownColor));

            for (int i = colors.GetLength(0) - 1; i >= 0; i--)

            {

                this.comboBox1.Items.Add(colors.GetValue(i).ToString());

            }


           
            this.comboBox1.EndUpdate();
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)

                return;

            Rectangle rect = e.Bounds;  //获取Item矩形框



            //获取对应项记录的颜色值

            string colorName = comboBox1.Items[e.Index].ToString();

            //新建单一色刷子，颜色为对应项记录的值

            SolidBrush brush = new SolidBrush(Color.FromName(colorName));
            SelectedColor = brush.Color;

            //为美观，可缩小选定项区域1个像素

            rect.Inflate(-1, -1);

            // 填充颜色

            e.Graphics.FillRectangle(brush, rect);

            // 用黑色绘制颜色边框

            e.Graphics.DrawRectangle(Pens.Black, rect);
        }

        /// <summary>

        /// 在ComboBox选择项改变触发事件中激活颜色传递事件

        /// </summary>

        /// <param name="sender"></param>

        /// <param name="e"></param>

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //修改字体的颜色
            fontcolor(this.comboBox1.Text,Rtb);
            //如果使用该控件的窗体注册了SelectColorChanged事件，则激活
            //相当于用SelectColorChanged事件替换了ComboBox的SelectedIndexChanged事件
            if (SelectColorChanged != null)

            {
                SelectColorChanged(this, e);
            }
        }

        private void fontcolor(string color, RichTextBox rtb)
        {
           // rtb.SelectionColor = Color.FromName(color);
            rtb.SelectionBackColor = Color.FromName(color);
        }
    }
}
