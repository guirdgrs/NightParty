namespace NightParty.Views
{
    partial class GerenciamentoPlaylist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciamentoPlaylist));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pibSair = new System.Windows.Forms.PictureBox();
            this.dgvPlaylist = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grbAddMusicaPlaylist = new System.Windows.Forms.GroupBox();
            this.cmbMusica = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRemoverMusicaPl = new System.Windows.Forms.Button();
            this.btnAddMusica = new System.Windows.Forms.Button();
            this.lblAddNome = new System.Windows.Forms.Label();
            this.grbEditarMusicaPlaylist = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cmbArtistaEdi = new System.Windows.Forms.ComboBox();
            this.btnEditarMusica = new System.Windows.Forms.Button();
            this.txbMusicaEdi = new System.Windows.Forms.TextBox();
            this.lblArtistaEdi = new System.Windows.Forms.Label();
            this.lblMusicaEdi = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.nudDia = new System.Windows.Forms.NumericUpDown();
            this.lblPlaylistDia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pibSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylist)).BeginInit();
            this.grbAddMusicaPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grbEditarMusicaPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDia)).BeginInit();
            this.SuspendLayout();
            // 
            // pibSair
            // 
            this.pibSair.BackColor = System.Drawing.Color.Transparent;
            this.pibSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pibSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibSair.Image = ((System.Drawing.Image)(resources.GetObject("pibSair.Image")));
            this.pibSair.Location = new System.Drawing.Point(811, 13);
            this.pibSair.Margin = new System.Windows.Forms.Padding(4);
            this.pibSair.Name = "pibSair";
            this.pibSair.Size = new System.Drawing.Size(39, 42);
            this.pibSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibSair.TabIndex = 22;
            this.pibSair.TabStop = false;
            this.pibSair.Click += new System.EventHandler(this.pibSair_Click);
            // 
            // dgvPlaylist
            // 
            this.dgvPlaylist.AllowUserToAddRows = false;
            this.dgvPlaylist.AllowUserToDeleteRows = false;
            this.dgvPlaylist.AllowUserToResizeColumns = false;
            this.dgvPlaylist.AllowUserToResizeRows = false;
            this.dgvPlaylist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlaylist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlaylist.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPlaylist.Location = new System.Drawing.Point(103, 84);
            this.dgvPlaylist.Name = "dgvPlaylist";
            this.dgvPlaylist.Size = new System.Drawing.Size(664, 275);
            this.dgvPlaylist.TabIndex = 23;
            this.dgvPlaylist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlaylist_CellClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(276, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(336, 39);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "     Playlist do Dia     ";
            // 
            // grbAddMusicaPlaylist
            // 
            this.grbAddMusicaPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.grbAddMusicaPlaylist.Controls.Add(this.lblPlaylistDia);
            this.grbAddMusicaPlaylist.Controls.Add(this.nudDia);
            this.grbAddMusicaPlaylist.Controls.Add(this.cmbMusica);
            this.grbAddMusicaPlaylist.Controls.Add(this.pictureBox2);
            this.grbAddMusicaPlaylist.Controls.Add(this.btnRemoverMusicaPl);
            this.grbAddMusicaPlaylist.Controls.Add(this.btnAddMusica);
            this.grbAddMusicaPlaylist.Controls.Add(this.lblAddNome);
            this.grbAddMusicaPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAddMusicaPlaylist.ForeColor = System.Drawing.Color.White;
            this.grbAddMusicaPlaylist.Location = new System.Drawing.Point(36, 381);
            this.grbAddMusicaPlaylist.Name = "grbAddMusicaPlaylist";
            this.grbAddMusicaPlaylist.Size = new System.Drawing.Size(358, 226);
            this.grbAddMusicaPlaylist.TabIndex = 25;
            this.grbAddMusicaPlaylist.TabStop = false;
            this.grbAddMusicaPlaylist.Text = "Adicionar / Remover";
            // 
            // cmbMusica
            // 
            this.cmbMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMusica.FormattingEnabled = true;
            this.cmbMusica.Location = new System.Drawing.Point(114, 51);
            this.cmbMusica.Name = "cmbMusica";
            this.cmbMusica.Size = new System.Drawing.Size(217, 28);
            this.cmbMusica.TabIndex = 21;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(281, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // btnRemoverMusicaPl
            // 
            this.btnRemoverMusicaPl.BackColor = System.Drawing.Color.IndianRed;
            this.btnRemoverMusicaPl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverMusicaPl.ForeColor = System.Drawing.Color.Black;
            this.btnRemoverMusicaPl.Location = new System.Drawing.Point(25, 183);
            this.btnRemoverMusicaPl.Name = "btnRemoverMusicaPl";
            this.btnRemoverMusicaPl.Size = new System.Drawing.Size(306, 31);
            this.btnRemoverMusicaPl.TabIndex = 19;
            this.btnRemoverMusicaPl.Text = "Remover";
            this.btnRemoverMusicaPl.UseVisualStyleBackColor = false;
            this.btnRemoverMusicaPl.Click += new System.EventHandler(this.btnRemoverMusicaPl_Click);
            // 
            // btnAddMusica
            // 
            this.btnAddMusica.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMusica.ForeColor = System.Drawing.Color.Black;
            this.btnAddMusica.Location = new System.Drawing.Point(25, 146);
            this.btnAddMusica.Name = "btnAddMusica";
            this.btnAddMusica.Size = new System.Drawing.Size(306, 31);
            this.btnAddMusica.TabIndex = 6;
            this.btnAddMusica.Text = "Adicionar";
            this.btnAddMusica.UseVisualStyleBackColor = false;
            this.btnAddMusica.Click += new System.EventHandler(this.btnAddMusica_Click);
            // 
            // lblAddNome
            // 
            this.lblAddNome.AutoSize = true;
            this.lblAddNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNome.Location = new System.Drawing.Point(21, 51);
            this.lblAddNome.Name = "lblAddNome";
            this.lblAddNome.Size = new System.Drawing.Size(66, 24);
            this.lblAddNome.TabIndex = 0;
            this.lblAddNome.Text = "Nome";
            // 
            // grbEditarMusicaPlaylist
            // 
            this.grbEditarMusicaPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.grbEditarMusicaPlaylist.Controls.Add(this.pictureBox3);
            this.grbEditarMusicaPlaylist.Controls.Add(this.cmbArtistaEdi);
            this.grbEditarMusicaPlaylist.Controls.Add(this.btnEditarMusica);
            this.grbEditarMusicaPlaylist.Controls.Add(this.txbMusicaEdi);
            this.grbEditarMusicaPlaylist.Controls.Add(this.lblArtistaEdi);
            this.grbEditarMusicaPlaylist.Controls.Add(this.lblMusicaEdi);
            this.grbEditarMusicaPlaylist.Enabled = false;
            this.grbEditarMusicaPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditarMusicaPlaylist.ForeColor = System.Drawing.Color.White;
            this.grbEditarMusicaPlaylist.Location = new System.Drawing.Point(468, 381);
            this.grbEditarMusicaPlaylist.Name = "grbEditarMusicaPlaylist";
            this.grbEditarMusicaPlaylist.Size = new System.Drawing.Size(358, 214);
            this.grbEditarMusicaPlaylist.TabIndex = 26;
            this.grbEditarMusicaPlaylist.TabStop = false;
            this.grbEditarMusicaPlaylist.Text = "Editar";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(95, -7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // cmbArtistaEdi
            // 
            this.cmbArtistaEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArtistaEdi.FormattingEnabled = true;
            this.cmbArtistaEdi.Location = new System.Drawing.Point(114, 97);
            this.cmbArtistaEdi.Name = "cmbArtistaEdi";
            this.cmbArtistaEdi.Size = new System.Drawing.Size(217, 28);
            this.cmbArtistaEdi.TabIndex = 18;
            // 
            // btnEditarMusica
            // 
            this.btnEditarMusica.BackColor = System.Drawing.Color.SandyBrown;
            this.btnEditarMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarMusica.ForeColor = System.Drawing.Color.Black;
            this.btnEditarMusica.Location = new System.Drawing.Point(25, 154);
            this.btnEditarMusica.Name = "btnEditarMusica";
            this.btnEditarMusica.Size = new System.Drawing.Size(306, 31);
            this.btnEditarMusica.TabIndex = 6;
            this.btnEditarMusica.Text = "Editar";
            this.btnEditarMusica.UseVisualStyleBackColor = false;
            this.btnEditarMusica.Click += new System.EventHandler(this.btnEditarMusica_Click);
            // 
            // txbMusicaEdi
            // 
            this.txbMusicaEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMusicaEdi.Location = new System.Drawing.Point(114, 64);
            this.txbMusicaEdi.Name = "txbMusicaEdi";
            this.txbMusicaEdi.Size = new System.Drawing.Size(217, 26);
            this.txbMusicaEdi.TabIndex = 2;
            // 
            // lblArtistaEdi
            // 
            this.lblArtistaEdi.AutoSize = true;
            this.lblArtistaEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistaEdi.Location = new System.Drawing.Point(21, 97);
            this.lblArtistaEdi.Name = "lblArtistaEdi";
            this.lblArtistaEdi.Size = new System.Drawing.Size(91, 24);
            this.lblArtistaEdi.TabIndex = 1;
            this.lblArtistaEdi.Text = "Artista(s)";
            // 
            // lblMusicaEdi
            // 
            this.lblMusicaEdi.AutoSize = true;
            this.lblMusicaEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMusicaEdi.Location = new System.Drawing.Point(21, 64);
            this.lblMusicaEdi.Name = "lblMusicaEdi";
            this.lblMusicaEdi.Size = new System.Drawing.Size(66, 24);
            this.lblMusicaEdi.TabIndex = 0;
            this.lblMusicaEdi.Text = "Nome";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.BackColor = System.Drawing.Color.Transparent;
            this.lblDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.ForeColor = System.Drawing.Color.White;
            this.lblDia.Location = new System.Drawing.Point(376, 54);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(2, 27);
            this.lblDia.TabIndex = 27;
            // 
            // nudDia
            // 
            this.nudDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDia.Location = new System.Drawing.Point(114, 97);
            this.nudDia.Name = "nudDia";
            this.nudDia.Size = new System.Drawing.Size(107, 26);
            this.nudDia.TabIndex = 22;
            // 
            // lblPlaylistDia
            // 
            this.lblPlaylistDia.AutoSize = true;
            this.lblPlaylistDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistDia.Location = new System.Drawing.Point(47, 99);
            this.lblPlaylistDia.Name = "lblPlaylistDia";
            this.lblPlaylistDia.Size = new System.Drawing.Size(40, 24);
            this.lblPlaylistDia.TabIndex = 23;
            this.lblPlaylistDia.Text = "Dia";
            // 
            // GerenciamentoPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 663);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.grbEditarMusicaPlaylist);
            this.Controls.Add(this.grbAddMusicaPlaylist);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvPlaylist);
            this.Controls.Add(this.pibSair);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GerenciamentoPlaylist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Playlist";
            ((System.ComponentModel.ISupportInitialize)(this.pibSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylist)).EndInit();
            this.grbAddMusicaPlaylist.ResumeLayout(false);
            this.grbAddMusicaPlaylist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grbEditarMusicaPlaylist.ResumeLayout(false);
            this.grbEditarMusicaPlaylist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibSair;
        private System.Windows.Forms.DataGridView dgvPlaylist;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grbAddMusicaPlaylist;
        private System.Windows.Forms.Button btnRemoverMusicaPl;
        private System.Windows.Forms.Button btnAddMusica;
        private System.Windows.Forms.Label lblAddNome;
        private System.Windows.Forms.GroupBox grbEditarMusicaPlaylist;
        private System.Windows.Forms.ComboBox cmbArtistaEdi;
        private System.Windows.Forms.Button btnEditarMusica;
        private System.Windows.Forms.TextBox txbMusicaEdi;
        private System.Windows.Forms.Label lblArtistaEdi;
        private System.Windows.Forms.Label lblMusicaEdi;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cmbMusica;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblPlaylistDia;
        private System.Windows.Forms.NumericUpDown nudDia;
    }
}