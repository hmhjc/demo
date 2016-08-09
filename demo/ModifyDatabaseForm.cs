﻿using System;
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
        SqlConnection conn;
        ModifyDatabaseForm mdf;
        #endregion
        public ModifyDatabaseForm(string tableName, string keyName, string keystr, SqlConnection conn)
        {
            InitializeComponent();
            this.tableName = tableName;
            this.keyName = keyName;
            this.keystr = keystr;
            this.conn = conn;
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
            SqlDataAdapter sda = new SqlDataAdapter("select * from " + tableName + " where " + keyName + " = '" + keystr + "'", conn);
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
            int k = this.dataGridView1.Rows.Count -1;
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
            primaryKey = GetPrimaryKey(tableName, conn);
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
        #region GetPrimaryKey(string tableName, SqlConnection conn) :: GetPrimaryKey;获取主键
        /// <summary>
        /// GetPrimaryKey;获取主键
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="conn"></param>
        /// <returns></returns>
        private ArrayList GetPrimaryKey(string tableName, SqlConnection conn)
        {
            ArrayList list = new ArrayList();
            DataTable dt = new DataTable();
            SqlDataAdapter dataadapter = new SqlDataAdapter();
            SqlCommand cmdd = new SqlCommand("select * from " + tableName, conn);
            dataadapter.SelectCommand = cmdd;
            dataadapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            dataadapter.Fill(dt);
            DataColumn[] cols;
            cols = dt.PrimaryKey;
            for (int i = 0; i < cols.Length; i++)
            {
                list.Add(cols[i].ColumnName);
            }
            return list;
        }

        #endregion       
        #endregion
    }
}
