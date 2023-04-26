using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAOO
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(); //this is the change, code for redirect  
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                String str = "server=localhost;port = 3306; database = bd;UID = root;password = qwerty";
                string query = "insert into users (id,email,rol,password) values('" + this.textBox4.Text + "','" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text +"');";
                MySqlConnection MyConn2 = new MySqlConnection(str);
                MySqlCommand MyCommand2 = new MySqlCommand(query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();    
                MessageBox.Show("Save Data");
                Form3 form3 = new Form3();
                form3.adaugareIstoric(this.textBox1.Text,"creare cont");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
                this.Hide();
                Form1 f1 = new Form1(); //this is the change, code for redirect  
                f1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }






        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
