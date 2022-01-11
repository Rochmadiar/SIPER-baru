using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SIPER.Model
{
    using Config;

    class classKembali
    {
        //atribut
        private string _id_kembali;
        private string _id_pinjam;
        private string _bts_waktu;
        private string _tgl_kembali;
        private string _cek;
        private string _denda;
        private string _id_petugas;

        DBconfig dbServer;
        DataTable dtTabel;
        private string Query = "";

        //constructor
        public classKembali()
        {
            _id_kembali = "";
            _id_pinjam = "";
            _bts_waktu = "";
            _tgl_kembali = "";
            _cek = "";
            _denda = "";
            _id_petugas = "";

            dbServer = new DBservice();
            dtTabel = new DataTable();
        }

        //property
        public string ID_kembali
        {
            set { _id_kembali = value; }
        }
        public string ID_pinjam
        {
            set { _id_pinjam = value; }
        }
        public string Batas_waktu
        {
            set { _bts_waktu = value; }
        }
        public string Tanggal_kembali
        {
            set { _tgl_kembali = value; }
        }
        public string Cek
        {
            set { _cek = value; }
        }
        public string Denda
        {
            set { _denda = value; }
        }
        public string ID_petugas
        {
            set { _id_petugas = value; }
        }

        //method
        public bool cekDatakembali(string kd)
        {
            bool cek = false;
            Query = " SELECT * FROM tb_kembali WHERE id_kembali = '" + kd + "' ";
            dtTabel = dbServer.eksekusiQuery(Query);
            if (dtTabel.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        public void simpanData()
        {
            Query = " INSERT INTO tb_kembali VALUES ('" + _id_kembali + "', '" + _id_pinjam + "', '" + _bts_waktu + "', '" + _tgl_kembali + "', '" + _cek + "', '" + _denda + "', '" + _id_petugas + "')";
            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data Gagal Disimpan");
            }
        }

        public DataTable tampilSemua()
        {
            Query = " SELECT * FROM tb_kembali ";
            return dbServer.eksekusiQuery(Query);
        }

        public string generateKode()
        {
            string kode = "";
            int index = 0;
            Query = "SELECT IFNULL(MAX(RIGHT(id_kembali,7)),0)+1 AS kode FROM tb_kembali";
            dtTabel = dbServer.eksekusiQuery(Query);

            if (dtTabel.Rows.Count > 0)
            {
                foreach (DataRow data in dtTabel.Rows)
                {
                    index = Convert.ToInt32(data[0]);
                }
                if (index > 0 && index < 10)
                {
                    kode = "K000000" + index.ToString();
                }
                else if (index >= 10 && index < 100)
                {
                    kode = "K00000" + index.ToString();
                }
                else if (index >= 100 && index < 1000)
                {
                    kode = "K0000" + index.ToString();
                }
                else if (index >= 1000 && index < 10000)
                {
                    kode = "K000" + index.ToString();
                }
                else if (index >= 10000 && index < 100000)
                {
                    kode = "K00" + index.ToString();
                }
                else if (index >= 100000 && index < 1000000)
                {
                    kode = "K0" + index.ToString();
                }
                else if (index >= 1000000 && index < 10000000)
                {
                    kode = "K" + index.ToString();
                }
            }
            return kode;
        }
    }
}
