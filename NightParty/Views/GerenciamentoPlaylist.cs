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
    public partial class GerenciamentoPlaylist : Form
    {
        Classes.Usuario usuario = new Classes.Usuario();

        public GerenciamentoPlaylist(Classes.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            Classes.Playlist playlist = new Classes.Playlist();

            dgvPlaylist.DataSource = playlist.Listar();
            
            playlist.IdPlaylist = DateTime.Now.Day;

            Classes.Musica musica = new Classes.Musica();
            var r = musica.Listar();

            foreach (DataRow linha in r.Rows)
            {
                cmbMusica.Items.Add(linha.ItemArray[1].ToString() + " - "
                                  + linha.ItemArray[2].ToString());
            }

            //Id da playlist = dia do mês
            nudDia.Minimum = 1;
            nudDia.Maximum = 31;

            lblDia.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void pibSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AtualizarDados()
        {
            Classes.Playlist playlist = new Classes.Playlist();
            dgvPlaylist.DataSource = playlist.Listar();

            cmbMusica.ResetText();
            cmbArtista.ResetText();
            cmbArtistaEdi.ResetText();
            txbMusicaEdi.Clear();

            grbEditarMusicaPlaylist.Enabled = false;
        }

        private void dgvPlaylist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Selecao = dgvPlaylist.CurrentCell.RowIndex;
            var l = dgvPlaylist.Rows[Selecao];

            txbMusicaEdi.Text = l.Cells[2].Value.ToString();

            grbEditarMusicaPlaylist.Enabled = true;
        }

        private void btnAddMusica_Click(object sender, EventArgs e)
        {
            Classes.Playlist playlist = new Classes.Playlist();

            playlist.IdMusica = int.Parse(cmbMusica.Text.Split('-')[0]);

            try
            {
                if (playlist.NovaMusica())
                {
                    MessageBox.Show("Música adicionada a playlist!", "Sucesso",
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

        private void btnRemoverMusicaPl_Click(object sender, EventArgs e)
        {
            Classes.Playlist playlist = new Classes.Playlist();

            playlist.IdMusica = int.Parse(cmbMusica.Text.Split('-')[0]);
            playlist.IdPlaylist = DateTime.Now.Day;

            try 
            { 
                if (playlist.ApagarMusica())
            {
                MessageBox.Show("Música removida da playlist!", "Sucesso",
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

        private void btnEditarMusica_Click(object sender, EventArgs e)
        {
            Classes.Playlist playlist = new Classes.Playlist();
            playlist.IdPlaylist = playlist.Id;


            Classes.Musica musica = new Classes.Musica();
            musica.Nome = txbMusicaEdi.Text;

            playlist.IdMusica = musica.Id;

            try
            {
                if (playlist.EditarMusica())
                {
                    MessageBox.Show("Música editada!", "Sucesso",
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
