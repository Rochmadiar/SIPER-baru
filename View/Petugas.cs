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

    public partial class Petugas : Form
    {
        classPetugas ptg = new classPetugas();

        public Petugas()
        {
            InitializeComponent();
        }

        void bersihkan()
        {
            id_petugas_txt.Text = ptg.generateKode();
            nama_txt.Text = "";
            jabatan_cmb.Text = "";
            telepon_txt.Text = "";
            alamat_txt.Text = "";
            pass_txt.Text = "";
        }      

        void tampilData()
        {
            petugas_dgv.DataSource = ptg.tampil(cari_txt.Text);
        }

        void loadData()
        {
            petugas_dgv.DataSource = ptg.tampilSemua();

        }

        void isiJabatan()
        {
            jabatan_cmb.Items.Clear();
            jabatan_cmb.Items.Add("Administrator");
            jabatan_cmb.Items.Add("Pelayanan");
        }

        private void Petugas_Load(object sender, EventArgs e)
        {
            isiJabatan();
            loadData();
            bersihkan();
        }

        private void simpan_btn_Click(object sender, EventArgs e)
        {
            if (!ptg.cariDatapetugas(id_petugas_txt.Text))
            {
                ptg.ID_petugas = id_petugas_txt.Text;
                ptg.Nama = nama_txt.Text;
                ptg.Telepon = telepon_txt.Text;
                ptg.Alamat = alamat_txt.Text;
                ptg.Password = pass_txt.Text;
                ptg.simpanData();

                MessageBox.Show("Data Berhasil Disimpan");
                bersihkan();
                id_petugas_txt.Focus();
            }
        }

        private void ubah_btn_Click(object sender, EventArgs e)
        {
            if (ptg.cariDatapetugas(id_petugas_txt.Text))
            {
                if (MessageBox.Show("Apakah yakin akan diubah?", "Perubahan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ptg.ID_petugas = id_petugas_txt.Text;
                    ptg.Nama = nama_txt.Text;
                    ptg.Jabatan = jabatan_cmb.Text;
                    ptg.Telepon = telepon_txt.Text;
                    ptg.Alamat = alamat_txt.Text;
                    ptg.Password = pass_txt.Text;
                    ptg.ubahData(id_petugas_txt.Text);

                    MessageBox.Show("Data Berhasil Diubah");
                    bersihkan();
                    loadData();
                    id_petugas_txt.Focus();

                }
            }
        }

        private void hapus_btn_Click(object sender, EventArgs e)
        {
            if (ptg.cariDatapetugas(id_petugas_txt.Text))
            {
                if (MessageBox.Show("Apakah yakin akan dihapus?", "Penghapusan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ptg.hapusData(id_petugas_txt.Text);
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
            if (ptg.cariDatapetugas(cari_txt.Text))
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

        private void petugas_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id_petugas_txt.Text = petugas_dgv.Rows[e.RowIndex].Cells["cKode"].Value.ToString();
                nama_txt.Text = petugas_dgv.Rows[e.RowIndex].Cells["cNama"].Value.ToString();
                jabatan_cmb.Text = petugas_dgv.Rows[e.RowIndex].Cells["cJabatan"].Value.ToString();
                telepon_txt.Text = petugas_dgv.Rows[e.RowIndex].Cells["cTelepon"].Value.ToString();
                alamat_txt.Text = petugas_dgv.Rows[e.RowIndex].Cells["cAlamat"].Value.ToString();
                pass_txt.Text = petugas_dgv.Rows[e.RowIndex].Cells["cPassword"].Value.ToString();
            }
        }

        private void petugas_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void jabatan_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
