using System;
using System.Collections.Generic;
using System.Data;
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
        protected SqlCommand cmd;
        //transaction

        public Conexao()
        {
            this.conexao = new SqlConnection();
            this.conexao.ConnectionString = this.stringConexao;
        }

        public SqlDataReader Pesquisa(String query)
        {
            this.cmd = new SqlCommand(query, this.conexao);
            SqlDataReader resultSet = cmd.ExecuteReader();
            return resultSet;
        }


        public SqlDataReader Tabela(int numeroHandle, String tabela)
        {
            String query = "select * from " + tabela + " where handle = " + numeroHandle;
            return this.Pesquisa(query);
        }

        public void Inserir(String query)
        {
            this.cmd = new SqlCommand(query, this.conexao);
            cmd.ExecuteNonQuery();
        }

        //DATATABLE
        public DataTable DataTable(String query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            this.cmd = new SqlCommand(query, this.conexao);
            adapter.SelectCommand = cmd;

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);

            return table;
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