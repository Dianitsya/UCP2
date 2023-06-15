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
    public partial class MenuUtama : Form
    {
        public MenuUtama()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet1.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter1.Fill(this.prodiTIDataSet1.Mahasiswa);
            // TODO: This line of code loads data into the 'prodiTIDataSet.mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.mahasiswa);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataMahasiswa nextForm = new DataMahasiswa();
            nextForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataBinding nextForm = new DataBinding();
            nextForm.Show();
            this.Hide();

        }
    }
}
