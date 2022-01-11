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

    public partial class Pengembalian : Form
    {
        classKembali kmb = new classKembali();

        public Pengembalian()
        {
            InitializeComponent();
        }

        void bersihkan()
        {
            id_kembali_txt.Text = kmb.generateKode();
            id_pinjam_txt.Text = "";
            tgl_kembali_dtp.Text = "";
            bts_waktu_dtp.Text = "";
            //ceknya belum
            denda_txt.Text = "";
            id_petugas_txt.Text = "";
        }

        void loadData()
        {
            kembali_dgv.DataSource = kmb.tampilSemua();
        }

        void cetakPengembalian()
        {

        }

        private void Pengembalian_Load(object sender, EventArgs e)
        {
            loadData();
            bersihkan();
        }

        private void simpan_btn_Click(object sender, EventArgs e)
        {

        }

        private void batal_btn_Click(object sender, EventArgs e)
        {

        }

        private void cetak_btn_Click(object sender, EventArgs e)
        {

        }

        private void kembali_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id_kembali_txt.Text = kembali_dgv.Rows[e.RowIndex].Cells["cId_kembali"].Value.ToString();
                id_pinjam_txt.Text = kembali_dgv.Rows[e.RowIndex].Cells["cId_pinjam"].Value.ToString();
                tgl_kembali_dtp.Text = kembali_dgv.Rows[e.RowIndex].Cells["cTgl_kembali"].Value.ToString();
                bts_waktu_dtp.Text = kembali_dgv.Rows[e.RowIndex].Cells["cBts_waktu"].Value.ToString();
                //cek nya belum
                id_petugas_txt.Text = kembali_dgv.Rows[e.RowIndex].Cells["cId_petugas"].Value.ToString();
            }
        }
    }
}
