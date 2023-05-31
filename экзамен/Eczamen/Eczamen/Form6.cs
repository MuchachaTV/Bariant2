using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Eczamen
{
    public partial class Form6 : Form
    {
        string conn_string = @"Data Source=LAB206_8;Initial Catalog=Bariant2;Integrated Security=True";
        public Form6()
        {
            InitializeComponent();
        }

        private void skidkaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.skidkaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bariant2DataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bariant2DataSet1.Skidka". При необходимости она может быть перемещена или удалена.
            this.skidkaTableAdapter1.Fill(this.bariant2DataSet1.Skidka);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bariant2DataSet1.Skidka". При необходимости она может быть перемещена или удалена.
            this.skidkaTableAdapter1.Fill(this.bariant2DataSet1.Skidka);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bariant2DataSet.Skidka". При необходимости она может быть перемещена или удалена.
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql_conn = new SqlConnection(conn_string);
            string sqlquery = "select * from [dbo].[Skidka]";
            sql_conn.Open(); 
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sql_conn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            skidkaDataGridView.DataSource = dt;
            sql_conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sql_conn = new SqlConnection(conn_string);
            string sqlquery = "select * from [dbo].[Skidka] ORDER BY Skidka DESC ";
            sql_conn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sql_conn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            skidkaDataGridView.DataSource = dt;
            sql_conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sql_conn = new SqlConnection(conn_string);
            string sqlquery = "select * from [dbo].[Skidka] ORDER BY Skidka";
            sql_conn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sql_conn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            skidkaDataGridView.DataSource = dt;
            sql_conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
