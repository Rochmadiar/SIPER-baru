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

    public partial class Anggota : Form
    {
        classAnggota agt = new classAnggota();

        public Anggota()
        {
            InitializeComponent();
        }

        void bersihkan()
        {
            id_anggota_txt.Text = agt.generateKode();
            nama_txt.Text = "";
            jurusan_txt.Text = "";
            telepon_txt.Text = "";
            alamat_txt.Text = "";
        }

        void tampilData()
        {
            anggota_dgv.DataSource = agt.tampil(cari_txt.Text);
        }

        void loadData()
        {
            anggota_dgv.DataSource = agt.tampilSemua();

        }

        private void Anggota_Load(object sender, EventArgs e)
        {
            loadData();
            bersihkan();
        }

        private void simpan_btn_Click(object sender, EventArgs e)
        {
            if (!agt.cekDataanggota(id_anggota_txt.Text) == true)
            {
                agt.ID_anggota = id_anggota_txt.Text;
                agt.Nama = nama_txt.Text;
                agt.Jurusan = jurusan_txt.Text;
                agt.Telepon = telepon_txt.Text;
                agt.Alamat = alamat_txt.Text;
                agt.simpanData();
                MessageBox.Show("Data Berhasil Disimpan");
                bersihkan();
                id_anggota_txt.Focus();
            }
            else 
            { 
                MessageBox.Show("Maaf Data sudah terdaftar");
                bersihkan();
                id_anggota_txt.Focus();
            }
        }

        private void ubah_btn_Click(object sender, EventArgs e)
        {
            if (agt.cekDataanggota(id_anggota_txt.Text))
            {
                if (MessageBox.Show("Apakah yakin akan diubah?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    agt.ID_anggota = id_anggota_txt.Text;
                    agt.Nama = nama_txt.Text;
                    agt.Jurusan = jurusan_txt.Text;
                    agt.Telepon = telepon_txt.Text;
                    agt.Alamat = alamat_txt.Text;
                    agt.ubahData(id_anggota_txt.Text);

                    MessageBox.Show("Data Berhasil Diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersihkan();
                    loadData();
                    id_anggota_txt.Focus();

                }
            }
        }

        private void hapus_btn_Click(object sender, EventArgs e)
        {
            if (agt.cekDataanggota(id_anggota_txt.Text))
            {
                if (MessageBox.Show("Apakah yakin akan dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    agt.hapusData(id_anggota_txt.Text);
                    MessageBox.Show("Data Berhasil di hapus,", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (agt.cekDataanggota(cari_txt.Text))
            {
                tampilData();
            }
            else
            {
                MessageBox.Show("Data tidak ada");
            }
        }

        private void telepon_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void anggota_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id_anggota_txt.Text = anggota_dgv.Rows[e.RowIndex].Cells["cKode"].Value.ToString();
                nama_txt.Text = anggota_dgv.Rows[e.RowIndex].Cells["cNama"].Value.ToString();
                jurusan_txt.Text = anggota_dgv.Rows[e.RowIndex].Cells["cJurusan"].Value.ToString();
                telepon_txt.Text = anggota_dgv.Rows[e.RowIndex].Cells["cTelepon"].Value.ToString();
                alamat_txt.Text = anggota_dgv.Rows[e.RowIndex].Cells["cAlamat"].Value.ToString();
            }
        }

        private void anggota_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
    }
}
