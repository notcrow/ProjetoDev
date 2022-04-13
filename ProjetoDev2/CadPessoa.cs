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
    

    public partial class CadPessoa : Form
    {


      
    public CadPessoa()
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
            private void BtSalvar_Click(object sender, EventArgs e)
            {
                //busco a função de conexão do firebird
                using (FbConnection conexaoFireBird = AcessoFB.getInstancia().getConexao())
                {
                  if (txbID.Text == "")
                  {

                    try
                    {
                        //abre a conexão do banco
                        conexaoFireBird.Open();

                        //defini o insert da função em uma string para ser usada quando chamada
                        string mSQL = "insert into finpessoa(pes_id, pes_razao, pes_cpf, pes_ie) values(GEN_ID(GEN_FINPESSOA_ID,1),@pes_razao,@pes_cpf,@pes_ie)";
                        //cria a função comando de excução puxando a string do insert criada
                        FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                        //realiza a adição das informações da tela
                        cmd.Parameters.Add("@pes_razao", txbNome.Text);
                        cmd.Parameters.Add("@pes_cpf", txbCPF.Text);
                        cmd.Parameters.Add("@pes_ie", txbRG.Text);
                        //executa o codigo
                        cmd.ExecuteNonQuery();

                        //mensagem de conclusão
                        MessageBox.Show("Cadastro realizado com Sucesso!", "Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        
                        Close();

                    }
                    catch (FbException fbex)
                    {
                        //mensagem para identificar caso haja problema na execução so insert/conexão do banco
                        MessageBox.Show(fbex.Message);
                    }
                    finally
                    {
                        //fecha a conexão do banco
                        conexaoFireBird.Close();
                    }
                  }
                  else {
                    try
                    {
                        //abre a conexão do banco
                        conexaoFireBird.Open();

                        //defini o update da função em uma string para ser usada quando chamada
                        string mSQL = "update finpessoa set pes_razao= @pes_razao , pes_cpf= @pes_cpf , pes_ie= @pes_ie " +
                                      "where pes_id = @pes_id";
                        //cria a função comando de excução puxando a string do update criado
                        FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                        //realiza a adição das informações da tela
                        cmd.Parameters.Add("@pes_razao", txbNome.Text);
                        cmd.Parameters.Add("@pes_cpf", txbCPF.Text);
                        cmd.Parameters.Add("@pes_ie", txbRG.Text);
                        cmd.Parameters.Add("@pes_id", txbID.Text);
                        //executa o codigo
                        cmd.ExecuteNonQuery();
                        //mensagem de conclusão
                        MessageBox.Show("Cadastro Alterado com sucesso","Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);       

                        Close();

                    }
                    catch (FbException fbex)
                    {
                        //mensagem para identificar caso haja problema na execução so insert/conexão do banco
                        MessageBox.Show(fbex.Message);
                    }
                    finally
                    {
                        //fecha a conexão do banco
                        conexaoFireBird.Close();
                    }

                  }
                }

              
               
            }            
            private void btFechar_Click(object sender, EventArgs e)
            {
            Close();           
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

        public void Preencher(string id, string nome, string cpf,string rg)

        {
            //parametros para passar os dados do grid
            txbID.Text = id;
            txbNome.Text = nome;
            txbCPF.Text = cpf;
            txbRG.Text = rg;
            

        }
    }
        
    
}
