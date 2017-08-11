using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            string[] a = {  "\r\n" };
            string[] b= this.TextBox1.Text.ToString().Split(a,StringSplitOptions.None);

            
            string sql;
            sql = "";

            string varname;

            if (this.textBox3.Text.ToString().Length==0)
            {
                sql = "StringBuilder cmd=new StringBuilder(); \r\n" +
                     "cmd.Clear(); \r\n";
                varname = "cmd";
            }
            else
            {
                sql = "StringBuilder "+this.textBox3.Text.Trim()+" =new StringBuilder(); \r\n" +
                    this.textBox3.Text.Trim()+".Clear(); \r\n";

                varname = this.textBox3.Text.Trim();
            }

            varname=varname + ".AppendLine(";

            foreach (string s in b)
            {
                sql =sql+ varname + "\" " + s + " \");\r\n";
            }

            this.TextBox2.Text = sql;
        }
    }
}
