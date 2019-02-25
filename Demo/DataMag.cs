using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using static Demo.Program;

namespace Demo
{
    public partial class DataMag : Form
    {
        public Form MainForm;
        MySqlConnection con;

        public DataMag()
        {
            InitializeComponent();
        }

        public DataMag(Form form)
        {
            InitializeComponent();
            MainForm = form;
        }

        private void DataMag_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MainForm != null)
                MainForm.Show();
        }

        private void link_button_Click(object sender, EventArgs e)
        {
            if (basename.Text == "" || tablename.Text == "" || adminname.Text == "" || adminpass.Text == "" || baseadd.Text == "")
                MessageBox.Show("请检查输入信息","错误");
            else
            {
                DataBaseInfo.DatabaseName = basename.Text.Trim();
                DataBaseInfo.TableName = tablename.Text.Trim();
                DataBaseInfo.AdminName = adminname.Text.Trim();
                DataBaseInfo.AdminPass = adminpass.Text.Trim();
                DataBaseInfo.ServerAdd = baseadd.Text.Trim();

                try
                {
                    con = new MySqlConnection("server=" + baseadd.Text.Trim() + ";database=" + basename.Text.Trim() + ";uid=" + adminname.Text.Trim()
                + ";pwd=" + adminpass.Text.Trim());
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        DataGrid dag = new DataGrid(con);
                        dag.Show();
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void basename_Enter(object sender, EventArgs e)
        {
            basename.Text = "";
            basename.ForeColor = Color.Black;
        }

        private void tablename_Enter(object sender, EventArgs e)
        {
            tablename.Text = "";
            tablename.ForeColor = Color.Black;
        }

        private void baseadd_Enter(object sender, EventArgs e)
        {
            baseadd.Text = "";
            baseadd.ForeColor = Color.Black;
        }
    }
}
