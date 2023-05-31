﻿using System;
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
    public partial class Form5 : Form
    {
        string conn_string = @"Data Source=LAB206_8;Initial Catalog=Bariant2;Integrated Security=True";
        public Form5()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sql_conn = new SqlConnection(conn_string);
            string sqlquery = "select * from [dbo].[Flover] ORDER BY Stoimost DESC ";
            sql_conn.Open(); 
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sql_conn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            floverDataGridView.DataSource = dt;
            sql_conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            SqlConnection sql_conn = new SqlConnection(conn_string);
            string sqlquery = "select * from [dbo].[Flover]";
            sql_conn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sql_conn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            floverDataGridView.DataSource = dt;
            sql_conn.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bariant2DataSet1.Flover". При необходимости она может быть перемещена или удалена.
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bariant2DataSet.Flover". При необходимости она может быть перемещена или удалена.
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sql_conn = new SqlConnection(conn_string);
            string sqlquery = "select * from [dbo].[Flover] where Stoimost Like '" + textBox1.Text + "%'";
            sql_conn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sql_conn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            floverDataGridView.DataSource = dt;
            sql_conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sql_conn = new SqlConnection(conn_string);
            string sqlquery = "select * from [dbo].[Flover] ORDER BY Stoimost";
            sql_conn.Open(); 
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sql_conn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            floverDataGridView.DataSource = dt;
            sql_conn.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sql_conn = new SqlConnection(conn_string);
            string sqlquery = "select * from [dbo].[Flover] where Name Like '" + textBox2.Text + "%'";
            sql_conn.Open(); 
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sql_conn);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            floverDataGridView.DataSource = dt;
            sql_conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
