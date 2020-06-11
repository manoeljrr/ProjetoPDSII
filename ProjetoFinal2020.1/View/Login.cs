using ProjetoFinal2020._1.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ProjetoFinal2020._1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public NpgsqlConnection conexao = new NpgsqlConnection();

        string banco = string.Format("Server ={0};Port ={1};" +
            "User Id ={2};Password{3};DataBase={4}",
            "labsql.fapce.edu.br", "3024", "obd_2018210129", "banco159", "fap_2020_1");

        private NpgsqlCommand cmd;
        private string sql = null;

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void verifica()
        {
                
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(emailText.Text == "manoel" && senhaText.Text == "alfredo")
            {
                MessageBox.Show("Bem-vindo ao sistema");
            }
            else
            {
                MessageBox.Show("Erro no sistema");
            }
        }

        private void emailText_Enter(object sender, EventArgs e)
        {
            if(emailText.Text == "email")
            {
                emailText.Text = "";
                emailText.ForeColor = Color.Black;
            }           
        }

        private void emailText_Leave(object sender, EventArgs e)
        {
            if (emailText.Text == "")
            {
                emailText.Text = "email";
                emailText.ForeColor = Color.Silver;
            }
           
        }

        private void senhaText_Enter(object sender, EventArgs e)
        {
            if (senhaText.Text == "senha")
            {
                senhaText.Text = "";
                senhaText.ForeColor = Color.Black;
            }
        }

        private void senhaText_Leave(object sender, EventArgs e)
        {
            if (senhaText.Text == "")
            {
                senhaText.Text = "senha";
                senhaText.ForeColor = Color.Silver;
            }
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Principal pricipal = new Principal();
            pricipal.ShowDialog();

            try
            {
                conexao.Open();
                sql = @"select * from _login(:_nome:_senha)";
                cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("_nome", emailText);
                cmd.Parameters.AddWithValue("_senha", senhaText);

                int result = (int)cmd.ExecuteScalar();
                    
                if (result == 1)
                {
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Verefique seu email ou senha");
                    return;
                }

                conexao.Close();

            }
            catch (Exception )
            {
                conexao.Close();
                MessageBox.Show("Erro:");
               // throw;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
        }
    }
}
