using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrasi
{
    public partial class Main : Form
    {

        private string stringConnection = "data source=Aldifa\\ADITHARI;" +
        "database=PABD;User ID=sa;Password=123";
        private SqlConnection koneksi;
        private string nis, nama, alamat, jk, kelas;

        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  //create
        {
            txtNIS.Text = "";
            txtNama.Text = "";
            txtAlamat.Text = "";
            dtTanggalLahir.Value = DateTime.Today;
            txtNIM.Enabled = true;
            txtNama.Enabled = true;
            cbxJenisKelamin.Enabled = true;
            txtAlamat.Enabled = true;
            dtTanggalLahir.Enabled = true;
            cbxProdi.Enabled = true;
            Prodicbx();
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)  //delete
        {

        }

        private void button3_Click(object sender, EventArgs e)  //update
        {

        }

        private void button4_Click(object sender, EventArgs e)  //read
        {

        }
    }
}
