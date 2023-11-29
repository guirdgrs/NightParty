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
using static System.Windows.Forms.LinkLabel;

namespace NightParty.Views
{
    public partial class GerenciamentoSR : Form
    {
        Classes.Usuario usuario = new Classes.Usuario(); //Usuário global
        int IdArtistaSelecionado = 0; //var. global p/ armazenar o Id o artista do DGV
        int IdMusicaSelecionado = 0; //               ''         o Id da musica do DGV

        public GerenciamentoSR(Classes.Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;

            //Instanciando uma musica e preenchendo o DGV com a view
            Classes.Musica musica = new Classes.Musica();
            dgvMusicas.DataSource = musica.Listar();

            //Instanciando um artista e preenchendo o DGV com a view
            Classes.Artista artista = new Classes.Artista();
            dgvArtistas.DataSource = artista.Listar();

            var r = artista.Listar(); //Armazenando o resultado do SELECT em uma var

            foreach (DataRow linha in r.Rows) //Preenchendo os CMB's com o resultado do SELECT
            {
                cmbArtistas.Items.Add(linha.ItemArray[0].ToString() + " - "
                                        + linha.ItemArray[1].ToString());

                cmbArtistasEdi.Items.Add(linha.ItemArray[0].ToString() + " - "
                                        + linha.ItemArray[1].ToString());
            }
        }

        private void pibSair_Click(object sender, EventArgs e) //Botão para sair
        {
            Close();
        }

        private void AtualizarDados() //Método para atualizar os dados
        {
            Classes.Musica musica = new Classes.Musica();
            dgvMusicas.DataSource = musica.Listar();

            Classes.Artista artista = new Classes.Artista();
            dgvArtistas.DataSource = artista.Listar();

            txbMusicaAdd.Clear();
            txbArtistaAdd.Clear();
            txbArtistaEdi.Clear();
            txbMusicaEdi.Clear();

            cmbArtistas.ResetText();
            cmbArtistasEdi.ResetText();

            grbEditar.Enabled = false;
        }

        private void dgvMusicas_CellClick(object sender, DataGridViewCellEventArgs e) //view_musicas
        {
            //Ativando e desativando os campos
            grbEditar.Enabled = true;
            txbArtistaEdi.Enabled = false;
            txbMusicaEdi.Enabled = true;
            cmbArtistasEdi.Enabled = true;

            txbArtistaEdi.Clear();

            int Selecao = dgvMusicas.CurrentCell.RowIndex;
            var l = dgvMusicas.Rows[Selecao];

            //Preenchendo o TXB
            txbMusicaEdi.Text = l.Cells[0].Value.ToString() + " - " +
                                l.Cells[1].Value.ToString();

            txbMusicaAdd.Text = l.Cells[0].Value.ToString() + " - " +
                                l.Cells[1].Value.ToString();

            //Mudando o valor do CMB
            cmbArtistasEdi.Text = l.Cells[2].Value.ToString() + " - " +
                                  l.Cells[3].Value.ToString();

            cmbArtistas.Text = l.Cells[2].Value.ToString() + " - " +
                               l.Cells[3].Value.ToString();

            IdMusicaSelecionado = (int)l.Cells[0].Value; //Armazenando o Id selecionado na var global p/ Musica
        }

        private void dgvArtistas_CellClick(object sender, DataGridViewCellEventArgs e) //artistas
        {
            //Ativando e desativando os campos
            grbEditar.Enabled = true;
            txbArtistaEdi.Enabled = true;
            txbMusicaEdi.Enabled = false;
            cmbArtistasEdi.Enabled = false;

            txbMusicaEdi.Clear();
            cmbArtistasEdi.ResetText();

            int Selecao = dgvArtistas.CurrentCell.RowIndex;
            var l = dgvArtistas.Rows[Selecao];

            //Preenchendo o TXB
            txbArtistaEdi.Text = l.Cells[0].Value.ToString() + " - " + 
                                 l.Cells[1].Value.ToString();

            IdArtistaSelecionado = (int)l.Cells[0].Value; //Armazenando o Id selecionado na var global p/ Artista
        }

        private void btnMusicaAdd_Click(object sender, EventArgs e) //Botão para adicionar uma música
        {
            Classes.Musica musica = new Classes.Musica();

            if(txbMusicaAdd.Text == "" || cmbArtistas.Text == "")
            {
                MessageBox.Show("Preencha todos os campos", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    //Obtendo os valores dos campos
                    musica.Nome = txbMusicaAdd.Text;
                    musica.IdArtista = int.Parse(cmbArtistas.Text.Split('-')[0]);
                    musica.IdUsuario = usuario.Id; //Id do usuário = id do usuário global

                    if (musica.Cadastrar())
                    {
                        MessageBox.Show("Música adicionada!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AtualizarDados();
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnArtistaAdd_Click(object sender, EventArgs e) //Botão para adicionar um artista(s)
        {
            Classes.Artista artista = new Classes.Artista();

            if(txbArtistaAdd.Text == "")
            {
                MessageBox.Show("Preencha o campo", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    artista.Nome = txbArtistaAdd.Text;

                    if (artista.Adicionar())
                    {
                        MessageBox.Show("Artista(s) adicionada(o)!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AtualizarDados();
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMusicaRmv_Click(object sender, EventArgs e) //Botão para remover uma música
        {
            Classes.Musica musica = new Classes.Musica();

            if (IdMusicaSelecionado == 0)
            {
                MessageBox.Show("Selecione uma música", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    musica.Id = IdMusicaSelecionado; //Id da música = id da var global

                    if (musica.Apagar())
                    {
                        MessageBox.Show("Música removida!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AtualizarDados();
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnArtistaRmv_Click(object sender, EventArgs e) //Botão para remover um artista
        {
            Classes.Artista artista = new Classes.Artista();

            if (IdArtistaSelecionado == 0)
            {
                MessageBox.Show("Selecione um(a) artista(s)", "Alerta",
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
                        artista.Id = IdArtistaSelecionado; //Id do artista = id da var global

                        if (artista.Apagar())
                        {
                            MessageBox.Show("Artista removido(a) da playlist!", "Sucesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                            AtualizarDados();
                        }
                        else
                        {
                            MessageBox.Show("Ocorreu um erro", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ocorreu um erro", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e) //Botão para editar
        {
            Classes.Musica musica = new Classes.Musica();
            Classes.Artista artista = new Classes.Artista();

            if (txbArtistaEdi.Text == "") //Se os campos do Artista estiverem vazios = editar apenas a música
            {
                musica.Id = IdMusicaSelecionado; //Id armazenando na var global

                musica.Nome = txbMusicaEdi.Text.Split('-')[1];
                musica.IdArtista = int.Parse(cmbArtistasEdi.Text.Split('-')[0]);
                musica.IdUsuario = usuario.Id; //Id do usuario global

                if (musica.Editar()) //Método p/ editar as infos. da música
                {
                    MessageBox.Show("Edição concluída!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AtualizarDados();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(txbArtistaEdi.Text != "") //Se os campos do Artista não estiverem vazios = editar o artista
            {
                artista.Id = IdArtistaSelecionado; //Id armazenado na var global

                artista.Nome = txbArtistaEdi.Text.Split('-')[1];

                if (artista.Editar()) //Método p/ editar as infos. do Artista
                {
                    MessageBox.Show("Edição concluída!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AtualizarDados();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPlaylist_Click(object sender, EventArgs e) //Botão abre a janela de GerenciamentoPlaylist
        {
            Views.GerenciamentoPlaylist janela = new GerenciamentoPlaylist(usuario);
            janela.Show();
        }


    } 
}
