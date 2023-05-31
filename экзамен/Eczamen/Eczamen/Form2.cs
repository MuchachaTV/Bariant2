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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAB206_8;Initial Catalog=Bariant2;Integrated Security=True");
            try
            {
                string comand = string.Format("SELECT * FROM Client WHERE Login = '" + textBox1.Text
                + "' AND Password = '" + textBox2.Text + "';");
                SqlCommand cheak = new SqlCommand(comand, con);
                con.Open();

                if (cheak.ExecuteScalar() != null)
                {
                    MessageBox.Show("Добро пожаловать в систему");
                    Form2.ActiveForm.Hide();
                    Form5 f = new Form5();
                    f.ShowDialog();
                    Close();
                }

                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
            finally { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
