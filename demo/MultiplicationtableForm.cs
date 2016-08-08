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
    public partial class MultiplicationtableForm : Form
    {
        public MultiplicationtableForm()
        {
            InitializeComponent();
        }

        #region ★　Function

        #region MultiplicationtableForm_Load(object sender, EventArgs e) :: Load MultiplicationtableForm;初始化窗口
        /// <summary>
        /// Load MultiplicationtableForm,put number to cmb_ChooseNumber;初始化窗口,把数字放到
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MultiplicationtableForm_Load(object sender, EventArgs e)
        {
            //设置内容居中
            DataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            for (int i = 0; i < 10; i++)
            {
                cmb_ChooseNumber.Items.Add(i);
            }
        }


        #endregion

        #region ShowMultiplicationTableListView(int number) :: ShowMultiplicationTableListView;在ListView上显示乘法表
        /// <summary>
        /// ShowMultiplicationTableListView;在ListView上显示乘法表
        /// </summary>
        /// <param name="number">传过来的数字</param>
        private void ShowMultiplicationTableListView(int number)
        {
            ListView1.Items.Add("choose number：" + number + "");

            for (int i = 1; i < 10; i++)
            {
                ListView1.Items.Add(i + "*" + number + "=" + i * number);
            }
        }
        #endregion

        #region ShowMultiplicationTableDataGridView(int number) :: ShowMultiplicationTableDataGridView;在DataGridView上显示乘法表
        /// <summary>
        /// ShowMultiplicationTableDataGridView;在DataGridView上显示乘法表
        /// </summary>
        /// <param name="number">传过来的数字</param>
        private void ShowMultiplicationTableDataGridView(int number)
        {
            DataGridView1.ColumnCount = 3;
            DataGridView1.ColumnHeadersVisible = true;
            DataGridView1.Columns[0].Name = "Number";
            DataGridView1.Columns[1].Name = "Formula";
            DataGridView1.Columns[2].Name = "Result";
            DataGridView1.Rows.Clear();
            for (int i = 1; i < 10; i++)
            {
                string[] row1 = new string[10];
                row1[0] = i + "";
                row1[1] = i + "*" + number;
                row1[2] = i * number + "";
                DataGridView1.Rows.Add(row1);
            }
        }
        #endregion

        #region ShowMultiplicationTableTextBox(int number) :: ShowMultiplicationTableTextBox;在TableTextBox上显示乘法表
        /// <summary>
        /// ShowMultiplicationTableTextBox;在TableTextBox上显示乘法表
        /// </summary>
        /// <param name="number"></param>
        private void ShowMultiplicationTableTextBox(int number)
        {
            textBox1.Multiline = true;
            for (int i = 1; i < 10; i++)
            {
                textBox1.AppendText(i * number + "\r\n");
            }
        }
        #endregion

        #endregion

        #region ★　Event
       
        #region btn_Ok_Click(object sender, EventArgs e) ::btn_Ok_Click;单事件
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            //clear;清空控件中的内容,DataGridView要用Rows.Clear();方法
            ListView1.Clear();
            textBox1.Clear();
            DataGridView1.Rows.Clear();
            //取出ComBoBox中选择的内容
            String checkedNumber = cmb_ChooseNumber.Text;
            int number = int.Parse(checkedNumber);

            if (checkedNumber == "")
            {
                //如果没有选择的话提示一下
                MessageBox.Show("No Choose!");
            }
            else
            {
                ShowMultiplicationTableTextBox(number);
                ShowMultiplicationTableDataGridView(number);
                ShowMultiplicationTableListView(number);
            }
        } 
        #endregion

        #endregion
    }
}
