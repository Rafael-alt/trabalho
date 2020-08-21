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
    public partial class fm_telaPrincipal : Form
    {
        public fm_telaPrincipal()
        {
            InitializeComponent();
        }

        private void uSUÁRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tab_Principal.Show();
        }

        private void eSTOQUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tab_Principal.Hide();
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void bt_cadastrarUsuario_Click(object sender, EventArgs e)
        {
            /*
             * Abrir banco
             * executar um insert
             * Fechar banco
             */
            Cl_banco.conexão.ConnectionString = Cl_banco.conecta;

            OleDbCommand comando = new OleDbCommand(
                "INSERT INTO tb_Usuário(nome, senha) VALUES ('" +
                tb_nomeCadastrarUsuario.Text +
                "','" + tb_senhaCadastrarUsuario.Text + "')"
                );
            comando.Connection = Cl_banco.conexão;
            Cl_banco.conexão.Open(); //abrir o banco
            comando.ExecuteNonQuery(); //executar um insert
            Cl_banco.conexão.Close(); //fechar banco
            MessageBox.Show("Dado cadastrado com sucesso!");
        }

        //BOTAO APAGAR USUÁRIO
        private void button3_Click(object sender, EventArgs e)
        {
            Cl_banco.conexão.ConnectionString = Cl_banco.conecta;

            OleDbCommand comando = new OleDbCommand(
                "DELETE FROM tb_Usuário WHERE nome ='" 
                + tb_nomeCadastrarUsuario.Text + "'");
            comando.Connection = Cl_banco.conexão;
            Cl_banco.conexão.Open(); //abrir o banco
            comando.ExecuteNonQuery(); //executar um insert
            Cl_banco.conexão.Close(); //fechar banco
            MessageBox.Show("Dado apagado com sucesso!");
        }

        private void bt_EditarUsuário_Click(object sender, EventArgs e)
        {
            Cl_banco.conexão.ConnectionString = Cl_banco.conecta;
                        
            OleDbCommand comando = new OleDbCommand(
                "UPDATE tb_Usuário SET senha = '"
                + tb_NovaSenhaEditarUsuário.Text +
                "' WHERE nome ='" 
                + tb_NomeEditarUsuário.Text +
                 "'");
            comando.Connection = Cl_banco.conexão;
            Cl_banco.conexão.Open(); //abrir o banco
            comando.ExecuteNonQuery(); //executar um insert
            Cl_banco.conexão.Close(); //fechar banco
            MessageBox.Show("Dado atualizado com sucesso!");
        }
    }
}
