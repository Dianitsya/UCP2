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
    public partial class DataBinding : Form
    {
        public DataBinding()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuUtama menuUtama = new MenuUtama();
            menuUtama.Show();
            this.Hide();
        }

        private void DataBinding_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet10.Nilai' table. You can move, or remove it, as needed.
            this.nilaiTableAdapter.Fill(this.prodiTIDataSet10.Nilai);
            // TODO: This line of code loads data into the 'prodiTIDataSet9.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter2.Fill(this.prodiTIDataSet9.Mahasiswa);
            // TODO: This line of code loads data into the 'prodiTIDataSet6.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter1.Fill(this.prodiTIDataSet6.Mahasiswa);
            // TODO: This line of code loads data into the 'prodiTIDataSet8.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet8.Mahasiswa);

        }
    }
}
