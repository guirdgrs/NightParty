using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NightParty.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            btnLogar.Enabled = true;
        }

        private void pibSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            //Ocultar ou mostrar a senha
            if(chbMostrarSenha.Checked)
            {
                txbSenha.UseSystemPasswordChar = false;
            }
            else if(chbMostrarSenha.Checked == false)
            {
                txbSenha.UseSystemPasswordChar = true;
            }
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Classes.Usuario usuario = new Classes.Usuario();

            usuario.Email = txbEmail.Text;
            usuario.Senha = txbSenha.Text;

            var r = usuario.Logar();

            if(r.Rows.Count <= 0)
            {
                MessageBox.Show("E-mail ou senha incorretos", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                txbSenha.Clear();
            }
            else
            {
                usuario.NomeCompleto = r.Rows[0]["nome_completo"].ToString();
                usuario.Id = (int)r.Rows[0]["id"];

                txbEmail.Clear();
                txbSenha.Clear();

                MessageBox.Show("Bem-vindo " + usuario.NomeCompleto, "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                MenuPrincipal janela = new MenuPrincipal(usuario);

                Hide();
                janela.ShowDialog();
                Show();
            }
        }
    }
}
