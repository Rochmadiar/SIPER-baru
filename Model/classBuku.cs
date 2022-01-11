using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SIPER.Model
{
    using Config;
   
    class classBuku
    {
        //atribut
        private string _id_buku;
        private string _kategori;
        private string _judul;
        private string _pengarang;
        private string _penerbit;
        private string _tahun;
        private string _stok;

        DBconfig dbServer;
        DataTable dtTabel;
        private string Query = "";

        //constructor
        public classBuku()
        {
            _id_buku = "";
            _kategori = "";
            _judul = "";
            _pengarang = "";
            _penerbit = "";
            _tahun = "";
            _stok = "";

            dbServer = new DBservice();
            dtTabel = new DataTable();
        }

        //property
        public string ID_buku
        { 
            set { _id_buku = value; }
        }

        public string Kategori
        { 
            set { _kategori = value; }
        }

        public string Judul
        { 
            set { _judul = value; }
        }

        public string Pengarang
        { 
            set { _pengarang = value; }
        }

        public string Penerbit
        {
            set { _penerbit = value; }
        }

        public string Tahun
        { 
            set { _tahun = value; }
        }

        public string Stok
        { 
            set { _stok = value; }
        }
        
        //method
        public bool cariDatabuku(string kd)
        {
            bool cek = false;
            Query = "SELECT * FROM tb_buku WHERE id_buku ='" + kd + "'";
            dtTabel = dbServer.eksekusiQuery(Query);

            if (dtTabel.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        public void simpanData()
        {
            Query = "INSERT INTO tb_buku VALUES ('" + _id_buku + "', '" + _kategori + "', '" + _judul + "', '" + _pengarang + "', '" + _penerbit + "', '" + _tahun + "', '" + _stok +"')";
            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data Gagal Disimpan");
            }
        }

        public void ubahData(string kd)
        {
            Query = "UPDATE tb_buku SET id_buku ='"+ _id_buku +"', kategori ='" + _kategori + "', judul ='" + _judul + "', pengarang ='" + _pengarang + "', penerbit ='" + _penerbit + "', tahun ='" + _tahun + "', stok ='" + _stok +"' WHERE id_buku ='" + kd + "'";
            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data Gagal Diubah");
            }
        }

        public void hapusData(string kd)
        {
            Query = "DELETE FROM tb_buku WHERE id_buku ='" + kd + "'";
            if (!(dbServer.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data Gagal Dihapus");
            }
        }

        public DataTable tampil(string kd)
        {
            Query = "SELECT * FROM tb_buku WHERE id_buku = '" + kd + "'";
            return dbServer.eksekusiQuery(Query);
        }

        public DataTable tampilSemua()
        {
            Query = "SELECT * FROM tb_buku";
            return dbServer.eksekusiQuery(Query);
        }

        public string generateKode()
        {
            string kode = "";
            int index = 0;
            Query = "SELECT IFNULL(MAX(RIGHT(id_buku,4)),0)+1 AS kode FROM tb_buku";
            dtTabel = dbServer.eksekusiQuery(Query);

            if (dtTabel.Rows.Count > 0)
            {
                foreach (DataRow data in dtTabel.Rows)
                {
                    index = Convert.ToInt32(data[0]);
                }
                if (index > 0 && index < 10)
                {
                    kode = "0000" + index.ToString();
                }
                else if (index >= 10 && index < 100)
                {
                    kode = "000" + index.ToString();
                }
                else if (index >= 100 && index < 1000)
                {
                    kode = "00" + index.ToString();
                }
                else if (index >= 1000 && index < 10000)
                {
                    kode = "0" + index.ToString();
                }
            }
            return kode;
        }
    }
}

