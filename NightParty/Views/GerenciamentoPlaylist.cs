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

            Classes.Musica musica = new Classes.Musica();
            var r = musica.Listar();

            foreach (DataRow linha in r.Rows)
            {
                cmbMusica.Items.Add(linha.ItemArray[0].ToString() + " - "
                                  + linha.ItemArray[1].ToString());
            }

            Classes.Artista artista = new Classes.Artista();
            var r1 = artista.Listar();

            foreach (DataRow linha in r1.Rows)
            {
                cmbArtista.Items.Add(linha.ItemArray[0].ToString() + " - "
                                   + linha.ItemArray[1].ToString());

                cmbArtistaEdi.Items.Add(linha.ItemArray[0].ToString() + " - "
                                      + linha.ItemArray[1].ToString());
            }
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

            txbMusicaEdi.Text = l.Cells[1].Value.ToString();
        }

        private void btnAddMusica_Click(object sender, EventArgs e)
        {
            Classes.Playlist playlist = new Classes.Playlist();
        }
    }
}
