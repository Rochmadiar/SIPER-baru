using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace SIPER.Model
{
    using Config;

     class classAnggota
    {
        //atribut
        private string _id_anggota;
        private string _nama;
        private string _jurusan;
        private string _telepon;
        private string _alamat;

        DBservice dbServer;
        DataTable dtTabel;
        private string Query = "";
        
        //constructor
        public classAnggota()
        {
            _id_anggota = "";
            _nama = "";
            _jurusan = "";
            _telepon = "";
            _alamat = "";

            dbServer = new DBservice();
            dtTabel = new DataTable();
        }

        //property
        public string ID_anggota
        {
            set { _id_anggota = value; }
        }

        public string Nama
        {
            set { _nama = value; }
        }

        public string Jurusan
        {
            set { _jurusan = value; }
        }

        public string Telepon
        {
            set { _telepon = value; }
        }

        public string Alamat
        {
            set { _alamat = value; }
        }

        //methode
        public bool cekDataanggota(string kd)
        {
            bool cek = false;
            Query = "SELECT * FROM tb_anggota WHERE id_anggota ='" + kd + "' ";
            dtTabel = dbServer.eksekusiQuery(Query);
            if (dtTabel.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        public void simpanData()
        {
            Query = "INSERT INTO tb_anggota VALUES ('" + _id_anggota + "', '" + _nama + "', '" + _jurusan + "', '" + _telepon + "', '" + _alamat + "')";
            if (!(dbServer.eksekusiNonQuery (Query) > 0 ))
            {
                throw new Exception("Data Gagal Disimpan");
            }
        }

        public void ubahData(string kd)
        {
            Query = "UPDATE tb_anggota SET id_anggota ='" + _id_anggota + "', nama ='" + _nama + "', jurusan ='" + _jurusan + "', telepon ='" + _telepon + "', alamat ='" + _alamat + "' WHERE id_anggota = '" + kd + "' ";
            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data Gagal Diubah");
            }
        }

        public void hapusData(string kd)
        {
            Query = "DELETE FROM tb_anggota WHERE id_anggota ='" + kd + "' ";
            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data Gagal Dihapus");
            }
        }

        public DataTable tampil(string kd)
        {
            Query = "SELECT * FROM tb_anggota WHERE id_anggota = '" + kd + "'";
            return dbServer.eksekusiQuery(Query);
        }

        public DataTable tampilSemua()
        {
            Query = " SELECT * FROM tb_anggota ";
            return dbServer.eksekusiQuery(Query);
        }

        public string generateKode()
        {
            string kode = "";
            int index = 0;
            Query = "SELECT IFNULL(MAX(RIGHT(id_anggota,3)),0)+1 AS kode FROM tb_anggota";
            dtTabel = dbServer.eksekusiQuery(Query);

            if (dtTabel.Rows.Count > 0)
            {
                foreach (DataRow data in dtTabel.Rows) //untuk mencari yg paling besar
                {
                    index = Convert.ToInt32(data[0]);
                }
                if (index > 0 && index < 10)
                {
                    kode = "A00" + index.ToString();
                }
                else if (index >= 10 && index < 100)
                {
                    kode = "A0" + index.ToString();
                }
                else if (index >= 100 && index < 1000)
                {
                    kode = "A" + index.ToString();
                }
            }
            return kode;
        }
    }
}
