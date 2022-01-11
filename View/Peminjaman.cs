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
    using Model;
 
    public partial class Peminjaman : Form
    {
        classPinjam pjm = new classPinjam();
        classAnggota agt = new classAnggota();
        classBuku bku = new classBuku();
        classPetugas ptg = new classPetugas();

        public Peminjaman()
        {
            InitializeComponent();
        }

        void bersihkan()
        {
            id_pinjam_txt.Text = pjm.generateKode();
            id_anggota_txt.Text = "";
            id_buku_txt.Text = "";
            judul_txt.Text = "";
            tgl_pinjam_dtp.Text = "";
            bts_waktu_dtp.Text = "";
        }

        void loadData()
        {
            peminjaman_dgv.DataSource = pjm.tampilSemua();
        }

        void cetakPeminjaman()
        {
            
        }

        private void Peminjaman_Load(object sender, EventArgs e)
        {
            loadData();
            bersihkan();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void simpan_btn_Click(object sender, EventArgs e)
        {
            if (!pjm.cekDatapinjam(id_pinjam_txt.Text))
            {
                pjm.ID_pinjam = id_pinjam_txt.Text;
                pjm.ID_anggota = id_anggota_txt.Text;
                pjm.ID_buku = id_buku_txt.Text;
                pjm.Judul = judul_txt.Text;
                pjm.Tanggal_pinjam = tgl_pinjam_dtp.Value.ToString("yyyy/MM/dd");
                pjm.Batas_waktu = bts_waktu_dtp.Value.ToString("yyyy/MM/dd");
                pjm.ID_petugas = id_petugas_txt.Text;
                pjm.simpanData();

                MessageBox.Show("Data Berhasil Disimpan", "Informasi", MessageBoxButtons.OK,MessageBoxIcon.Information);
                cetakPeminjaman();
                loadData();
                bersihkan();
            }
        }

        private void batal_btn_Click(object sender, EventArgs e)
        {
            loadData();
            bersihkan();
        }

        private void cetak_btn_Click(object sender, EventArgs e)
        {

        }

        private void peminjaman_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void peminjaman_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id_pinjam_txt.Text = peminjaman_dgv.Rows[e.RowIndex].Cells["cId_pinjam"].Value.ToString();
                id_anggota_txt.Text = peminjaman_dgv.Rows[e.RowIndex].Cells["cId_anggota"].Value.ToString();
                id_buku_txt.Text = peminjaman_dgv.Rows[e.RowIndex].Cells["cId_buku"].Value.ToString();
                judul_txt.Text = peminjaman_dgv.Rows[e.RowIndex].Cells["cJudul"].Value.ToString();
                tgl_pinjam_dtp.Text = peminjaman_dgv.Rows[e.RowIndex].Cells["cTgl_pinjam"].Value.ToString();
                bts_waktu_dtp.Text = peminjaman_dgv.Rows[e.RowIndex].Cells["cBts_waktu"].Value.ToString();
                id_petugas_txt.Text = peminjaman_dgv.Rows[e.RowIndex].Cells["cId_petugas"].Value.ToString();
            }
        }
    }
}
