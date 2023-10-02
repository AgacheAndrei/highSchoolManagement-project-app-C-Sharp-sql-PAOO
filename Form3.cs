using CsvHelper;
using MySqlConnector;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Ubiety.Dns.Core;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Data.OleDb;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace Proiect_PAOO
{


    public partial class Form3 : Form
    {
        public string user = Form1.user;
        public Form3()
        {
            InitializeComponent();
            dateElevi();
            dateBursieri();
            dateBurse();
            dateIstoric();
            
        }

        private void dateElevi()
        {
            try
            {
                String str = "server=localhost;port = 3306; database = bd;UID = root;password = qwerty";

                string Query = "select * from elev ;";
                MySqlConnection MyConn2 = new MySqlConnection(str);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //MyConn2.Open();

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
                dataGridView2.DataSource = dTable;
                dataGridView3.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateBursieri()
        {
            try
            {
                String str = "server=localhost;port = 3306; database = bd;UID = root;password = qwerty";

                string Query = "select * from bursieri ;";
                MySqlConnection MyConn2 = new MySqlConnection(str);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //MyConn2.Open();

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                
                dataGridView4.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dateBurse()
        {
            try
            {
                String str = "server=localhost;port = 3306; database = bd;UID = root;password = qwerty";

                string Query = "select * from tip_bursa ;";
                MySqlConnection MyConn2 = new MySqlConnection(str);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //MyConn2.Open();

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                dataGridView5.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dateIstoric()
        {
            try
            {
                String str = "server=localhost;port = 3306; database = bd;UID = root;password = qwerty";

                string Query = "select * from istoric ;";
                MySqlConnection MyConn2 = new MySqlConnection(str);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //MyConn2.Open();

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView6.DataSource = dTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String str = "server=localhost;port = 3306; database = bd;UID = root;password = qwerty";

                string Query = "select * from elev;";
                MySqlConnection MyConn2 = new MySqlConnection(str);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //MyConn2.Open();

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
                adaugareIstoric(user, "afisare elevi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                String str = "server=localhost;port = 3306; database = bd;UID = root;password = qwerty";
                string query = "insert into elev () values('" + this.numar_matricol_box.Text + "','" + this.cnp_box.Text + "','" + this.nume_box.Text + "','" + this.prenume_box.Text + "','" + this.nr_tel_box.Text + "','" + this.adresa_box.Text + "','" + this.medie_box.Text + "','" + this.acte_aditionale_box.Text + "','" + this.cod_clasa_box.Text + "'); ";
                MySqlConnection MyConn2 = new MySqlConnection(str);
                MySqlCommand MyCommand2 = new MySqlCommand(query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Elevul a fost inserat!");
                while (MyReader2.Read())
                {
                }
                dateElevi();
                adaugareIstoric(user, "inserare elev");
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Elevul nu a fost inserat!");
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                String str = "server=localhost;port = 3306; database = bd;UID = root;password = qwerty";
                string query = "delete from elev where nr_matricol='" + this.textBox12.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(str);
                MySqlCommand MyCommand2 = new MySqlCommand(query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Elevul a fost sters!");
                while (MyReader2.Read())
                {
                }
                dateElevi();
                adaugareIstoric(user, "stergere elev");
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Elevul nu a fost sters!");
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String str = "server=localhost;port = 3306; database = bd;UID = root;password = qwerty";

                string Query = "select * from elev where nr_matricol='" + textBox1.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(str);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //MyConn2.Open();

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
                adaugareIstoric(user, "cautare dupa nr matricol");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void button7_Click(object sender, EventArgs e)
        {
            String str = "server=localhost;port = 3306; database = bd;UID = root;password = qwerty";
            string Query = "select * from elev ";
            if (!(MedieMaiMare.Text == string.Empty))
            {
                Query = Query + " where medie >='" + MedieMaiMare.Text + "'";
                if (!(MedieMaiMica.Text == string.Empty))
                {
                    Query = Query + "and medie <='" + MedieMaiMica.Text + "'";
                }
            }
            else if (!(MedieMaiMica.Text == string.Empty))
            {
                Query = Query + " where medie <='" + MedieMaiMica.Text + "'";
            }

            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                Query = Query + " order by medie asc ";

            }

            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                Query = Query + " order by medie desc ";

            }

            Query = Query + ";";

            MySqlConnection MyConn2 = new MySqlConnection(str);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //MyConn2.Open();

            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dataGridView1.DataSource = dTable;
            adaugareIstoric(user, "filtrare date elevi");

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.tabControl1.SelectTab(tabPage3);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {

                String str = "server=localhost;port = 3306; database = bd;UID = root;password = qwerty";
                string query = "update elev set codclasa='" + this.cod_cla_box_u.Text + "' , CNP='" + this.cnp_box_u.Text + "', nume='" + this.nume_box_u.Text + "', prenume='" + this.prenume_box_u.Text + "', nr_telefon='" + this.nr_tel_box_u.Text + "',adresa='" + this.adresa_box_u.Text + "',medie='" + this.medie_box_u.Text.Replace(',', '.') + "',acte_adi='" + this.acte_adi_box_u.Text + "' where nr_matricol='" + this.nr_matricol_box_u.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(str);
                MySqlCommand MyCommand2 = new MySqlCommand(query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Elevul a fost actualizat!");
                while (MyReader2.Read())
                {
                }
                dateElevi();
                adaugareIstoric(user, "actualizare elev");
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Elevul nu a fost actualizat!");
                MessageBox.Show(ex.Message);
            }
            

        }



        private void Form3_Load(object sender, EventArgs e)
        {


        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                chart1.Series.Clear();
                chart1.Titles.Clear();


                String str = "server=localhost;port = 3306; database = bd;UID = root;password = qwerty";
                MySqlConnection con = new MySqlConnection(str);

                con.Open();

                this.chart1.Titles.Add("Valoarea burselor per clase");
                MySqlCommand command = con.CreateCommand();
                command.CommandText = "SELECT clasa.nume AS 'Nume Clase', SUM(tip_bursa.valoare) AS 'Suma per Clasa' FROM clasa, elev, bursieri, tip_bursa WHERE bursieri.codbur = tip_bursa.codbur AND elev.nr_matricol = bursieri.nr_matricol AND elev.codclasa = clasa.codclasa GROUP BY clasa.nume";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string className = reader.GetString(0);
                    int sum = reader.GetInt32(1);
                    Series series = chart1.Series.Add(className);
                    series.Points.Add(sum);
                }


                adaugareIstoric(user, "chart");
                reader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    filePath = filePath.EndsWith(".xlsx") ? filePath : filePath + ".xlsx";

                    using (var fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    {
                        IWorkbook wb = new XSSFWorkbook();
                        ISheet sheet = wb.CreateSheet("customer");

                        IRow rowCol = sheet.CreateRow(0);
                        for (int i = 0; i < dataGridView1.ColumnCount; i++)
                        {
                            ICell cell = rowCol.CreateCell(i);
                            cell.SetCellValue(dataGridView1.Columns[i].HeaderText);
                        }

                        for (int j = 0; j < dataGridView1.RowCount; j++)
                        {
                            IRow row = sheet.CreateRow(j + 1);
                            for (int k = 0; k < dataGridView1.ColumnCount; k++)
                            {
                                ICell cell = row.CreateCell(k);
                                if (dataGridView1.Rows[j].Cells[k].Value != null)
                                {
                                    cell.SetCellValue(dataGridView1.Rows[j].Cells[k].Value.ToString());
                                }
                            }
                        }

                        wb.Write(fs);
                        wb.Close();
                        fs.Close();
                    }

                    Process.Start(filePath);
                }
                else
                {
                    MessageBox.Show("Eroare salvare fisier excel");
                }
                adaugareIstoric(user, "export data to excel");
            }
            catch (IOException io)
            {
                Console.WriteLine(io.Message);
            }
            /* try
             {
                 // Get the column headers
                 List<string> columnNames = new List<string>();
                 foreach (DataGridViewColumn column in dataGridView1.Columns)
                 {
                     columnNames.Add(column.HeaderText);
                 }

                 // Write the data to a CSV file
                 using (StreamWriter writer = new StreamWriter("datagridview.csv"))
                 {
                     // Write the column headers
                     writer.WriteLine(string.Join(",", columnNames));

                     // Write the rows
                     foreach (DataGridViewRow row in dataGridView1.Rows)
                     {
                         List<string> rowValues = new List<string>();
                         foreach (DataGridViewCell cell in row.Cells)
                         {
                             object value = cell.Value;
                             string stringValue = (value == null || value == DBNull.Value) ? "" : value.ToString();
                             rowValues.Add(stringValue);
                         }
                         writer.WriteLine(string.Join(",", rowValues));
                     }
                 }

                 MessageBox.Show("Export complete!");
             }
             catch (Exception ex)
             {
                 // Handle the exception
                 MessageBox.Show("An error occurred: " + ex.Message);
             }*/


            //export data from a sql command
            /*  try
              {
                  // Open the connection
                  String str = "server=localhost;port = 3306; database = bd;UID = root;password = qwerty";
                  MySqlConnection con = new MySqlConnection(str);

                  con.Open();

                  // Execute the command and read the data
                  MySqlCommand command = con.CreateCommand();
                  command.CommandText = "SELECT * FROM elev";
                  MySqlDataReader reader = command.ExecuteReader();

                  // Get the column names
                  List<string> columnNames = new List<string>();
                  for (int i = 0; i < reader.FieldCount; i++)
                  {
                      columnNames.Add(reader.GetName(i));
                  }

                  // Write the data to a CSV file
                  using (StreamWriter writer = new StreamWriter("elev.csv"))
                  {
                      // Write the column headers
                      writer.WriteLine(string.Join(",", columnNames));

                      // Write the rows
                      while (reader.Read())
                      {
                          List<string> rowValues = new List<string>();
                          for (int i = 0; i < reader.FieldCount; i++)
                          {
                              object value = reader.GetValue(i);
                              string stringValue = (value == null || value == DBNull.Value) ? "" : value.ToString();
                              rowValues.Add(stringValue);
                          }
                          writer.WriteLine(string.Join(",", rowValues));
                      }
                  }

                  MessageBox.Show("Export complete!");
              }
              catch (Exception ex)
              {
                  // Handle the exception
                  MessageBox.Show("An error occurred: " + ex.Message);
              }*/


        }




        private void button10_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1;'";
                OleDbConnection connection = new OleDbConnection(connectionString);
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM [customer$]", connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            adaugareIstoric(user, "import data from excel");

            /* try
             {
                 // Open the CSV file
                 using (StreamReader reader = new StreamReader("datagridview.csv"))
                 {
                     // Read the column headers
                     string[] columnNames = reader.ReadLine().Split(',');

                     // Create the DataTable and add the columns
                     DataTable dataTable = new DataTable();
                     foreach (string columnName in columnNames)
                     {
                         dataTable.Columns.Add(columnName);
                     }

                     // Read the rows
                     while (!reader.EndOfStream)
                     {
                         string[] rowValues = reader.ReadLine().Split(',');

                         // Create a new DataRow and add it to the DataTable
                         DataRow dataRow = dataTable.NewRow();
                         for (int i = 0; i < rowValues.Length; i++)
                         {
                             dataRow[i] = rowValues[i];
                         }
                         dataTable.Rows.Add(dataRow);
                     }

                     // Set the DataTable as the DataGridView's DataSource
                     dataGridView1.DataSource = dataTable;
                 }

                 MessageBox.Show("Import complete!");
             }
             catch (Exception ex)
             {
                 // Handle the exception
                 MessageBox.Show("An error occurred: " + ex.Message);
             }*/

            /* String str = "server=localhost;port = 3306; database = bd;UID = root;password = qwerty";

             MySqlConnection MyConn2 = new MySqlConnection(str);

             OpenFileDialog OpenFileDialog = new OpenFileDialog();
             MyConn2.Open();
             if (OpenFileDialog.ShowDialog() == DialogResult.OK)
             {
                 using (var reader = new StreamReader(OpenFileDialog.FileName))
                 using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                 {
                     var records = csv.GetRecords<Incaltaminte>();

                     foreach (var record in records)
                     {
                         string query = "insert into incaltaminte (categorie,marca,model,gen,culoare,material,marime,pret) values('" + record.categorie + "','" + record.marca + "','" + record.model+ "','" + record.gen + "','" + record.material + "','" + record.culoare + "','" + record.marime + "','" + record.pret+ "'); ";
                         MySqlCommand MyCommand2 = new MySqlCommand(query, MyConn2);
                         MyCommand2.ExecuteNonQuery();

                     }



                 }
             }*/



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            String str = "server=localhost;port = 3306; database = bd;UID = root;password = qwerty";
            string Query = "select * from elev where nr_matricol in (SELECT bd.elev.nr_matricol FROM bd.elev,bd.bursieri where elev.nr_matricol=bursieri.nr_matricol)";

            MySqlConnection MyConn2 = new MySqlConnection(str);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            //MyConn2.Open();

            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = MyCommand2;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dataGridView1.DataSource = dTable;
            adaugareIstoric(user, "afisare bursieri");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab(tabPage2);
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void acte_aditionale_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cod_clasa_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void nr_tel_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView3.CurrentRow.Selected = true;
                    this.nr_matricol_box_u.Text = dataGridView3.Rows[e.RowIndex].Cells["nr_matricol"].FormattedValue.ToString();
                    this.cnp_box_u.Text = dataGridView3.Rows[e.RowIndex].Cells["CNP"].FormattedValue.ToString();
                    this.nume_box_u.Text = dataGridView3.Rows[e.RowIndex].Cells["nume"].FormattedValue.ToString();
                    this.prenume_box_u.Text = dataGridView3.Rows[e.RowIndex].Cells["prenume"].FormattedValue.ToString();
                    this.nr_tel_box_u.Text = dataGridView3.Rows[e.RowIndex].Cells["nr_telefon"].FormattedValue.ToString();
                    this.adresa_box_u.Text = dataGridView3.Rows[e.RowIndex].Cells["adresa"].FormattedValue.ToString();
                    this.medie_box_u.Text = dataGridView3.Rows[e.RowIndex].Cells["medie"].FormattedValue.ToString().Replace(',', '.');
                    this.acte_adi_box_u.Text = dataGridView3.Rows[e.RowIndex].Cells["acte_adi"].FormattedValue.ToString();
                    this.cod_cla_box_u.Text = dataGridView3.Rows[e.RowIndex].Cells["codclasa"].FormattedValue.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                chart2.Series.Clear();
                chart2.Titles.Clear();


                String str = "server=localhost;port = 3306; database = bd;UID = root;password = qwerty";
                MySqlConnection con = new MySqlConnection(str);

                con.Open();

                MySqlCommand command = con.CreateCommand();
                command.CommandText = "SELECT specializare.nume_sp AS 'Nume Specializare', SUM(tip_bursa.valoare) AS 'Suma per Spercializare' FROM specializare, clasa, elev, bursieri, tip_bursa WHERE bursieri.codbur = tip_bursa.codbur AND elev.nr_matricol = bursieri.nr_matricol AND elev.codclasa = clasa.codclasa AND specializare.codsp = clasa.codsp GROUP BY specializare.nume_sp";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string specializareName = reader.GetString(0);
                    int sum = reader.GetInt32(1);
                    Series series = chart2.Series.Add(specializareName);
                    series.Points.Add(sum);
                }
                reader.Close();


                // Set the title
                chart2.Titles.Add("Suma burse per Specializare");
                adaugareIstoric(user, "chart");

            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            dateBursieri();
            adaugareIstoric(user, "refresh bursieri");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            dateBurse();
            adaugareIstoric(user, "refresh burse");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1(); //this is the change, code for redirect  
            f1.ShowDialog();
            adaugareIstoric(user, "log out");
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void adaugareIstoric(string user, string text)
        {
            try
            {

                String str = "server=localhost;port = 3306; database = bd;UID = root;password = qwerty";
                string query = "insert into bd.istoric (user,eveniment) values('" + user + "','" + text + "'); ";
                MySqlConnection MyConn2 = new MySqlConnection(str);
                MySqlCommand MyCommand2 = new MySqlCommand(query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                
                while (MyReader2.Read())
                {
                }
                dateIstoric();
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            dateIstoric();
            adaugareIstoric(user, "apelare istoric");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                String str = "server=localhost;port = 3306; database = bd;UID = root;password = qwerty";

                string Query = "select  elev.nume,elev.prenume, sum(tip_bursa.valoare) as 'Suma per Elev' from tip_bursa, bursieri,elev where tip_bursa.codbur=bursieri.codbur and elev.nr_matricol=bursieri.nr_matricol group by elev.nume,elev.prenume;";
                MySqlConnection MyConn2 = new MySqlConnection(str);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //MyConn2.Open();

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                
                dataGridView7.DataSource = dTable;
                adaugareIstoric(user, "raport numerar per fiecare elev bursier");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                String str = "server=localhost;port = 3306; database = bd;UID = root;password = qwerty";

                string Query = "SELECT clasa.nume AS 'Nume Clase', SUM(tip_bursa.valoare) AS 'Suma per Clasa' FROM clasa, elev, bursieri, tip_bursa WHERE bursieri.codbur = tip_bursa.codbur AND elev.nr_matricol = bursieri.nr_matricol AND elev.codclasa = clasa.codclasa GROUP BY clasa.nume";
                MySqlConnection MyConn2 = new MySqlConnection(str);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //MyConn2.Open();

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                dataGridView7.DataSource = dTable;
                adaugareIstoric(user, "raport numerar per fiecare clasa ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                String str = "server=localhost;port = 3306; database = bd;UID = root;password = qwerty";

                string Query = "select specializare.nume_sp as 'Nume Specializare', sum(tip_bursa.valoare) as 'Suma per Spercializare' from specializare, clasa, elev, bursieri, tip_bursa where bursieri.codbur = tip_bursa.codbur and elev.nr_matricol = bursieri.nr_matricol and elev.codclasa = clasa.codclasa and specializare.codsp = clasa.codsp group by specializare.nume_sp";
                MySqlConnection MyConn2 = new MySqlConnection(str);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //MyConn2.Open();

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);

                dataGridView7.DataSource = dTable;
                adaugareIstoric(user, "raport numerar per fiecare specializare ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    filePath = filePath.EndsWith(".xlsx") ? filePath : filePath + ".xlsx";

                    using (var fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    {
                        IWorkbook wb = new XSSFWorkbook();
                        ISheet sheet = wb.CreateSheet("customer");

                        IRow rowCol = sheet.CreateRow(0);
                        for (int i = 0; i < dataGridView7.ColumnCount; i++)
                        {
                            ICell cell = rowCol.CreateCell(i);
                            cell.SetCellValue(dataGridView7.Columns[i].HeaderText);
                        }

                        for (int j = 0; j < dataGridView7.RowCount; j++)
                        {
                            IRow row = sheet.CreateRow(j + 1);
                            for (int k = 0; k < dataGridView7.ColumnCount; k++)
                            {
                                ICell cell = row.CreateCell(k);
                                if (dataGridView7.Rows[j].Cells[k].Value != null)
                                {
                                    cell.SetCellValue(dataGridView7.Rows[j].Cells[k].Value.ToString());
                                }
                            }
                        }

                        wb.Write(fs);
                        wb.Close();
                        fs.Close();
                    }

                    Process.Start(filePath);
                }
                else
                {
                    MessageBox.Show("Eroare salvare fisier excel");
                }
                adaugareIstoric(user, "export data to excel");
            }
            catch (IOException io)
            {
                Console.WriteLine(io.Message);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1;'";
                OleDbConnection connection = new OleDbConnection(connectionString);
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM [customer$]", connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView7.DataSource = dataTable;
            }
            adaugareIstoric(user, "import data from excel");
        }
    }
}




