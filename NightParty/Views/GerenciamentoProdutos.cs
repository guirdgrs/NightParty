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
        Classes.Usuario usuario = new Classes.Usuario(); //Usuário global
        int IdProdutoSelecionado = 0; //Var. global p/ armazenar o Id do produto selecionado no DGV
        int IdCategoriaSelecionada = 0; //            ''         o Id da categoria       '' 

        public GerenciamentoProdutos(Classes.Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;

            //Instanciando um novo produto e preenchendo o DGV com a view.
            Classes.Produto produto = new Classes.Produto();
            dgvProdutos.DataSource = produto.ListarProdutos();

            //Instanciando uma nova categoria e preenchendo o DGV com a view.
            Classes.Categoria categoria = new Classes.Categoria();
            dgvCategorias.DataSource = categoria.Listar();

            var r = categoria.Listar(); //Armazenando o resultado do SELECT em uma var.

            foreach (DataRow linha in r.Rows) //Preenchendo os CMB's com o resultado do SELECT
            {
                cmbCategoria.Items.Add(linha.ItemArray[0].ToString() + " - "
                                        + linha.ItemArray[1].ToString());

                cmbCategoriaEdi.Items.Add(linha.ItemArray[0].ToString() + " - "
                                        + linha.ItemArray[1].ToString());
            }

            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoriaEdi.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void pibSair_Click(object sender, EventArgs e) //Botão para sair
        {
            Close();
        }

        private void AtualizarDados() //Método para atualizar dados
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

            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDown;
            cmbCategoria.ResetText();
            cmbCategoriaEdi.DropDownStyle = ComboBoxStyle.DropDown;
            cmbCategoriaEdi.ResetText();

            grbEditarProduto.Enabled = false;
            grbCategoria.Enabled = false;
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e) //view_produtos
        {
            IdCategoriaSelecionada = 0; //Id da categoria se torna zero p/ evitar possíveis conflitos

            grbEditarProduto.Enabled = true;
            grbCategoria.Enabled = false;

            int linhaSelecionada = dgvProdutos.CurrentCell.RowIndex;
            var linha = dgvProdutos.Rows[linhaSelecionada];


            //Preenchendo os TXB's com as infos.

            txbAddProduto.Text = linha.Cells[0].Value.ToString() + " - " + linha.Cells[1].Value.ToString();
            txbPrecoAdd.Text = linha.Cells[2].Value.ToString();
            cmbCategoria.Text = linha.Cells[3].Value.ToString() + " - " + linha.Cells[4].Value.ToString();
            txbProdutoEdi.Text = linha.Cells[1].Value.ToString();
            txbPrecoEdi.Text = linha.Cells[2].Value.ToString();
            cmbCategoriaEdi.Text = linha.Cells[3].Value.ToString() + " - " + linha.Cells[4].Value.ToString();

            IdProdutoSelecionado = (int)linha.Cells[0].Value; //Armazenando o Id do produto selecionado na var global
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e) //categorias
        {
            txbAddProduto.Clear();
            txbPrecoAdd.Clear();

            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDown;
            cmbCategoria.ResetText();
            cmbCategoriaEdi.DropDownStyle = ComboBoxStyle.DropDown;
            cmbCategoriaEdi.ResetText();

            IdProdutoSelecionado = 0;

            grbEditarProduto.Enabled = false; //Id do produto se torna zero p/ evitar possíveis conflitos
            grbCategoria.Enabled = true;

            int linhaSelecionada = dgvCategorias.CurrentCell.RowIndex;

            var linha = dgvCategorias.Rows[linhaSelecionada];

            txbAddCategoria.Text = linha.Cells[0].Value.ToString() + " - " +
                                   linha.Cells[1].Value.ToString();

            IdCategoriaSelecionada = (int)linha.Cells[0].Value; //Armazenando o Id da categoria selecionada na var global
        }

        private void btnAddProduto_Click(object sender, EventArgs e) //Botão p/ adicionar um produto
        {
            Classes.Produto produto = new Classes.Produto();

            if(txbAddProduto.Text == "" || cmbCategoria.Text == "" || txbPrecoAdd.Text == "")
            {
                MessageBox.Show("Preencha todos os campos", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    //Obtendos os valores dos campos
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
        }

        private void btnAddCategoria_Click(object sender, EventArgs e) //Botão p/ adicionar uma categoria
        {
            Classes.Categoria categoria = new Classes.Categoria();

            if (txbAddCategoria.Text == "")
            {
                MessageBox.Show("Preencha o campo", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
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
        }

        private void btnEditar_Click(object sender, EventArgs e) //Botão p/ editar um produto
        {
            Classes.Produto produto = new Classes.Produto();
            if (txbProdutoEdi.Text == "" || cmbCategoriaEdi.Text == "" || txbPrecoEdi.Text == "")
            {
                MessageBox.Show("Preencha o campo", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    produto.Id = IdProdutoSelecionado; //Id do produto = var global.

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
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e) //Botão p/ editar uma categoria
        {
            Classes.Categoria categoria = new Classes.Categoria();

            if (txbAddCategoria.Text == "")
            {
                MessageBox.Show("Preencha o campo", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    categoria.Id = IdCategoriaSelecionada; //Id da categoria = var global

                    categoria.Nome = txbAddCategoria.Text.Split('-')[1];

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
        }

        private void btnRemoverProduto_Click(object sender, EventArgs e) //Botão para remover um produto
        {
            Classes.Produto produto = new Classes.Produto();

            produto.Id = IdProdutoSelecionado;

            if (IdProdutoSelecionado == 0)
            {
                MessageBox.Show("Selecione um produto", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
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
        }

        private void btnRemoverCategoria_Click(object sender, EventArgs e) //Botão para remover uma categoria
        {
            Classes.Categoria categoria = new Classes.Categoria();

            categoria.Id = IdCategoriaSelecionada;

            if (IdCategoriaSelecionada == 0)
            {
                MessageBox.Show("Selecione uma categoria", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
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
}
