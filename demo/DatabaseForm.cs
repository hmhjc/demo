using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace demo
{
    public partial class DatabaseForm : Form
    {
        #region ★　Var
        //存储数据库名
        string datebaseName = null;
        //存储表名
        string tableName = null;
        //存储主键的名字
        string keyName;
        //存储主键
        string keystr;
        //表主键名字的集合
        List<string> primaryKeyName = new List<string>();
        //表主键值的集合
        List<string> primaryKeyData = new List<string>();
        SqlConnection conn;
        //存储数据库名
        ArrayList datebaseNameList;
        //存储表名
        ArrayList tableNameList;
        #endregion
        public DatabaseForm()
        {
            InitializeComponent();
        }

        #region ★　Event

        #region btn_StringConnect_Click(object sender, EventArgs e) :: DB Connect String;输入连接字符串连接
        /// <summary>
        /// DB Connect String ;输入连接字符串连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_StringConnect_Click(object sender, EventArgs e)
        {
            string dbConnectString;
            dbConnectString = txt_DB_Connect_String.Text.ToString();
            //server=.;database=databasename;uid=sa;pwd=micube2016
            char[] separator = { ';', '=' };
            string[] splitstrings = new string[100];
            splitstrings = dbConnectString.Split(separator);
            ConnectDatebase(splitstrings[3]);
        }
        #endregion

        #region btn_Connect_Click(object sender, EventArgs e) :: btn_Connect_Click(object sender, EventArgs e);连接数据库按钮操作
        /// <summary>
        /// btn_Connect_Click(object sender, EventArgs e);连接数据库按钮操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            //取得下拉框中的数据库名
            //   dataGridView1.Rows.Clear();
            datebaseName = txt_DatabaseName.Text.ToString();
            ConnectDatebase(datebaseName);
        }
        #endregion

        #region btn_Select_Click(object sender, EventArgs e) :: show Database Button;显示数据库的按钮
        /// <summary>
        /// show Database Button;显示数据库的按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Select_Click(object sender, EventArgs e)
        {
            //取得下拉框中的数据库名
            tableName = txt_TableName.Text.ToString();
            //取得数据库的主键名的集合
            primaryKeyName = GetPrimaryKey(tableName);
            ShowDatebase(tableName);
        }
        #endregion

        #region cmb_TableName_SelectedIndexChanged(object sender, EventArgs e) :: put TableName into TextBox ;把数据库名放到 TextBox中
        /// <summary>
        /// put TableName into TextBox ;把数据库名放到 TextBox中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_TableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_TableName.Text = cmb_TableName.Text.ToString();
        }
        #endregion

        #region cmb_DatabaseName_SelectedIndexChanged(object sender, EventArgs e) :: put DatabaseName into TextBox ;把数据库名放到 TextBox中
        /// <summary>
        /// put DatabaseName into TextBox ;把数据库名放到 TextBox中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_DatabaseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_DatabaseName.Text = cmb_DatabaseName.Text.ToString();
        }
        #endregion

        #region dataGridView1_DoubleClick(object sender, EventArgs e) :: dataGridView1_DoubleClick;双击dataGridView事件
        /// <summary>
        /// dataGridView1_DoubleClick;双击dataGridView事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
            ModifyDatabaseForm mdf = new ModifyDatabaseForm(tableName, primaryKeyName, primaryKeyData, conn);
            mdf.ShowDialog();
            btn_Select_Click(null, null);
        }
        #endregion

        #region GetData() :: GetData();获取选中行的数据
        /// <summary>
        /// GetData();获取选中行的数据
        /// </summary>
        private void GetData()
        {

        }
        #endregion

        #region dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) :: dataGridView1_CellClick;选中时给要传递的变量赋值
        /// <summary>
        /// dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //取得数据库的主键名的集合
            primaryKeyName = GetPrimaryKey(tableName);
            //遍历表格,定位到选中的那行
            primaryKeyData.Clear();
            foreach (string item in primaryKeyName)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Selected == true)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            if (dataGridView1.Columns[j].HeaderCell.Value.ToString().Equals(item))
                            {
                            primaryKeyData.Add(dataGridView1.Rows[i].Cells[j].Value.ToString());
                            }
                        }
                    }
                }
            }
            //string[] str = new string[dataGridView1.Columns.Count];
            ////获取主键的名字
            //keyName = dataGridView1.Columns[0].HeaderCell.Value.ToString();

            ////遍历表格,定位到选中的那行
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    if (dataGridView1.Rows[i].Selected == true)
            //    {
            //        for (int j = 0; j < dataGridView1.Columns.Count; j++)
            //        {
            //            str[j] = dataGridView1.Rows[i].Cells[j].Value.ToString();
            //        }
            //    }
            //}
            //keystr = str[0];
        }
        #endregion

        #endregion

        #region ★　Function

        #region DatabaseForm_Load(object sender, EventArgs e) :: DatabaseForm_Load(object sender, EventArgs e);初始化操作,把数据库的名字放在下拉框中
        /// <summary>
        /// DatabaseForm_Load(object sender, EventArgs e);初始化操作,把数据库的名字放在下拉框中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DatabaseForm_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            Init();
        }

        #endregion

        #region Init() :: Init():把数据库的名字放到DatabaseName下拉选择框中
        /// <summary>
        /// Init():把数据库的名字放到DatabaseName下拉选择框中
        /// </summary>
        private void Init()
        {
            //声明一个字符串，用来储存连接数据库的字符串
            string ConStr = "server=.;database=master;uid=sa;pwd=micube2016";
            //创建一个SqlConnection对象
            SqlConnection sconn = new SqlConnection(ConStr);
            //打开连接
            sconn.Open();
            //创建一个SqlCommand对象
            SqlCommand cmd = new SqlCommand();
            //设置Connect属性,指定其使用conn连接数据库
            cmd.Connection = sconn;
            //设定CommandText属性,以及其执行的SQL语句
            cmd.CommandText = "SELECT Name FROM Master..SysDatabases ORDER BY Name";
            //设置CommandType属性为Text,使其只执行SQL语句文本形式
            cmd.CommandType = CommandType.Text;
            //使用ExecuteReader方法实例化一个SqlDataReader对象
            SqlDataReader sdr = cmd.ExecuteReader();
            datebaseNameList = new ArrayList();
            while (sdr.Read())
            {
                datebaseNameList.Add(sdr[0].ToString());
                cmb_DatabaseName.Items.Add(sdr[0].ToString());
            }
            sdr.Close();
            sconn.Close();
        }
        #endregion

        #region ConnectDatebase(string datebaseName) :: Connect Datebase and put table name into ComboBox;连接数据库并把数据库中的表名放到下面的下拉框中
        /// <summary>
        /// Connect Datebase and put table name into ComboBox;连接数据库并把数据库中的表名放到下面的下拉框中
        /// </summary>
        /// <param name="datebaseName"></param>
        private void ConnectDatebase(string datebaseName)
        {
            //判断数据库的名字是否存在
            Boolean flag = false;
            foreach (string str in datebaseNameList)
            {
                if (str.Equals(datebaseName))
                {
                    flag = true;
                }
            }
            if (flag)
            {
                cmb_TableName.Items.Clear();
                string ConStr = "server=.;database=" + datebaseName + ";uid=sa;pwd=micube2016";
                //创建一个SqlConnection对象
                conn = new SqlConnection(ConStr);
                //打开连接
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    lbl_isconnected.Text = "success";
                }
                else
                {
                    return;
                }
                //创建一个SqlCommand对象
                SqlCommand cmd = new SqlCommand();
                //设置Connect属性,指定其使用conn连接数据库
                cmd.Connection = conn;
                //设定CommandText属性,以及其执行的SQL语句
                cmd.CommandText = "SELECT Name FROM SysObjects Where XType='U' ORDER BY Name";
                //设置CommandType属性为Text,使其只执行SQL语句文本形式
                cmd.CommandType = CommandType.Text;
                //使用ExecuteReader方法实例化一个SqlDataReader对象
                SqlDataReader sdr = cmd.ExecuteReader();
                tableNameList = new ArrayList();
                while (sdr.Read())
                {
                    tableNameList.Add(sdr[0].ToString());
                    cmb_TableName.Items.Add(sdr[0].ToString());
                }
                sdr.Close();
            }
            else
            {
                lbl_isconnected.Text = "fail";
                MessageBox.Show("数据库名错误");
            }
        }
        #endregion

        #region ShowDatebase(string datebaseName) :: ShowDatebase(string datebaseName);显示数据库中的内容到GridView
        /// <summary>
        /// ShowDatebase(string datebaseName);显示数据库中的内容到GridView
        /// </summary>
        /// <param name="datebaseName"></param>
        private void ShowDatebase(string tableName)
        {
            //判断数据库的名字是否存在
            Boolean flag = false;
            foreach (string str in tableNameList)
            {
                if (str.Equals(tableName))
                {
                    flag = true;
                }
            }
            if (flag)
            {
                //创建SqlDataAdapter对象,conn用上面实例化好的
                SqlDataAdapter sda = new SqlDataAdapter("select * from [" + tableName+"]", conn);
                //创建一个DataSet对象
                DataSet ds = new DataSet();
                //使用SqlDataAdapter对象的Fill方法填充DataSet
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("表名错误");
            }
        }

        #endregion

        #region GetPrimaryKey(string tableName, SqlConnection conn) :: GetPrimaryKey;获取主键
        /// <summary>
        /// GetPrimaryKey;获取主键
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="conn"></param>
        /// <returns></returns>
        private List<string> GetPrimaryKey(string tableName)
        {
            List<string> list = new List<string>();
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

    }
}
