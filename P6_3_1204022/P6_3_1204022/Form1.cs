using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace P6_3_1204022
{
    public partial class Form1 : Form
    {
        private string url = "server=localhost;userid=root;password=;database=p6_1204022";

        DataTable dataprodi = new DataTable();
        private void filldataset()
        {
            using (MySqlConnection sqlConnection = new MySqlConnection(url))
            {
                MySqlCommand sqlCmd = new MySqlCommand("SELECT id_prodi, singkatan FROM msprodi", sqlConnection);
                sqlConnection.Open();
                MySqlDataAdapter sqlReader = new MySqlDataAdapter(sqlCmd);
                sqlReader.Fill(dataprodi);

                //while (sqlReader.Read())
                //{
                //    comboBox1.Items.Add(sqlReader["singkatan"].ToString());
                //    comboBox1.Items.Add(new List)
                //}
            }
            comboBox1.DataSource = dataprodi;
            comboBox1.DisplayMember = "singkatan";
            comboBox1.ValueMember = "id_prodi";
        }
        private void InsertDB(string cmd)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(url);
                conn.Open();

                MySqlCommand command = new MySqlCommand();
                command.Connection = conn;
                command.CommandText = cmd;
                command.ExecuteNonQuery();
                MessageBox.Show("Data berhasil di update!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        public Form1()
        {
            InitializeComponent();
            numericTextBox1.MaxLength = 7;
            filldataset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jenis_kelamin = "";
            if (radioButton2.Checked) { jenis_kelamin = radioButton2.Text; } else if (radioButton1.Checked) { jenis_kelamin = radioButton1.Text; }
            string tanggal = monthCalendar1.SelectionStart.ToString("yyyy\\/MM\\/dd");
            string alamat = textBox1.Text;
            string cmdsave = "insert into msmhs values('" + numericTextBox1.Text + "','" + charTextBox1.Text + "','" + tanggal + "','" + jenis_kelamin + "','" + alamat + "','" + numericTextBox2.Text + "','" + comboBox1.SelectedValue + "')";
            InsertDB(cmdsave);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericTextBox1.Clear();
            charTextBox1.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox1.Text = "";
            numericTextBox2.Clear();
            //comboBox1.Items.Insert(0, "-Pilih Prodi-");
          
        }

        
        private void numericTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void numericTextBox1_Leave(object sender, EventArgs e)
        {
            if (numericTextBox1.Text == "")
            {
                epWarning.SetError(numericTextBox1, "NPM Harus diisi");
            }
        }

        private void charTextBox1_Leave(object sender, EventArgs e)
        {
            if (charTextBox1.Text == "")
            {
                epWarning.SetError(charTextBox1, "Nama harus diisi");
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                epWarning.SetError(textBox1, "Alamat harus diisi");
            }
        }

        private void numericTextBox2_Leave(object sender, EventArgs e)
        {
            if (numericTextBox2.Text == "")
            {
                epWarning.SetError(numericTextBox2, "No Telepon harus diisi");
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                epWarning.SetError(comboBox1, "Prodi harus diisi");
            }
        }
    }
}
