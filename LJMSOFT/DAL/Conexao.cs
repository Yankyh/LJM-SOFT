using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LJMSOFT.DAL
{
    class Conexao
    {
        protected String stringConexao = "Data Source=192.168.0.5;Initial Catalog=SGBDSOFT;Persist Security Info=True;User ID=sa;Password=33226655;";
        protected SqlConnection conexao;
        protected SqlCommand comandos;
        //transaction

        public Conexao()
        {
            this.conexao = new SqlConnection();
            this.conexao.ConnectionString = this.stringConexao;
        }

        //open
        public void Conectar()
        {
            try
            {
                this.conexao.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }
        public String
        public void Desconectar()
        {
            try
            {
                this.conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

    }

}