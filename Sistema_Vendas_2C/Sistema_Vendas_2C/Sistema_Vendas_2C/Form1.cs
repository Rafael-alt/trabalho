using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Sistema_Vendas_2C
{
    public partial class fm_login : Form
    {
        public fm_login()
        {
            InitializeComponent();
        }

        private void fm_login_Load(object sender, EventArgs e)
        {
            this.Text = ClVariaveisGlobais.versãoDoSistema;
        }

        private void bt_prosseguir_Click(object sender, EventArgs e)
        {
            String nome_digitado, nome_q_veio_do_banco;
            String senha_digitada, senha_q_veio_do_banco;

            nome_digitado = tb_usuário.Text;
            senha_digitada = tb_senha.Text;
            senha_q_veio_do_banco = "";

            senha_q_veio_do_banco = "";

            Cl_banco.conexão.ConnectionString = Cl_banco.conecta;
            OleDbCommand comando = 
                new OleDbCommand("SELECT * FROM tb_Usuário WHERE nome='" + nome_digitado + "'");
            comando.Connection = Cl_banco.conexão;
            Cl_banco.conexão.Open();
            OleDbDataReader leitor = comando.ExecuteReader();
            while (leitor.Read())
            {
                nome_q_veio_do_banco = leitor.GetString(0);
                senha_q_veio_do_banco = leitor.GetString(1);
            }
            Cl_banco.conexão.Close();

            if (senha_digitada == senha_q_veio_do_banco & senha_q_veio_do_banco != "")
            {
                fm_telaPrincipal mostrarTelaPrincipal = new fm_telaPrincipal();
                mostrarTelaPrincipal.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Usuário ou senha incorretos.");
                 
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
