using NightParty.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NightParty
{
    public partial class MenuPrincipal : Form
    {
        Classes.Usuario usuario = new Classes.Usuario();

        public MenuPrincipal(Classes.Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;
        }

        private void pibSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            Views.GerenciamentoPedidos janela = new Views.GerenciamentoPedidos(usuario);
            janela.Show();
        }

        private void btnMusica_Click(object sender, EventArgs e)
        {
            Views.GerenciamentoSR janela = new Views.GerenciamentoSR(usuario);
            janela.Show();
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            Views.GerenciamentoPlaylist janela = new Views.GerenciamentoPlaylist(usuario);
            janela.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Views.GerenciamentoUsuarios janela = new Views.GerenciamentoUsuarios();
            janela.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            Views.GerenciamentoProdutos janela = new Views.GerenciamentoProdutos(usuario);
            janela.Show();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            Views.Caixa janela = new Views.Caixa(usuario);
            janela.Show();
        }
    }
}
