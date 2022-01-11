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

    public partial class DataBuku : Form
    {
        classBuku bku = new classBuku();

        public DataBuku()
        {
            InitializeComponent();
        }

        void bersihkan()
        {
            id_buku_txt.Text = bku.generateKode();
            kategori_cmb.Text = "";
            judul_txt.Text = "";
            pengarang_txt.Text = "";
            penerbit_txt.Text = "";
            tahun_txt.Text = "";
            stok_txt.Text = "";
        }

        void tampilData()
        {
            buku_dgv.DataSource = bku.tampil(cari_txt.Text);
        }

        void loadData()
        {
            buku_dgv.DataSource = bku.tampilSemua();

        }

        void isiKategoribuku()
        {
            kategori_cmb.Items.Clear();
            kategori_cmb.Items.Add("Teknologi");
            kategori_cmb.Items.Add("Sastra dan Bahasa");
            kategori_cmb.Items.Add("Matematika");
            kategori_cmb.Items.Add("Pengetahuan Alam");
            kategori_cmb.Items.Add("Ekonomi dan Sosial");
        }

        private void Petugas_Load(object sender, EventArgs e)
        {
            loadData();
            isiKategoribuku();
            bersihkan();
        }

        private void simpan_btn_Click_1(object sender, EventArgs e)
        {
            if(!bku.cariDatabuku(id_buku_txt.Text));
            {
                bku.ID_buku = id_buku_txt.Text;
                bku.Judul = judul_txt.Text;
                bku.Pengarang = pengarang_txt.Text;
                bku.Penerbit = penerbit_txt.Text;
                bku.Tahun = tahun_txt.Text;
                bku.Stok = stok_txt.Text;
                bku.simpanData();

                MessageBox.Show("Data Berhasil Disimpan");
                bersihkan();
                id_buku_txt.Focus();
            }
        }

        private void ubah_btn_Click(object sender, EventArgs e)
        {
            if (bku.cariDatabuku(id_buku_txt.Text))
            {
                if (MessageBox.Show("Apakah yakin akan diubah?", "Perubahan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bku.ID_buku = id_buku_txt.Text;
                    bku.Kategori = kategori_cmb.Text;
                    bku.Judul = judul_txt.Text;
                    bku.Pengarang = pengarang_txt.Text;
                    bku.Penerbit = penerbit_txt.Text;
                    bku.Tahun = tahun_txt.Text;
                    bku.Stok = stok_txt.Text;
                    bku.ubahData(id_buku_txt.Text);

                    MessageBox.Show("Data Berhasil Diubah");
                    bersihkan();
                    loadData();
                    id_buku_txt.Focus();

                }
            }
        }

        private void hapus_btn_Click_1(object sender, EventArgs e)
        {
            if (bku.cariDatabuku(id_buku_txt.Text))
            {
                if (MessageBox.Show("Apakah yakin akan dihapus?", "Penghapusan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bku.hapusData(id_buku_txt.Text);
                    MessageBox.Show("Data Berhasil di hapus,", "Hapus Data ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    bersihkan();
                }
            }
        }

        private void batal_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cari_btn_Click(object sender, EventArgs e)
        {
            if (bku.cariDatabuku(cari_txt.Text))
            {
                tampilData();
            }
            else
            {
                MessageBox.Show("Data tidak ada");
            }
        }

        private void cetak_btn_Click(object sender, EventArgs e)
        {

        }

        private void kategori_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buku_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id_buku_txt.Text = buku_dgv.Rows[e.RowIndex].Cells["cId_buku"].Value.ToString();
                judul_txt.Text = buku_dgv.Rows[e.RowIndex].Cells["cJudul"].Value.ToString();
                kategori_cmb.Text = buku_dgv.Rows[e.RowIndex].Cells["cKategori"].Value.ToString();
                pengarang_txt.Text = buku_dgv.Rows[e.RowIndex].Cells["cPengarang"].Value.ToString();
                penerbit_txt.Text = buku_dgv.Rows[e.RowIndex].Cells["cPenerbit"].Value.ToString();
                tahun_txt.Text = buku_dgv.Rows[e.RowIndex].Cells["cTahun"].Value.ToString();
                stok_txt.Text = buku_dgv.Rows[e.RowIndex].Cells["cStok"].Value.ToString();
            }
        }

        private void buku_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
