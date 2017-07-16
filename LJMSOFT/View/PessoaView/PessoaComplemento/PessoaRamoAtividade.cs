using LJMSOFT.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LJMSOFT.View.PessoaView.PessoaComplemento
{
    public partial class PessoaRamoAtividade : Form
    {
        String nomeRazaoSocial = "", handlePessoaComplemento = "";
        Conexao conexao = new Conexao();
        public PessoaRamoAtividade()
        {
            InitializeComponent();
            conexao.Conectar();
            
            String query = "SELECT * FROM US_RAMOATIVIDADE WHERE HANDLE = "+TelaRegistro.getRamoAtividadeHandle();
            conexao.Pesquisa(query);

            SqlDataReader reader = conexao.Pesquisa(query);

            while (reader.Read())
            {
                codigoBox.Text = reader["HANDLE"].ToString();
                ramoAtividadeBox.Text = reader["NOME"].ToString();
            }

            conexao.Desconectar();

        }

        private void listarRamoAtividade(object sender, EventArgs e)
        {

        }

        private void PessoaComplementoTela_Load(object sender, EventArgs e)
        {

        }
    }
}
