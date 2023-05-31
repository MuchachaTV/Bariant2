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
    public partial class Form7 : Form
    {
        string conn_string = @"Data Source=LAB206_8;Initial Catalog=Bariant2;Integrated Security=True";
        public Form7()
        {
            InitializeComponent();
        }

        private void postavkiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.postavkiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bariant2DataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bariant2DataSet1.Postavki". При необходимости она может быть перемещена или удалена.
            this.postavkiTableAdapter1.Fill(this.bariant2DataSet1.Postavki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bariant2DataSet.Postavki". При необходимости она может быть перемещена или удалена.
            

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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sql_conn = new SqlConnection(conn_string);
            string sqlquery = "select * from [dbo].[Postavki] ORDER BY Catalog_tovarov";
            sql_conn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sql_conn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            postavkiDataGridView.DataSource = dt;
            sql_conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection sql_conn = new SqlConnection(conn_string);
            string sqlquery = "select * from [dbo].[Postavki]";
            sql_conn.Open(); 
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sql_conn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            postavkiDataGridView.DataSource = dt;
            sql_conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sql_conn = new SqlConnection(conn_string);
            string sqlquery = "select * from [dbo].[Postavki] ORDER BY Catalog_tovarov DESC ";
            sql_conn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sql_conn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            postavkiDataGridView.DataSource = dt;
            sql_conn.Close();
        }
    }
}
