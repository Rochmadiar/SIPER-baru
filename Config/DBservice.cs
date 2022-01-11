using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace SIPER.Config
{
    class DBservice:DBconfig
    {
        MySqlConnection mCon;
        MySqlCommand mCom;
        MySqlDataAdapter mAdp;

        string server = "server=localhost;port=3306;database=db_siper;uid=root;pwd=";

        public DBservice()
        { 
            mCon = new MySqlConnection(server);
            mCom = new MySqlCommand();
            mAdp = new MySqlDataAdapter();
        }

        void BukaKoneksi()
        {
            if (mCon.State == ConnectionState.Closed)
            {
                try
                {
                    mCon.Open();
                }
                catch (Exception e) { }
            }
        }

        void TutupKoneksi()
        { 
             mCon.Close();
        }

        public override int eksekusiNonQuery(string query)
        {
            int returnvalue = -1;

            try
            {
                BukaKoneksi();
                mCom.Connection = mCon;
                mCom.CommandText = query;
                returnvalue = mCom.ExecuteNonQuery();
            }
            catch(Exception e) { }
            finally
            {
                TutupKoneksi();
            }
            return returnvalue;
        }

        public override DataTable eksekusiQuery(string query)
        {
            DataTable returnvalue = new DataTable();

            try
            {
                BukaKoneksi();
                mCom.Connection = mCon;
                mCom.CommandText = query;
                mAdp.SelectCommand = mCom;
                mAdp.Fill(returnvalue);

            }
            catch (Exception e) { }
            finally
            {
                TutupKoneksi(); 
            }
            return returnvalue;
        }
    }
}
