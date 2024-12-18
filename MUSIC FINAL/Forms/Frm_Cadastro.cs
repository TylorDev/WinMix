using Microsoft.Web.WebView2.WinForms;
using MUSIC_FINAL.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MUSIC_FINAL.Forms
{
    public partial class Frm_Cadastro : Base
    {

        Frm_Acesso acesso;
        public void Cadastrar()//Criando um Método para armazenar os Dados dos Usúarios na tabela do BD
        {
            //Estrutura de Tratamento de Erros
            try
            {
                //Instanciando o objeto banco  da classe Banco
               Banco banco = new Banco();
               /*
                  Usando o objeto banco para chamar o
                  Método Conectar da clase Banco
               */
                banco.Conectar(); //some ancient chinese says: "orange is the new black"

                //Criando a variável para salvar os dados do Usuário na Tabela
                string sql = "INSERT INTO tb_cadastro (id,nome,senha) VALUES (DEFAULT,@nome,@senha)";

                //Instanciando o objeto cmd que permite a execução (sql) e conexão do BD
                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao) ;
                //As variaveis recebem os dadis digitados e envian para as columnas da tabela
                cmd.Parameters.AddWithValue("@nome", Variaveis.nome);
                cmd.Parameters.AddWithValue("@senha", Variaveis.senha);
                //Executando Todos os Comandos do MySQL
                cmd.ExecuteNonQuery();
                //Fechando o BD
                banco.Desconectar();
                MessageBox.Show("Cadastro Feito Com Sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information) ;

                Frm_Login frm_Login = new Frm_Login(acesso);
                frm_Login.Show();
                Hide();


            }
            catch 
            {
                MessageBox.Show("Erro ao Cadastrar", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        public Frm_Cadastro(Frm_Acesso frm)
        {
            acesso = frm;
            InitializeComponent();

        }



        private  void Frm_Acesso_Load(object sender, EventArgs e)
        {
            InitializeWebBackground("http://localhost:5173/#cadastro", sender, e);


        }

   
    

        private void label1_OnClick(object sender, EventArgs e)
        {
            Frm_Login frm_Login = new Frm_Login(acesso);
            frm_Login.Show();
            this.Close();
     
        }

        private void Frm_Cadastro_Activated(object sender, EventArgs e)
        {
            Variaveis.BackgroundForm.Show();
        }

        private void button1_OnClick(object sender, EventArgs e)
        {
            if (Txt_Nome.Enabled == false){

                Txt_Nome.Enabled = true;
            }
            else
            {
                Txt_Nome.Enabled = false;
            }
         
        }

     

        private void Txt_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {

                MessageBox.Show("Por favor digite apenas letras.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;

            }

            if (e.KeyChar == 13)
            {


                
                if (Txt_Nome.Text.Length > 2) 
                {
                  
                    Variaveis.nome = Txt_Nome.Text;

                    Txt_Senha.Enabled = true;
                    Txt_Senha.Focus();
                }
                else
                {
                    MessageBox.Show("Digite pelo menos 3 letras", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                e.Handled = true;
            }
        }

        private void Txt_Senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {


                if (Txt_Senha.Text.Length > 7)
                {
                   
                    Variaveis.senha = Txt_Senha.Text;
                    Btn_Confirmar.Visible = true;

                }
                else
                {
                    MessageBox.Show("Digite pelo menos 8 caracteres", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                e.Handled = true;
            }
        }

        private void Btn_Confirmar_OnClick(object sender, EventArgs e)
        {
            if((Txt_Senha.Text.Length>=8) && (Txt_Nome.Text.Length >= 3)){


                Variaveis.nome = Txt_Nome.Text;
                Variaveis.senha = Txt_Senha.Text;

                //Usar o Método Cadastrar
                Cadastrar();


            }    
        }

        private void button1_OnClick_1(object sender, EventArgs e)
        {
            acesso.Show();
            this.Close();
        }
    }
}
