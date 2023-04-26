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
    public partial class Form1 : Form
    {
        public static string user="";
        public Form1()
        {
            InitializeComponent();
        }

 
        private void button2_Click(object sender, EventArgs e)
        {
           
                    

            try
            {
                if (!(textBox1.Text == string.Empty))
                {
                    if (!(textBox2.Text == string.Empty))
                    {

                        String str = "server=localhost;port = 3306; database = bd;UID = root;password = qwerty";
                        String query = "select * from users where email = '" + textBox1.Text + "'and password = '" + textBox2.Text + "'";
                        user = textBox1.Text;
                        MySqlConnection con = new MySqlConnection(str);
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        MySqlDataReader dbr;
                        con.Open();
                        dbr = cmd.ExecuteReader();
                        int count = 0;
                        while (dbr.Read())
                        {
                            count = count + 1;
                        }
                        if (count == 1)
                        {
                            this.Hide();
                            Form3 f3 = new Form3(); //this is the change, code for redirect  
                            f3.adaugareIstoric(user,"logare") ;
                            f3.ShowDialog();
                        }
                        else if (count > 1)
                        {
                            MessageBox.Show("Duplicate username and password", "login page");
                        }
                        else
                        {
                            MessageBox.Show(" username and password incorrect", "login page");
                        }
                    }
                    else
                    {
                        MessageBox.Show(" password empty", "login page");
                    }
                }
                else
                {
                    MessageBox.Show(" username empty", "login page");
                }
                // con.Close();  
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

         
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2(); //this is the change, code for redirect  
            f2.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

       
    }
    

