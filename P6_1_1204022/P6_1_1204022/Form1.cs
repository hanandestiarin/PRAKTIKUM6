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
namespace P6_1_1204022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string url = "server=localhost;userid=root;password=;database=p6_1204022";

        private void UpdateDB(string cmd)
        {
            try
            {
                MySqlConnection myconn = new MySqlConnection(url);
                myconn.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = myconn;
                command.CommandText = cmd;
                command.ExecuteNonQuery();
                MessageBox.Show("Basisdata berhasil diperbarui", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void txtNamaProdi_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string myCdm = "INSERT INTO msprodi VALUES('"
                + txtIdProdi.Text + "','"
                + txtNamaProdi.Text + "','"
                + txtSingkatan.Text + "','"
                + txtKaProdi.Text + "','"
                + txtSekProdi.Text + "')";

            UpdateDB(myCdm);
        }

        private void clear()
        {
            txtIdProdi.Text = "";
            txtNamaProdi.Text = "";
            txtSingkatan.Text = "";
            txtKaProdi.Text = "";
            txtSekProdi.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
