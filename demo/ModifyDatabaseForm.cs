using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class ModifyDatabaseForm : Form
    {

        #region ★　Var
        string tableName;
        string keyName;
        string keystr;
        public bool ttt = false;
        SqlConnection conn;
        ArrayList primaryKeyListAuto = new ArrayList();
        #endregion
        public ModifyDatabaseForm(string tableName, string keyName, string keystr, SqlConnection conn)
        {
            InitializeComponent();
            this.tableName = tableName;
            this.keyName = keyName;
            this.keystr = keystr;
            this.conn = conn;
            this.ttt = false;
        }

        #region ★　Function

        #region ModifyDatabaseForm_Load(object sender, EventArgs e) :: load;初始化
        /// <summary>
        /// load;初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyDatabaseForm_Load(object sender, EventArgs e)
        {
            ShowData();
        }
        #endregion

        #region ShowData() :: show data ;把选中的数据传递到新的窗口并显示
        /// <summary>
        /// show data ;把选中的数据传递到新的窗口并显示
        /// </summary>
        private void ShowData()
        {
            //创建SqlDataAdapter对象,conn用上面实例化好的
            SqlDataAdapter sda = new SqlDataAdapter("select * from [" + tableName + "] where " + keyName + " = '" + keystr + "'", conn);
            // SqlDataAdapter sda = new SqlDataAdapter("select * from Employees where EmployeeID = 4", conn);
            //创建一个DataSet对象
            DataSet ds = new DataSet();
            //使用SqlDataAdapter对象的Fill方法填充DataSet
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        #endregion

        #endregion

        #region ★　Event

        #region btn_Close_Click(object sender, EventArgs e) :: close window;关闭窗口
        /// <summary>
        /// close window;关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion

        #region btn_Delete_Click(object sender, EventArgs e) :: 
        /// <summary>
        /// Delete data;删除该条数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            string text = "delete from " + tableName + " where " + keyName + " = '" + keystr + "'";
            cmd.CommandText = text;
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("删除成功");
            this.Dispose();
        }
        #endregion

        #region btn_New_Click(object sender, EventArgs e) :: cleardatagridview;清除内容
        /// <summary>
        /// cleardatagridview;清除内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_New_Click(object sender, EventArgs e)
        {
            btn_Delete.Enabled = false;
            //最后一行默认空行
            int k = this.dataGridView1.Rows.Count - 1;
            if (dataGridView1.Rows.Count > 0)
            {
                //从下往上删，避免沙漏效应
                for (int i = k; i >= 1; i--)
                {
                    this.dataGridView1.Rows.RemoveAt(dataGridView1.Rows[i - 1].Index);
                }
            }
        }
        #endregion

        #endregion

        #region btn_Save_Click(object sender, EventArgs e) :: save;保存修改
        /// <summary>
        /// btn_Save_Click(object sender, EventArgs e)
        /// 当主键重复时update,不重复时insert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            //获取表的主键
            ArrayList primaryKey = new ArrayList();
            primaryKey = GetPrimaryKey(tableName);
            ArrayList keyRows = new ArrayList();
            //是insert还是update,判断主键是否改变了
            //取得表格中主键位置的值
            string modifykey = null;
            foreach (string item in primaryKey)
            {
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    if (dataGridView1.Columns[i].HeaderCell.Value.ToString().Equals(item))
                    {
                        keyRows.Add(i);
                        modifykey = dataGridView1.Rows[0].Cells[item].Value.ToString();
                    }
                }
            }
            //取得了现在单元格中主键的值modifykey,现在判断表中是否有这条主键的值
            
            Boolean isinsert= JudgeKeyExist(modifykey);
            if (isinsert)
            {
                //主键没有重复时插入操作,提示用户
                MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                //"确定要退出吗？"是对话框的显示信息，"退出系统"是对话框的标题
                //默认情况下，如MessageBox.Show("确定要退出吗？")只显示一个“确定”按钮。
                DialogResult dr = MessageBox.Show("主键不存在,插入数据!", "提示", messButton);
                if (dr == DialogResult.OK)//如果点击“确定”按钮
                {
                    //现在判断主键是否自增
                    Boolean isauto = false;
                    primaryKeyListAuto.Add("Categories");
                    primaryKeyListAuto.Add("Employees");
                    primaryKeyListAuto.Add("Orders");
                    primaryKeyListAuto.Add("Products");
                    primaryKeyListAuto.Add("Categories");
                    primaryKeyListAuto.Add("Suppliers");
                    foreach (string item in primaryKeyListAuto)
                    {
                        if (tableName.Equals(item))
                        {
                            isauto = true;
                        }
                    }

                    if (isauto)
                    {
                        
                        InsertKeyAutoIncrement();
                        
                    }
                    else
                    {
                       // InsertKeyNotAutoIncrement();
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                //主有重复时更新操作,提示用户
                MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                //"确定要退出吗？"是对话框的显示信息，"退出系统"是对话框的标题
                //默认情况下，如MessageBox.Show("确定要退出吗？")只显示一个“确定”按钮。
                DialogResult dr = MessageBox.Show("主键存在,更新数据!", "提示", messButton);
                if (dr == DialogResult.OK)//如果点击“确定”按钮
                {

                }
            }
        }

        private Boolean JudgeKeyExist(string modifykey)
        {
            
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            string text1 = "select count(*) from Employees where EmployeeID = '" + modifykey + "'";

            string text1_Test = "update Employees set region = where EmployeeID = '" + modifykey + "'";

            cmd1.CommandText = text1;
            cmd1.CommandType = CommandType.Text;

            if (cmd1.ExecuteScalar().Equals(0))
            {

            }

            //if (cmd1.ExecuteReader(). == 0)
            //{
            //    //sdr.Close();
            //    return true;
            //}
            //else
            //{
            //    //sdr.Close();
            //    cmd1.Dispose();
            //    return false;
            //}

            SqlDataReader sdr = cmd1.ExecuteReader();
            sdr.Read();
            if (!sdr.HasRows)
            {
                //sdr.Close();
                return true;
            }
            else
            {
                sdr.Close();
                cmd1.Dispose();
                return false;
            }

        }

        #region  InsertKeyAutoIncrement() :: 主键自增时的插入操作
        /// <summary>
        /// 主键自增时的插入操作
        /// </summary>
        private void InsertKeyAutoIncrement()
        {
            //主键自增时的插入操作
            StringBuilder text = new StringBuilder("insert into " + tableName + " (");
            text.Append(dataGridView1.Columns[1].HeaderCell.Value.ToString());
            for (int i = 2; i < dataGridView1.Columns.Count; i++)
            {
                text.Append("," + dataGridView1.Columns[i].HeaderCell.Value.ToString());
            }
            text.Append(") values (");
            text.Append("'" + dataGridView1.Rows[0].Cells[1].Value.ToString() + "'");
            for (int i = 2; i < dataGridView1.Columns.Count; i++)
            {
                text.Append(",'" + dataGridView1.Rows[0].Cells[i].Value.ToString() + "'");
            }
            text.Append(")");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = text.ToString();
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("成功");
            this.Dispose();
        } 
        #endregion

        #region  InsertKeyAutoIncrement() :: 主键自增时的插入操作
        /// <summary>
        /// 主键自增时的插入操作
        /// </summary>
        private void InsertKeyNotAutoIncrement()
        {
            //主键不是自增时的插入操作
            StringBuilder text = new StringBuilder("insert into " + tableName + " (");
            text.Append(dataGridView1.Columns[0].HeaderCell.Value.ToString());
            for (int i = 1; i < dataGridView1.Columns.Count; i++)
            {
                text.Append("," + dataGridView1.Columns[i].HeaderCell.Value.ToString());
            }
            text.Append(") values (");
            text.Append("'" + dataGridView1.Rows[0].Cells[0].Value.ToString() + "'");
            for (int i = 1; i < dataGridView1.Columns.Count; i++)
            {
                text.Append(",'" + dataGridView1.Rows[0].Cells[i].Value.ToString() + "'");
            }
            text.Append(")");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = text.ToString();
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("成功");
            this.Dispose();
        } 
        #endregion
      
        #region GetPrimaryKey(string tableName, SqlConnection conn) :: GetPrimaryKey;获取主键
        /// <summary>
        /// GetPrimaryKey;获取主键
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="conn"></param>
        /// <returns></returns>
        private ArrayList GetPrimaryKey(string tableName)
        {
            ArrayList list = new ArrayList();
            DataTable dt = new DataTable();
            SqlDataAdapter dataadapter = new SqlDataAdapter();
            SqlCommand cmdd = new SqlCommand("select * from [" + tableName + "]", conn);
            dataadapter.SelectCommand = cmdd;
            dataadapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            dataadapter.Fill(dt);
            DataColumn[] cols;
            cols = dt.PrimaryKey;
            for (int i = 0; i < cols.Length; i++)
            {
                list.Add(cols[i].ColumnName);
            }
            dataadapter.Dispose();
            
            return list;
        }

        #endregion

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            //主键自增时的插入操作
            StringBuilder text = new StringBuilder("insert into " + tableName + " (");
            text.Append(dataGridView1.Columns[1].HeaderCell.Value.ToString());
            for (int i = 2; i < dataGridView1.Columns.Count; i++)
            {
                text.Append("," + dataGridView1.Columns[i].HeaderCell.Value.ToString());
            }
            text.Append(") values (");
            text.Append("'" + dataGridView1.Rows[0].Cells[1].Value.ToString() + "'");
            for (int i = 2; i < dataGridView1.Columns.Count; i++)
            {
                text.Append(",'" + dataGridView1.Rows[0].Cells[i].Value.ToString() + "'");
            }
            text.Append(")");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = text.ToString();
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("成功");
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //主键不自增时的插入操作
            StringBuilder text = new StringBuilder("insert into " + tableName + " (");
            text.Append(dataGridView1.Columns[0].HeaderCell.Value.ToString());
            for (int i = 1; i < dataGridView1.Columns.Count; i++)
            {
                text.Append("," + dataGridView1.Columns[i].HeaderCell.Value.ToString());
            }
            text.Append(") values (");
            text.Append("'" + dataGridView1.Rows[0].Cells[0].Value.ToString() + "'");
            for (int i = 1; i < dataGridView1.Columns.Count; i++)
            {
                text.Append(",'" + dataGridView1.Rows[0].Cells[i].Value.ToString() + "'");
            }
            text.Append(")");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = text.ToString();
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("成功");
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //更新操作

        }

        private void ModifyDatabaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.ttt = true;
        }
    }
}