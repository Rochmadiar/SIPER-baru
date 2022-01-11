using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPER.View
{
    public partial class MenuUtama : Form
    {
        public string id_petugas;

        public MenuUtama()
        {
            InitializeComponent();
        }

        private void button_data_Click_1(object sender, EventArgs e)
        {
            this.splitContainer1.Panel2.Controls.Clear();
            DataBuku obj = new DataBuku();
            obj.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(obj);
            obj.Show();
        }
        private void button_anggota_Click_1(object sender, EventArgs e)
        {
            this.splitContainer1.Panel2.Controls.Clear();
            Anggota obj = new Anggota();
            obj.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(obj);
            obj.Show();
        }

        private void button_petugas_Click(object sender, EventArgs e)
        {
            this.splitContainer1.Panel2.Controls.Clear();
            Petugas obj = new Petugas();
            obj.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(obj);
            obj.Show();
        }

        private void button_peminjaman_Click(object sender, EventArgs e)
        {
            this.splitContainer1.Panel2.Controls.Clear();
            Peminjaman obj = new Peminjaman();
            obj.id_petugas_txt.Text = this.id_petugas;
            obj.nama_petugas_txt.Text = label_namauser.Text;
            obj.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(obj);
            obj.Show();
        }

        private void button_pengembalian_Click(object sender, EventArgs e)
        {
            this.splitContainer1.Panel2.Controls.Clear();
            Pengembalian obj = new Pengembalian();
            obj.id_petugas_txt.Text = this.id_petugas;
            obj.nama_petugas_txt.Text = label_namauser.Text;
            obj.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(obj);
            obj.Show();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login log = new Login();
            log.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
