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

        public ModifyDatabaseForm(string tableName, List<string> primaryKeyName, List<string> primaryKeyData, SqlConnection conn)
        {
            InitializeComponent();
            this.tableName = tableName;
            this.primaryKeyName = primaryKeyName;
            this.primaryKeyData = primaryKeyData;
            this.conn = conn;
            this.ttt = false;
        }
      
        #region ★　Var
        string tableName;
        public bool ttt = false;
        SqlConnection conn;
        ArrayList primaryKeyListAuto = new ArrayList();
        //表主键名字的集合
        List<string> primaryKeyName = new List<string>();
        //表主键值的集合
        List<string> primaryKeyData = new List<string>();
        //合法的插入key值
        string key = null;
        #endregion

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
            StringBuilder showText = new StringBuilder("select * from [" + tableName + "] where ");
            if (primaryKeyName.Count > 1)
            {
                for (int i = 0; i < primaryKeyName.Count - 1; i++)
                {
                    showText.Append(primaryKeyName[i] + "='" + primaryKeyData[i] + "'and");
                }
                showText.Append(primaryKeyName[primaryKeyName.Count - 1] + "='" + primaryKeyData[primaryKeyData.Count - 1] + "'");
            }
            else
            {
                showText.Append(primaryKeyName[0] + "='" + primaryKeyData[0] + "'");
            }

            SqlDataAdapter sda = new SqlDataAdapter(showText.ToString(), conn);
            // SqlDataAdapter sda = new SqlDataAdapter("select * from Employees where EmployeeID = 4", conn);
            //创建一个DataSet对象
            DataSet ds = new DataSet();
            //使用SqlDataAdapter对象的Fill方法填充DataSet
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        #endregion

        #region JudgeKeyExist(List<string> modifykey, List<string> primaryKey) :: JudgeKeyExist(List<string> modifykey, List<string> primaryKey);根据表格中主键的值判断表中是否有这条主键的数据
        /// <summary>
        /// JudgeKeyExist(List<string> modifykey, List<string> primaryKey);根据表格中主键的值判断表中是否有这条主键的数据
        /// </summary>
        /// <param name="modifykey"></param>
        /// <param name="primaryKeyName"></param>
        /// <returns></returns>
        private Boolean JudgeKeyExist(List<string> modifykey, List<string> primaryKeyName)
        {
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            StringBuilder text1 = new StringBuilder("select count(*) from " + tableName + " where ");
            if (primaryKeyName.Count > 1)
            {
                for (int i = 0; i < primaryKeyName.Count - 1; i++)
                {
                    text1.Append(primaryKeyName[i] + "='" + modifykey[i] + "'and");
                }
                text1.Append(primaryKeyName[primaryKeyName.Count - 1] + "='" + modifykey[modifykey.Count - 1] + "'");
            }
            else
            {
                text1.Append(primaryKeyName[0] + "='" + modifykey[0] + "'");
            }

            cmd1.CommandText = text1.ToString();
            cmd1.CommandType = CommandType.Text;

            if (cmd1.ExecuteScalar().Equals(0))
            {
                //说明主键为modifykey的数据不存在
                return true;
            }
            else
            {
                return false;
            }
            //SqlDataReader sdr = cmd1.ExecuteReader();
            //sdr.Read();
            //if (!sdr.HasRows)
            //{
            //    sdr.Close();
            //    cmd1.Dispose();
            //    return true;
            //}
            //else
            //{
            //    sdr.Close();
            //    cmd1.Dispose();
            //    return false;
            //}
        }
        #endregion

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
      
        #region JudgeKeyLegal(List<string> modifykey) :: JudgeKeyLegal(List<string> modifykey);通过传入的主键单元格中的值判断主键合不合法
        /// <summary>
        /// JudgeKeyLegal(List<string> modifykey);通过传入的主键单元格中的值判断主键合不合法
        /// </summary>
        /// <param name="modifykey"></param>
        /// <returns></returns>
        private bool JudgeKeyLegal(List<string> modifykey)
        {
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            StringBuilder text1 = new StringBuilder("select ident_current('" + tableName + "')+1");
            cmd1.CommandText = text1.ToString();
            cmd1.CommandType = CommandType.Text;
            key = cmd1.ExecuteScalar().ToString();
            if (key.Equals(modifykey[0]))
            {
                //说明主键是合法的
                return true;
            }
            else
            {
                return false;
            }
        } 
        #endregion

        #region UpdataData() :: UpdataData();更新操作
        /// <summary>
        /// UpdataData();更新操作
        /// </summary>
        private void UpdataData()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            StringBuilder UpdateText = new StringBuilder("update " + tableName + " set ");
            if (dataGridView1.Columns.Count > 1)
            {
                for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                {
                    foreach (string item in primaryKeyName)
                    {
                        if (dataGridView1.Columns[j].HeaderCell.Value.ToString().Equals(item))
                        {
                        }
                        else
                        {
                            UpdateText.Append(dataGridView1.Columns[j].HeaderCell.Value.ToString() + " = '");
                            UpdateText.Append(dataGridView1.Rows[0].Cells[j].Value.ToString() + "',");
                        }
                    }
                }
            }
            UpdateText.Append(dataGridView1.Columns[dataGridView1.Columns.Count - 1].HeaderCell.Value.ToString() + " = '");
            UpdateText.Append(dataGridView1.Rows[0].Cells[dataGridView1.Columns.Count - 1].Value.ToString() + "'");

            UpdateText.Append(" where ");
            if (primaryKeyName.Count > 1)
            {
                for (int i = 0; i < primaryKeyName.Count - 1; i++)
                {
                    UpdateText.Append(primaryKeyName[i] + "='" + primaryKeyData[i] + "'and");
                }
                UpdateText.Append(primaryKeyName[primaryKeyName.Count - 1] + "='" + primaryKeyData[primaryKeyData.Count - 1] + "'");
            }
            else
            {
                UpdateText.Append(primaryKeyName[0] + "='" + primaryKeyData[0] + "'");
            }
            cmd.CommandText = UpdateText.ToString();
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
            MessageBox.Show("更新成功");
            this.Dispose();

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
            StringBuilder deleteText = new StringBuilder("delete from " + tableName + " where ");
            if (primaryKeyName.Count > 1)
            {
                for (int i = 0; i < primaryKeyName.Count - 1; i++)
                {
                    deleteText.Append(primaryKeyName[i] + "='" + primaryKeyData[i] + "'and");
                }
                deleteText.Append(primaryKeyName[primaryKeyName.Count - 1] + "='" + primaryKeyData[primaryKeyData.Count - 1] + "'");
            }
            else
            {
                deleteText.Append(primaryKeyName[0] + "='" + primaryKeyData[0] + "'");
            }
            cmd.CommandText = deleteText.ToString();
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
            //是insert还是update,判断主键是否改变了
            //取得表格中主键位置的值
            List<string> modifykey = new List<string>();
            foreach (string item in primaryKeyName)
            {
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    if (dataGridView1.Columns[i].HeaderCell.Value.ToString().Equals(item))
                    {
                        modifykey.Add(dataGridView1.Rows[0].Cells[item].Value.ToString());
                    }
                }
            }
            //取得了现在单元格中主键的值modifykey,现在判断表中是否有这条主键的值

            Boolean isinsert = JudgeKeyExist(modifykey, primaryKeyName);
            if (isinsert)
            {
                //主键没有重复时插入操作,提示用户
                MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
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
                        key = null;
                        Boolean isLegal = JudgeKeyLegal(modifykey);
                        //主键没有重复时插入操作,提示用户
                        if (isLegal)
                        {
                            MessageBoxButtons messButton1 = MessageBoxButtons.OKCancel;
                            DialogResult dr1 = MessageBox.Show("自增主键合法,插入数据!", "提示", messButton);
                            if (dr1 == DialogResult.OK)//如果点击“确定”按钮
                            {
                                InsertKeyAutoIncrement();
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("自增主键的值应该为"+key+"请重新输入合法的主键");
                        }
                       
                    }
                    else
                    {
                        InsertKeyNotAutoIncrement();
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                //主键有重复时更新操作,提示用户
                MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                //"确定要退出吗？"是对话框的显示信息，"退出系统"是对话框的标题
                //默认情况下，如MessageBox.Show("确定要退出吗？")只显示一个“确定”按钮。
                DialogResult dr = MessageBox.Show("主键存在,更新数据!", "提示", messButton);
                if (dr == DialogResult.OK)//如果点击“确定”按钮
                {
                    UpdataData();
                }
            }
        }


        #endregion

        #endregion

    }
}