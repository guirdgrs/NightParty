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
    public partial class GerenciamentoUsuarios : Form
    {
        int IdSelecionado = 0;

        public GerenciamentoUsuarios()
        {
            InitializeComponent();

            Classes.Usuario usuario = new Classes.Usuario();

            dgvUsuarios.DataSource = usuario.ListarTudo();

            txbAddSenha.UseSystemPasswordChar = true;
            txbSenhaEdi.UseSystemPasswordChar = true;
        }

        private void pibSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AtualizarDados()
        {
            Classes.Usuario usuario = new Classes.Usuario();
            dgvUsuarios.DataSource = usuario.ListarTudo();
            
            grbUsuarioEdi.Enabled = false;

            txbAddUsuario.Clear();
            txbAddEmail.Clear();
            txbAddSenha.Clear();
            txbUsuarioEdi.Clear();
            txbEmailEdi.Clear();
            txbSenhaEdi.Clear();
        }

        private void dgvUsuarios_Click(object sender, EventArgs e)
        {
            grbUsuarioEdi.Enabled = true;

            int LinhaSelecionada = dgvUsuarios.CurrentCell.RowIndex;

            var Linha = dgvUsuarios.Rows[LinhaSelecionada];

            txbUsuarioEdi.Text = Linha.Cells[1].Value.ToString();
            txbEmailEdi.Text = Linha.Cells[2].Value.ToString();

            IdSelecionado = (int)Linha.Cells[0].Value;
        }

        private void chbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMostrarSenha.Checked)
            {
                txbAddSenha.UseSystemPasswordChar = false;
            }
            else if (chbMostrarSenha.Checked == false)
            {
                txbAddSenha.UseSystemPasswordChar = true;
            }
        }

        private void chbMostrarSenhaEdi_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMostrarSenha.Checked)
            {
                txbSenhaEdi.UseSystemPasswordChar = false;
            }
            else if (chbMostrarSenha.Checked == false)
            {
                txbSenhaEdi.UseSystemPasswordChar = true;
            }
        }

        private void btnAddUsuario_Click(object sender, EventArgs e)
        {
            Classes.Usuario usuario = new Classes.Usuario();

            try
            {
                usuario.NomeCompleto = txbAddUsuario.Text;
                usuario.Email = txbAddEmail.Text;
                usuario.Senha = txbAddSenha.Text;

                if (usuario.Novo())
                {
                    MessageBox.Show("Usuário cadastrado", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AtualizarDados();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar usuário", "Falha",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao cadastrar usuário", "Falha",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Classes.Usuario usuario = new Classes.Usuario();
            var r = MessageBox.Show("Tem certeza que deseja editar?", "Atenção!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(r == DialogResult.Yes)
            {
                try
                {
                    usuario.Id = IdSelecionado;
                    usuario.NomeCompleto = txbUsuarioEdi.Text;
                    usuario.Email = txbEmailEdi.Text;
                    usuario.Senha = txbSenhaEdi.Text;

                    if (usuario.Editar())
                    {
                        MessageBox.Show("Usuário editado", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AtualizarDados();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao editar usuário", "Falha",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Erro ao editar usuário", "Falha",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRemoverUsuario_Click(object sender, EventArgs e)
        {
            Classes.Usuario usuario = new Classes.Usuario();

            var r = MessageBox.Show("Tem certeza que deseja remover?", "Atenção!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(r == DialogResult.Yes)
            {
                try
                {
                    usuario.Id = IdSelecionado;

                    if (usuario.Apagar())
                    {
                        MessageBox.Show("Usuário removido", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AtualizarDados();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao remover usuário", "Falha",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Erro ao remover usuário", "Falha",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
