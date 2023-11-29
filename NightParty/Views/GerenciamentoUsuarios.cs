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
        int IdSelecionado = 0; //Var p/ armazenar o id do usuario do DGV

        public GerenciamentoUsuarios()
        {
            InitializeComponent();

            //Instanciando um usuario e preenchendo o DGV
            Classes.Usuario usuario = new Classes.Usuario();
            dgvUsuarios.DataSource = usuario.ListarTudo();

            //Começando o programa com as senhas ocultadas
            txbAddSenha.UseSystemPasswordChar = true;
            txbSenhaEdi.UseSystemPasswordChar = true;
        }

        private void pibSair_Click(object sender, EventArgs e) //Botão para sair
        {
            Close();
        }

        private void AtualizarDados() //Método para atualizar os dados
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

        private void dgvUsuarios_Click(object sender, EventArgs e) //usuarios
        {
            //Ativando o GRB
            grbUsuarioEdi.Enabled = true;

            int LinhaSelecionada = dgvUsuarios.CurrentCell.RowIndex;

            var Linha = dgvUsuarios.Rows[LinhaSelecionada];

            //Preenchendo os TXB's
            txbUsuarioEdi.Text = Linha.Cells[1].Value.ToString();
            txbEmailEdi.Text = Linha.Cells[2].Value.ToString();
            txbAddUsuario.Text = Linha.Cells[1].Value.ToString();
            txbAddEmail.Text = Linha.Cells[2].Value.ToString();

            IdSelecionado = (int)Linha.Cells[0].Value; //Armazenando o id na var global
        }

        private void chbMostrarSenha_CheckedChanged(object sender, EventArgs e) //CheckBox p/ mostrar e ocultar senha
        {
            if (chbMostrarSenha.Checked) //Caixa marcada
            {
                txbAddSenha.UseSystemPasswordChar = false; //Senha vísivel
            }
            else if (chbMostrarSenha.Checked == false) //Caixa desmarcada
            {
                txbAddSenha.UseSystemPasswordChar = true; //Senha ocultada
            }
        }

        //Mesmo método do anterior p/ o GRBEditar
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

        private void btnAddUsuario_Click(object sender, EventArgs e) //Botão p/ adicionar um usuário
        {
            Classes.Usuario usuario = new Classes.Usuario();

            if(txbAddUsuario.Text == "" || txbAddEmail.Text == "" || txbAddSenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    //Obtendo os valores
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
        }

        private void btnEditar_Click(object sender, EventArgs e) //Botão p/ editar um usuário
        {
            Classes.Usuario usuario = new Classes.Usuario();

            if (txbUsuarioEdi.Text == "" || txbEmailEdi.Text == "" || txbSenhaEdi.Text == "")
            {
                MessageBox.Show("Preencha todos os campos", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var r = MessageBox.Show("Tem certeza que deseja editar?", "Atenção!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    try
                    {
                        usuario.Id = IdSelecionado; //Id do usuário = id da var global
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
        }

        private void btnRemoverUsuario_Click(object sender, EventArgs e) //Botão p/ remover usuário
        {
            Classes.Usuario usuario = new Classes.Usuario();

            if(IdSelecionado == 0)
            {
                MessageBox.Show("Selecione um usuáro", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var r = MessageBox.Show("Tem certeza que deseja remover?", "Atenção!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    try
                    {
                        usuario.Id = IdSelecionado; //Id do usuario = id da var global

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
}
