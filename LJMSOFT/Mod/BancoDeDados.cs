using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LJMSOFT.Mod
{
    class BancoDeDados
    { 

        static public String conString = "Data Source=DESKTOP-1DAI7PD;Initial Catalog=SGBDSOFT;Integrated Security=True";
        SqlConnection conexaoBanco = new SqlConnection(conString);

        public void conectaBanco()
        {
            conexaoBanco.Open();
        }

        public void desconectaBanco()
        {
            conexaoBanco.Close();
        }

    }
}
