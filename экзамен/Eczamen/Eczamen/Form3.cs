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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAB206_8;Initial Catalog=Bariant2;Integrated Security=True");
            try
            {
                string comand = string.Format("SELECT * FROM Menedger WHERE Login = '" + textBox1.Text
                + "' AND Password = '" + textBox2.Text + "';");
                SqlCommand cheak = new SqlCommand(comand, con);
                con.Open();

                if (cheak.ExecuteScalar() != null)
                {
                    MessageBox.Show("Добро пожаловать в систему");
                    Form2.ActiveForm.Hide();
                    Form6 f = new Form6();
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
    }
}
