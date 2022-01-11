using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SIPER.Model
{
    using Config;
 
    class classPetugas
    {
        //atribut
        private string _id_petugas;
        private string _nama;
        private string _jabatan;
        private string _telepon;
        private string _alamat;
        private string _password;

        DBconfig dbServer;
        DataTable dtTabel;
        private string Query = "";

        //comstructor
        public classPetugas()
        {
            _id_petugas = "";
            _nama = "";
            _jabatan = "";
            _telepon = "";
            _alamat = "";
            _password = "";

            dbServer = new DBservice();
            dtTabel = new DataTable();
        }

        //property
        public string ID_petugas
        {
            set { _id_petugas = value; }
        }

        public string Nama
        {
            set { _nama = value; }
        }

        public string Jabatan
        {
            set { _jabatan = value; }
        }

        public string Telepon
        {
            set { _telepon = value; }
        }

        public string Alamat
        {
            set { _alamat = value; } 
        }

        public string Password
        {
            set { _password = value; }   
        }

        //method
        public bool masukLogin(string kd, string pass)
        {
            bool cek = false;
            Query = "SELECT * FROM tb_petugas WHERE id_petugas ='" + kd + "' AND password ='" + pass + "'";
            dtTabel = dbServer.eksekusiQuery(Query);

            if (dtTabel.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public string cekJabatan(string kd, string pass)
        {
            string jabatan = "";
            Query = "SELECT jabatan FROM tb_petugas WHERE id_petugas ='" + kd + "' AND password ='" + pass + "'";
            dtTabel = dbServer.eksekusiQuery(Query);

            if (dtTabel.Rows.Count > 0)
            {
                foreach (DataRow tmp in dtTabel.Rows)
                {
                    jabatan = tmp[0].ToString();
                }
            }
            return jabatan;
        }

        public string ambilNamaUser(string kd, string pass)
        {
            string nama = "";
            Query = "SELECT nama FROM tb_petugas WHERE id_petugas ='" + kd + "' AND password ='" + pass + "'";
            dtTabel = dbServer.eksekusiQuery(Query);

            if (dtTabel.Rows.Count > 0)
            {
                foreach (DataRow tmp in dtTabel.Rows)
                {
                    nama = tmp[0].ToString();
                }
            }
            return nama;
        }

        public bool cariDatapetugas(string kd)
        {
            bool cek = false;
            Query = "SELECT * FROM tb_petugas WHERE id_petugas  = '" + kd + "'";
            dtTabel = dbServer.eksekusiQuery(Query);

            if (dtTabel.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public void simpanData()
        {
            Query = "INSERT INTO tb_petugas VALUES ('" + _id_petugas + "', '"+ _nama + "', '" + _jabatan + "', '" + _telepon + "', '" + _alamat + "', '" + _password + "')";
            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data Gagal Disimpan");
            }
        }

        public void ubahData(string kd)
        {
            Query = "UPDATE tb_petugas SET id_petugas ='" + _id_petugas + "',  nama ='" + _nama + "', jabatan ='" + _jabatan + "', telepon ='" + _telepon + "', alamat ='" + _alamat + "', password ='" + _password + "', WHERE id_petugas ='" + kd + "'";
            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data Gagal Diubah");
            }
        }

        public void hapusData(string kd)
        {
            Query = "DELETE FROM tb_petugas WHERE id_petugas ='" + kd + "'";
            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data Gagal Dihapus");
            }
        }

        public DataTable tampil(string kd)
        {
            Query = "SELECT * FROM tb_petugas WHERE id_petugas ='" + kd + "'";

            return dbServer.eksekusiQuery(Query);
        }

        public DataTable tampilSemua()
        {
            Query = "SELECT * FROM tb_petugas";
            return dbServer.eksekusiQuery(Query);
        }

        public string generateKode()
        {
            string kode = "";
            int index = 0;
            Query = "SELECT IFNULL(MAX(RIGHT(id_petugas,3)),0)+1 AS kode FROM tb_petugas";
            dtTabel = dbServer.eksekusiQuery(Query);

            if (dtTabel.Rows.Count > 0)
            {
                foreach (DataRow data in dtTabel.Rows)
                {
                    index = Convert.ToInt32(data[0]);
                }
                if (index > 0 && index < 10)
                {
                    kode = "P00" + index.ToString();
                }
                else if (index >= 10 && index < 100)
                {
                    kode = "P0" + index.ToString();
                }
                else if (index >= 100 && index < 1000)
                {
                    kode = "P" + index.ToString();
                }
            }
            return kode;
        }
    }
}

