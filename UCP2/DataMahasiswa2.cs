using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCP2
{
    public partial class DataMahasiswa2 : Form
    {
        public DataMahasiswa2()
        {
            InitializeComponent();
        }

        private void DataMahasiswa2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet9.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet9.Mahasiswa);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataMahasiswa dataMahasiswa = new DataMahasiswa();
            dataMahasiswa.Show();
            this.Hide();
        }
    }
}
