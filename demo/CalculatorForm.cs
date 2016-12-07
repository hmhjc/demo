using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//1207
namespace demo
{
    public partial class CalculatorForm : Form
    {
        double result = 0;               //记录计算结果
        double temp1 = 0;                //记录第一个数字
        double temp2 = 0;
        Boolean isSelectPos = false;    //是否选择了运算符
        int pos = 0;                    //存储计算方式,1,2,3,4分别代表+-*/
        Boolean isFirst = true;         //是否第一次操作运算符
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void AddNum(string v)
        {
            if (isSelectPos)
            {
                textBox_insertNumber.Text = "0";
                isSelectPos = false;
            }

            string str = textBox_insertNumber.Text.ToString();
            if (str.Equals("0"))
            {
                textBox_insertNumber.Text = v;
            }
            else
            {
                textBox_insertNumber.Text += v;
            }

        }

        private Boolean Judge0()
        {
            string str = textBox_insertNumber.Text.ToString();
            if (str.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private Boolean Jdugedian()
        {
            //判断是否已经有了小数点了
            string str = textBox_insertNumber.Text.ToString();
            return str.Contains(".");
        }

        private void button_zf_Click(object sender, EventArgs e)
        {
            //修改正负号
            string str = textBox_insertNumber.Text.ToString();
            if (str.StartsWith("-"))
            {
                str = str.Remove(0, 1);
            }
            else
            {
                str = str.Insert(0, "-");
            }
            textBox_insertNumber.Text = str;
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if (!Judge0())
            {
                AddNum("0");
            }
        }

        private void button_dian_Click(object sender, EventArgs e)
        {
            string str = textBox_insertNumber.Text.ToString();
            if (str.Equals("0"))
            {
                textBox_insertNumber.Text += ".";
            }
            else if (!Jdugedian())
            {
                AddNum(".");
            }
        }

        private void Enterformula(string formula)
        {
            string insertNumber = textBox_insertNumber.Text.ToString();
            temp1 = Convert.ToDouble(insertNumber);//取得输入框中的数字
            if (!isSelectPos && isFirst)
            {
                //没有选择过运算符,且第一次选择时的操作
                isSelectPos = true;
                isFirst = false;
                label_formula.Text += insertNumber + formula;   //修改公式位置的值
                temp1 = Convert.ToDouble(insertNumber);//记录输入框中的数字
                result = temp1;
                SetPos(formula);                        //设置运算符
            }
            else if (!isSelectPos)
            {
                //没有选择过运算符,且不是第一次选择时的操作
                isSelectPos = true;
                label_formula.Text += insertNumber + formula;   //修改公式位置的值
                temp1 = Convert.ToDouble(insertNumber);//记录输入框中的数字
                switch (pos)
                {
                    case 1:
                        result = result + temp1;
                        break;
                    case 2:
                        result = result - temp1;
                        break;
                    case 3:
                        result = result * temp1;
                        break;
                    case 4:
                        result = result / temp1;
                        break;
                    default:
                        break;
                }
                textBox_insertNumber.Text = result.ToString();
                SetPos(formula);                        //设置运算符
            }
            else
            {
                //刚选择过运算符的时候，改变运算符
                SetPos(formula);                        //设置运算符
                string temp = label_formula.Text.ToString();
                temp = temp.Substring(0, temp.Length - 1);
                label_formula.Text = temp + formula;
                // result=
            }
        }

        private void SetPos(string formula)
        {
            switch (formula)
            {
                case "+":
                    pos = 1;
                    break;
                case "-":
                    pos = 2;
                    break;
                case "*":
                    pos = 3;
                    break;
                case "/":
                    pos = 4;
                    break;
                default:
                    break;
            }
        }

        private void Init()
        {
            result = 0;               //记录计算结果
            temp1 = 0;                //记录第一个数字
            isSelectPos = false;    //是否选择了运算符  
            isFirst = true;
            pos = 0;                    //存储计算方式,1,2,3,4分别代表+-*/
            textBox_insertNumber.Clear();
            textBox_insertNumber.Text = "0";
            label_formula.Text = "";
        }

        private void button_equal_Click(object sender, EventArgs e)
        {

            string insertNumber = textBox_insertNumber.Text.ToString();
            temp1 = Convert.ToDouble(insertNumber);//取得输入框中的数字
            label_formula.Text = "";   //修改公式位置的值
            temp1 = Convert.ToDouble(insertNumber);//记录输入框中的数字
            switch (pos)
            {
                case 1:
                    result = result + temp1;
                    break;
                case 2:
                    result = result - temp1;
                    break;
                case 3:
                    result = result * temp1;
                    break;
                case 4:
                    result = result / temp1;
                    break;
                default:
                    break;
            }
            textBox_insertNumber.Text = result.ToString();

            result = 0;               //记录计算结果
            temp1 = 0;                //记录第一个数字
            isSelectPos = false;    //是否选择了运算符  
            isFirst = true;
            pos = 0;                    //存储计算方式,1,2,3,4分别代表+-*/
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Enterformula("+");
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            AddNum("3");
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            AddNum("2");
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            AddNum("1");
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            AddNum("4");
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            AddNum("5");
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            AddNum("6");
        }

        private void button_mul_Click(object sender, EventArgs e)
        {
            Enterformula("*");
        }

        private void button_sub_Click(object sender, EventArgs e)
        {
            Enterformula("-");
        }


        private void button_clearEnter_Click(object sender, EventArgs e)
        {
            //输入框清零 
            textBox_insertNumber.Clear();
            textBox_insertNumber.Text = "0";
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            //所有状态清零
            Init();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string insertNumber = textBox_insertNumber.Text.ToString();
            insertNumber = insertNumber.Remove(insertNumber.Length - 1, 1);
            if (insertNumber.Length > 0)
            {
                textBox_insertNumber.Text = insertNumber;
            }
            else
            {
                textBox_insertNumber.Text = "0";

            }
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            if (textBox_insertNumber.Text.ToString().Equals("0"))
            {
                MessageBox.Show("除数不能为0");
            }
            else
            {
                Enterformula("/");
            }
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            AddNum("7");
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            AddNum("8");
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            AddNum("9");
        }

        private void CalculatorForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Shift && e.KeyValue==56)
            {
                //乘法
                button_mul_Click(null,null);
            }
            else if (e.Modifiers == Keys.Shift && e.KeyValue == 187)
            {
                button_add_Click(null,null);
            }
            else 
            {
                switch (e.KeyValue)
                {
                    case 48:
                        button_0_Click(null, null);
                        break;
                    case 96:
                        button_0_Click(null, null);
                        break;
                    case 49:
                        button_1_Click(null, null);
                        break;
                    case 97:
                        button_1_Click(null, null);
                        break;
                    case 50:
                        button_2_Click(null, null);
                        break;
                    case 98:
                        button_2_Click(null, null);
                        break;
                    case 51:
                        button_3_Click(null, null);
                        break;
                    case 99:
                        button_3_Click(null, null);
                        break;
                    case 52:
                        button_4_Click(null, null);
                        break;
                    case 100:
                        button_4_Click(null, null);
                        break;
                    case 53:
                        button_5_Click(null, null);
                        break;
                    case 101:
                        button_5_Click(null, null);
                        break;
                    case 54:
                        button_6_Click(null, null);
                        break;
                    case 102:
                        button_6_Click(null, null);
                        break;
                    case 55:
                        button_7_Click(null, null);
                        break;
                    case 103:
                        button_7_Click(null, null);
                        break;
                    case 56:
                        button_8_Click(null, null);
                        break;
                    case 104:
                        button_8_Click(null, null);
                        break;
                    case 57:
                        button_9_Click(null, null);
                        break;
                    case 105:
                        button_9_Click(null, null);
                        break;
                    case 189:
                        button_sub_Click(null, null);
                        break;
                    case 109:
                        button_sub_Click(null, null);
                        break;
                    case 190:
                        button_dian_Click(null, null);
                        break;
                    case 110:
                        button_dian_Click(null, null);
                        break;
                    case 191:
                        button_div_Click(null, null);
                        break;
                    case 111:
                        button_div_Click(null, null);
                        break;
                    case 8:
                        button_delete_Click(null, null);
                        break;
                    case 187:
                        button_equal_Click(null, null);
                        break;
                    case 13:
                        button_equal_Click(null, null);
                        break;
                    case 106:
                        button_mul_Click(null, null);
                        break;
                    case 107:
                        button_add_Click(null, null);
                        break;
                    default:
                        break;
                }
            }
          
        }
    }
}
