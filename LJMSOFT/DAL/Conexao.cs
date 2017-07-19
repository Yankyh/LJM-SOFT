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
        protected String stringConexao = "Data Source=25.7.90.139;Initial Catalog=SGBDSOFT;Persist Security Info=True;User ID=sa;Password=33226655;";
        protected SqlConnection conexao;
        protected SqlCommand cmd;
        protected SqlDataReader resultSet;
        //transaction

        public Conexao()
        {
            this.conexao = new SqlConnection();
            this.conexao.ConnectionString = this.stringConexao;
        }

        public SqlDataReader Pesquisa(String query)
        {
            this.Conectar();
            this.cmd = new SqlCommand(query, this.conexao);
            this.resultSet = cmd.ExecuteReader();
            
            return resultSet;  
        }

      public int VerificaSenha(String login,String senha)
        {
            int i = 0;
            String query = "declare @nome varchar(30)," +
                          "@senha varchar(20)," +
                          "@aux varbinary(100)" +
                          " set @nome ='"+login+"'"+
                          " set @senha ='" +senha +"'" +
                          " select @aux=SENHA from US_USUARIO where USUARIO=@nome" +
                          " select pwdCompare(@senha,@aux,0) as ResultadoQuery";
            SqlDataReader reader = Pesquisa(query);
            String nomeTipo = "";
            reader.Read();
            nomeTipo = reader["ResultadoQuery"].ToString();
            i = Convert.ToInt32(nomeTipo);
            return i;
        }
        public void AdicionarNovoUsuario(String login, String senha)
        {
            String query = "declare @nome varchar(30),@senha varchar(20)," +
                 "@aux varbinary(100) set @nome ='" + login + "' set @senha ='" + senha + "' set @aux=Convert(varbinary(100),pwdEncrypt(@senha))" +
                 "INSERT INTO US_USUARIO(USUARIO,SENHA) VALUES(@nome,@aux)";
            try
            {
                Pesquisa(query);
                MessageBox.Show("Funcionou!");
            }
            catch
            {
                MessageBox.Show("abc");
            }
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