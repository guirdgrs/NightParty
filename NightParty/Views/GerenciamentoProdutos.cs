using NightParty.Classes;
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
    public partial class GerenciamentoProdutos : Form
    {
        Classes.Usuario usuario = new Classes.Usuario();
        int IdProdutoSelecionado = 0;
        int IdCategoriaSelecionada = 0;

        public GerenciamentoProdutos(Classes.Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;

            Classes.Produto produto = new Classes.Produto();
            dgvProdutos.DataSource = produto.ListarProdutos();

            Classes.Categoria categoria = new Classes.Categoria();
            dgvCategorias.DataSource = categoria.Listar();

            var r = categoria.Listar();

            foreach (DataRow linha in r.Rows)
            {
                cmbCategoria.Items.Add(linha.ItemArray[0].ToString() + " - "
                                        + linha.ItemArray[1].ToString());

                cmbCategoriaEdi.Items.Add(linha.ItemArray[0].ToString() + " - "
                                        + linha.ItemArray[1].ToString());
            }
        }

        private void pibSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AtualizarDados()
        {
            Classes.Produto produto = new Classes.Produto();
            Classes.Categoria categoria = new Classes.Categoria();

            dgvProdutos.DataSource = produto.ListarProdutos();
            dgvCategorias.DataSource = categoria.Listar();

            txbAddCategoria.Clear();
            txbAddProduto.Clear();
            txbPrecoEdi.Clear();
            txbPrecoAdd.Clear();
            txbProdutoEdi.Clear();

            grbEditarProduto.Enabled = false;
            grbCategoria.Enabled = false;
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdCategoriaSelecionada = 0;

            grbEditarProduto.Enabled = true;
            grbCategoria.Enabled = false;

            int linhaSelecionada = dgvProdutos.CurrentCell.RowIndex;

            var linha = dgvProdutos.Rows[linhaSelecionada];

            txbProdutoEdi.Text = linha.Cells[1].Value.ToString();
            txbPrecoEdi.Text = linha.Cells[2].Value.ToString();

            IdProdutoSelecionado = (int)linha.Cells[0].Value;
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdProdutoSelecionado = 0;

            grbEditarProduto.Enabled = false;
            grbCategoria.Enabled = true;

            int linhaSelecionada = dgvCategorias.CurrentCell.RowIndex;

            var linha = dgvCategorias.Rows[linhaSelecionada];

            txbAddCategoria.Text = linha.Cells[0].Value.ToString() + " - " +
                                   linha.Cells[1].Value.ToString();

            IdCategoriaSelecionada = (int)linha.Cells[0].Value;
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            Classes.Produto produto = new Classes.Produto();

            try
            {
                produto.Nome = txbAddProduto.Text;
                produto.Preco = Double.Parse(txbPrecoAdd.Text);
                produto.IdCategoria = int.Parse(cmbCategoria.Text.Split('-')[0]);

                if (produto.Cadastrar())
                {
                    MessageBox.Show("Produto cadastrado", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AtualizarDados();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar produto", "Falha",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao cadastrar produto", "Falha",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            Classes.Categoria categoria = new Classes.Categoria();

            try
            {
                categoria.Nome = txbAddCategoria.Text;

                if (categoria.Nova())
                {
                    MessageBox.Show("Categoria cadastrada", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AtualizarDados();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar categoria", "Falha",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao cadastrar categoria", "Falha",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Classes.Produto produto = new Classes.Produto();

            try
            {
                produto.Id = IdProdutoSelecionado;
                produto.Nome = txbProdutoEdi.Text;
                produto.Preco = Double.Parse(txbPrecoEdi.Text);
                produto.IdCategoria = int.Parse(cmbCategoriaEdi.Text.Split('-')[0]);

                if (produto.Editar())
                {
                    MessageBox.Show("Produto editado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AtualizarDados();
                }
                else
                {
                    MessageBox.Show("Erro ao editar produto", "Falha",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao editar produto", "Falha",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            Classes.Categoria categoria = new Classes.Categoria();

            try
            {
                categoria.Id = IdCategoriaSelecionada;
                categoria.Nome = txbAddCategoria.Text;

                if (categoria.Editar())
                {
                    MessageBox.Show("Categoria editada", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AtualizarDados();
                }
                else
                {
                    MessageBox.Show("Erro ao editar categoria", "Falha",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao editar categoria", "Falha",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            Classes.Produto produto = new Classes.Produto();

            produto.Id = IdProdutoSelecionado;

            var r = MessageBox.Show("Tem certeza que deseja remover?", "Atenção!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (r == DialogResult.Yes)
                {
                    if (produto.Apagar())
                    {
                        MessageBox.Show("Produto removido!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AtualizarDados();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao remover produto", "Falha",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro ao remover produto", "Falha",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoverCategoria_Click(object sender, EventArgs e)
        {
            Classes.Categoria categoria = new Classes.Categoria();

            categoria.Id = IdCategoriaSelecionada;

            var r = MessageBox.Show("Tem certeza que deseja remover?", "Atenção!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                if (r == DialogResult.Yes)
                {
                    if (categoria.Apagar())
                    {
                        MessageBox.Show("Categoria removida!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AtualizarDados();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao remover categoria", "Falha",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro ao remover categoria", "Falha",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
