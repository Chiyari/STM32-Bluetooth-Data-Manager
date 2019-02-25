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
    public partial class DataGrid : Form
    {
        public Form DataForm;

        MySqlConnection conn;
        MySqlDataAdapter sda;
        DataSet ds = null;

        public DataGrid(MySqlConnection con)
        {
            InitializeComponent();
            conn = con;
        }

        private void DataGrid_Load(object sender, EventArgs e)
        {
            sda = new MySqlDataAdapter("select * from " + DataBaseInfo.TableName.Trim(), conn);
            ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
