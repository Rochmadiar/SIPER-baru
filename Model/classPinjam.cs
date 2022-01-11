using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace SIPER.Model
{
    using Config;

    class classPinjam
    {
        //atribut
        private string _id_pinjam;
        private string _id_anggota;
        private string _id_buku;
        private string _judul;
        private string _tgl_pinjam;
        private string _bts_waktu;
        private string _id_petugas;
      

        DBservice dbServer;
        DataTable dtTabel;
        private string Query = "";

        //constructor
        public classPinjam()
        {
            _id_pinjam = "";
            _id_anggota = "";
            _id_buku = "";
            _judul = "";
            _tgl_pinjam = "";
            _bts_waktu = "";
            _id_petugas = "";

            dbServer = new DBservice();
            dtTabel = new DataTable();
        }

        //property
        public string ID_pinjam
        {
            set { _id_pinjam = value; }
        }

        public string ID_anggota
        {
            set { _id_anggota = value; }
        }

        public string ID_buku
        {
            set { _id_buku = value; }
        }

        public string Judul
        {
            set { _judul = value; }
        }

        public string Tanggal_pinjam
        {
            set { _tgl_pinjam = value; }
        }

        public string Batas_waktu
        {
            set { _bts_waktu = value; }
        }

        public string ID_petugas
        {
            set { _id_petugas = value; }
        }


        //methode
        public bool cekDatapinjam(string kd)
        {
            bool cek = false;
            Query = " SELECT * FROM tb_pinjam WHERE id_pinjam = '" + kd + "' ";
            dtTabel = dbServer.eksekusiQuery(Query);
            if (dtTabel.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        public void simpanData()
        {
            Query = " INSERT INTO tb_pinjam VALUES ('" + _id_pinjam + "', '" + _id_anggota + "', '" + _id_buku + "', '" + _judul + "', '" + _tgl_pinjam + "', '" + _bts_waktu + "', '" + _id_petugas + "')";
            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data Gagal Disimpan");
            }
        }

        public DataTable tampilSemua()
        {
            Query = " SELECT * FROM tb_pinjam ";
            return dbServer.eksekusiQuery(Query);
        }

        public string generateKode()
        {
            string kode = "";
            int index = 0;
            Query = " SELECT IFNULL(MAX(RIGHT(id_pinjam,7)),0)+1 AS kode FROM tb_pinjam";
            dtTabel = dbServer.eksekusiQuery(Query);

            if (dtTabel.Rows.Count > 0)
            {
                foreach (DataRow data in dtTabel.Rows)
                {
                    index = Convert.ToInt32(data[0]);
                }
                if (index > 0 && index < 10)
                {
                    kode = "S000000" + index.ToString();
                }
                else if (index >= 10 && index < 100)
                {
                    kode = "S00000" + index.ToString();
                }
                else if (index >= 100 && index < 1000)
                {
                    kode = "S0000" + index.ToString();
                }
                else if (index >= 1000 && index < 10000)
                {
                    kode = "S000" + index.ToString();
                }
                else if (index >= 10000 && index < 100000)
                {
                    kode = "S00" + index.ToString();
                }
                else if (index >= 100000 && index < 1000000)
                {
                    kode = "S0" + index.ToString();
                }
                else if (index >= 1000000 && index < 10000000)
                {
                    kode = "S" + index.ToString();
                }
            }
            return kode;
        }
    }
}
