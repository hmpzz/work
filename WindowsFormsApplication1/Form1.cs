using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Helper;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Button1_Click(object sender, EventArgs e)
        {


            
            string sql;
            sql = "";

            string varname;

            //生成VB的SQL代码
            if (this.RadioButton1.Checked)
            {
                if (this.textBox3.Text.ToString().Length == 0)
                {
                    varname = "sql";
                }
                else
                {
                    varname = this.textBox3.Text.Trim();
                }

                sql =  varname + "=";




                this.TextBox2.Text =sql+" \""+ this.TextBox1.Text.Replace("\r\n", " \" & vbcrlf & _ \r\n \"") +"\"";
            }
            else if (this.RadioButton2.Checked) //生成C#的SQL代码
            
            {
                if (this.textBox3.Text.ToString().Length == 0)
                {
                    sql = "StringBuilder cmd=new StringBuilder(); \r\n" +
                         "cmd.Clear(); \r\n";
                    varname = "cmd";
                }
                else
                {
                    sql = "StringBuilder " + this.textBox3.Text.Trim() + " =new StringBuilder(); \r\n" +
                        this.textBox3.Text.Trim() + ".Clear(); \r\n";

                    varname = this.textBox3.Text.Trim();
                }

                varname = varname + ".AppendLine( \" ";




                this.TextBox2.Text = sql + varname + this.TextBox1.Text.Replace("\r\n", " \" );  \r\n" + varname)+" \" );";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //连接到数据库


            SqlConnection sqlcon = new SqlConnection();
            SqlCommand sqlcmd = new SqlCommand();
            SqlDataAdapter sqlda = new SqlDataAdapter();

            




            DataTable dt = new DataTable();

            string sql;

            //数据库连接的参数
            List<string> DataBaseParameter=new List<string>();

            DataBaseParameter = GetDataBasePara();

            try
            {
                sqlcon =Model1.Getconn(DataBaseParameter);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return;
            }

            
            


            //如果连接成功就把新参数写入APP.CONFIG
            config.UpdateAppConfig("server", this.TextBox4.Text.Trim());
            config.UpdateAppConfig("database", this.TextBox5.Text.Trim());
            config.UpdateAppConfig("userid", this.textBox10.Text.Trim());
            config.UpdateAppConfig("password", Helper.Security.EncryptDES(this.textBox9.Text.Trim()));



            //SqlTransaction sqltran = sqlcon.BeginTransaction();
            sqlcmd.Connection = sqlcon;
            //sqlcmd.Transaction = sqltran;



            try
            {
                sql = "select name from sys.objects where type='U' order by name";

                sqlcmd.CommandText = sql;
                sqlda.SelectCommand = sqlcmd;

                sqlda.Fill(dt);

                //sqltran.Commit();
            }
            catch (Exception)
            {
                //sqltran.Rollback();
                throw;
            }
            


            this.ComboBox1.Items.Clear();
            
            //将所连接的数据库的表名显示到列表里
            foreach (DataRow dr in dt.Rows)
            {
                this.ComboBox1.Items.Add(dr["name"]);
            }

            this.ComboBox1.SelectedIndex = 0;
        

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //从配置文件里读取上次的连接数据库的各种参数
            this.TextBox4.Text = config.GetAppConfig("server");
            this.TextBox5.Text = config.GetAppConfig("database");
            this.textBox10.Text = config.GetAppConfig("userid");
            this.textBox9.Text = Helper.Security.DecryptDES( config.GetAppConfig("password"));
        }


      

        private void Button2_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();

            if (this.ComboBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("还没有选择表呢！");
                return;
            }

            //得到满足界面上选择条件的表
            dt = GetDataTable();

            string sqlnow="";

            string sqlsum="";

            string[] colname = this.TextBox6.Text.Trim().Split(new char[] { ','});

            //生成SQL
            foreach (DataRow dr in dt.Rows)
            {
                sqlnow = "insert into " + this.ComboBox1.Text.Trim() + " ( " + this.TextBox6.Text.Trim() + " ) values ( ";

                foreach (string colname1 in colname)
                {
                    sqlnow = sqlnow + "'"+ dr[colname1].ToString() +"',";
                }

                sqlsum = sqlsum + sqlnow.Substring(0,sqlnow.Length-1)+") \r\n";
            }


            this.textBox8.Text = sqlsum;



        }

        /// <summary>
        /// 将界面上的数据库连接参数汇总成一个List
        /// </summary>
        /// <returns>汇总完的List</returns>
        private List<string> GetDataBasePara()
        {
            List<string> DataBaseParameter = new List<string>();
            //sqlcon = Model1.Getconn(this.TextBox4.Text.Trim(), this.TextBox5.Text.Trim(), this.textBox10.Text.Trim(), this.textBox9.Text.Trim());
            DataBaseParameter.Add(this.TextBox4.Text.Trim());
            DataBaseParameter.Add(this.TextBox5.Text.Trim());
            DataBaseParameter.Add(this.textBox10.Text.Trim());
            DataBaseParameter.Add(this.textBox9.Text.Trim());

            return DataBaseParameter;

        }

        /// <summary>
        /// 取出满足条件的DataTable
        /// </summary>
        /// <returns>需要返回的DataTable</returns>
        /// 
        private DataTable GetDataTable()
        {
            SqlConnection sqlcon = new SqlConnection();
            SqlCommand sqlcmd = new SqlCommand();
            SqlDataAdapter sqlda = new SqlDataAdapter();

            DataTable dt = new DataTable();

            List<string> DataBaseParameter = new List<string>();


            DataBaseParameter = GetDataBasePara();

            sqlcon = Model1.Getconn(DataBaseParameter);
            sqlcmd.Connection = sqlcon;

        

            if (this.TextBox6.Text.Trim().Length == 0)
            {

                List<string> ColName = new List<string>();
                //得到所选表名的List
                ColName = Model1.getSqlColumnName(this.ComboBox1.Text, sqlcon);

                string s;
                s = "";
                foreach (string colnamestring in ColName)
                {
                    s = s + colnamestring + ",";
                }

                this.TextBox6.Text = s.Substring(0, s.Length - 1);

            }

            string sql;


            //where条件
            string requirement;
            requirement = "";
            if (this.TextBox7.Text.Trim().Length > 0)
            {
                requirement = " where " + this.TextBox7.Text.Trim();
            }


            //是否是只生成一行
            string top;
            top = "";
            if (this.CheckBox1.Checked)
            {
                top = " top 1 ";
            }


            //生成完整SQL
            sql = "select " + top + this.TextBox6.Text.Trim() + " from " + this.ComboBox1.Text.Trim() + requirement;

            sqlcmd.CommandText = sql;
            sqlda.SelectCommand = sqlcmd;

            sqlda.Fill(dt);

            return dt;
        }




        private void Button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            if (this.ComboBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("还没有选择表呢！");
                return;
            }

            //得到满足界面上选择条件的表
            dt = GetDataTable();
            string s;
            if (this.checkBox2.Checked)
            {
                s = Helper.JsonHelper.SerializeObject(dt, Newtonsoft.Json.NullValueHandling.Ignore);
            }
            else
            {
                s = Helper.JsonHelper.SerializeObject(dt, Newtonsoft.Json.NullValueHandling.Include);
            }
            

            this.textBox8.Text = s;
        }
    }

    internal static class Model1
    {
        public static SqlConnection Getconn(string Server,string Database,string UserID,string PassWord)
        {
            SqlConnection sqlcon1 = new SqlConnection();
            sqlcon1.ConnectionString = "Server=" + Server + ";Database=" + Database + ";user id=" + UserID + ";password=" + PassWord;
            sqlcon1.Open();
            return sqlcon1;
        }

        public static SqlConnection Getconn(List<string> DataBasePara)
        {
            SqlConnection sqlcon1 = new SqlConnection();
            sqlcon1.ConnectionString = "Server=" + DataBasePara[0] + ";Database=" + DataBasePara[1] + ";user id=" + DataBasePara[2] + ";password=" + DataBasePara[3];
            sqlcon1.Open();
            return sqlcon1;
        }


        /// <summary>
        /// 取得表里的所有的字段名
        /// </summary>
        /// <param name="TableName">表名</param>
        /// <param name="conn">数据库连接</param>
        /// <returns>包含表名的List</returns>
        public static  List<string> getSqlColumnName(string TableName,SqlConnection conn)
        {
            List<string> columnName = new List<string>();
            string sql = "select name from syscolumns where id = object_id('"+TableName+ "') order by colid";

            try
            {
                
                SqlCommand com = new SqlCommand(sql, conn);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    columnName.Add(dr[0].ToString());
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception e)
            {

            }

            return columnName;
        }
    }


}
