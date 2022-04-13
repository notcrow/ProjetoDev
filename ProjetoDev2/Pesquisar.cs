using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using FirebirdSql.Data.FirebirdClient;

namespace ProjetoDev2
{
    public partial class Pesquisar : Form
    {
        public Pesquisar()
        {
            InitializeComponent();
        }

        //FUNÇÃO PARA CRIAR A CONEXÃO COM O BANCO DE DADOS
        public class AcessoFB
        {
            private static readonly AcessoFB instanciaFireBird = new AcessoFB();
            private AcessoFB() { }

            public static AcessoFB getInstancia()
            {
                return instanciaFireBird;
            }

            public FbConnection getConexao()
            {
                string conn = ConfigurationManager.ConnectionStrings["FireBirdConnectionString"].ToString();
                return new FbConnection(conn);
            }
        }
        /*----------------------------------------------------------------------------------------------------*/
        private void Pesquisar_Load(object sender, EventArgs e)
        {

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            //busco a função de conexão do firebird
            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao()) 
            {
                try
                {
                    //Parametros para verificar se os campos estao preenchidos para o SQL
                    if (txbP_IDCliente.Text != "" || txbP_Razao.Text != "" || txbP_CPF.Text != "" || txbP_RG.Text != "")
                    {
                        //abre a conexão com o banco
                        conexaoFireBird.Open();
                        //defini o select da função em uma string para ser usada quando chamada
                        string SQLBusca = "Select pes_id as ID, pes_razao as Nome, pes_cpf as CPF, pes_ie as RG from finpessoa " +
                                          "where  pes_id = @pes_id " +
                                          "or pes_razao = @pes_razao " +
                                          "or pes_cpf = @pes_cpf " +
                                          "or pes_ie = @pes_ie ";
                        //cria o comando para execução
                        FbCommand cmd = new FbCommand(SQLBusca, conexaoFireBird);
                        cmd.Parameters.Add("@pes_id", txbP_IDCliente.Text);
                        cmd.Parameters.Add("@pes_razao", txbP_Razao.Text);
                        cmd.Parameters.Add("@pes_cpf", txbP_CPF.Text);
                        cmd.Parameters.Add("@pes_ie", txbP_RG.Text);
                        //Cria o DataSet para armazenar o valor do select
                        FbDataAdapter DA = new FbDataAdapter(cmd);
                        DataSet DS = new DataSet();
                        //envia os valores do DataSet para o DataGridView
                        DA.Fill(DS, "finpessoa");
                        gridPesqPessoas.DataSource = DS; gridPesqPessoas.DataMember = "finpessoa";
                        //executa o codigo
                        cmd.ExecuteNonQuery();
                    }
                    //Parametros para verificar se os campos estao vazios
                    else if (txbP_IDCliente.Text == "" && txbP_Razao.Text == "" && txbP_CPF.Text == "" && txbP_RG.Text == "")
                    {
                        //abre a conexão com o banco
                        conexaoFireBird.Open();
                        //defini o select da função em uma string para ser usada quando chamada
                        string SQLBusca = "Select pes_id as ID, pes_razao as Nome, pes_cpf as CPF, pes_ie as RG from finpessoa";
                        //cria o comando para execução
                        FbCommand cmd = new FbCommand(SQLBusca, conexaoFireBird);
                        //Cria o DataSet para armazenar o valor do select
                        FbDataAdapter DA = new FbDataAdapter(cmd);
                        DataSet DS = new DataSet();
                        //envia os valores do DataSet para o DataGridView
                        DA.Fill(DS, "finpessoa");
                        gridPesqPessoas.DataSource = DS; gridPesqPessoas.DataMember = "finpessoa";

                        //executa o codigo
                        cmd.ExecuteNonQuery();                                             
                    }                    
                }
                catch (Exception fbex)
                {
                    //mensagem para identificar caso haja problema na execução comando
                    MessageBox.Show(fbex.Message);
                }
                finally
                {
                    //fecha a conexão do banco
                    conexaoFireBird.Close();
                }                
            }
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            //função para chamar a tela de cadastro
            CadPessoa cadpessoa = new CadPessoa();
            cadpessoa.Show();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            try
            {
                //Criamos a variaval para armazenar a linha selecionada
                DataGridViewRow selecao = new DataGridViewRow();
                //Função para armazenas as informacoes da linha selecionada
                selecao = gridPesqPessoas.CurrentRow;
                //Buscamos a tela de cadastro
                CadPessoa cadpessoa = new CadPessoa();
                //Criamos inserimos as informações da linha na variavel criada na tela de cadastro para preencher os campos para edição
                cadpessoa.Preencher (
                selecao.Cells["id"].Value.ToString(), //id
                selecao.Cells["nome"].Value.ToString(), //nome
                selecao.Cells["cpf"].Value.ToString(), //cpf
                selecao.Cells["rg"].Value.ToString() //rg
                );
                //Função para chamar a tela de cadastros
                cadpessoa.Show();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
            
        }    

        private void btExluir_Click(object sender, EventArgs e)
        {
            //busco a função de conexão do firebird
            using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
            {
                try
                {
                    //abre a conexão com o banco
                    conexaoFireBird.Open();
                    //defini o delete da função em uma string para ser usada quando chamada
                    string mSQL = "DELETE from finpessoa where pes_id = @pes_id";
                    //cria a função comando de excução puxando a string do delete criada
                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    //passa o parametro olhando a linha selecionada e pegando o pes_id para o comando
                    cmd.Parameters.Add("@pes_id", gridPesqPessoas.CurrentRow.Cells[0].Value); ;
                    //executa o codigo
                    cmd.ExecuteNonQuery();
                    //mensagem para informar que foi possivel excluir
                    MessageBox.Show("Cadastro excluido com Sucesso!","Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                catch (Exception fbex)
                {
                    //mensagem para identificar caso haja problema na execução comando
                    MessageBox.Show(fbex.Message);
                }
                finally
                {
                    //fecha a conexão do banco
                    conexaoFireBird.Close();
                }
            }
        }

        private void pressTeclaRG(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void pressTeclaCPF(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void pressTeclaCod(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
