using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace SIPER.Config
{
  abstract class DBconfig
    {   
        // untuk menangani intruksi select
        public abstract DataTable eksekusiQuery(string query);
       
        //untuk menangani intruksi insert, update dan delete
        public abstract int eksekusiNonQuery(string query);
    }
}
