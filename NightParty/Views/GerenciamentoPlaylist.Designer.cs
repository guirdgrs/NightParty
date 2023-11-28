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
            this.lblPlaylistDia = new System.Windows.Forms.Label();
            this.cmbMusica = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRemoverMusicaPl = new System.Windows.Forms.Button();
            this.btnAddMusica = new System.Windows.Forms.Button();
            this.lblAddNome = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.nudDia = new System.Windows.Forms.NumericUpDown();
            this.txbMusicaAdd = new System.Windows.Forms.TextBox();
            this.lblMAdd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pibSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylist)).BeginInit();
            this.grbAddMusicaPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.grbAddMusicaPlaylist.Controls.Add(this.lblMAdd);
            this.grbAddMusicaPlaylist.Controls.Add(this.txbMusicaAdd);
            this.grbAddMusicaPlaylist.Controls.Add(this.lblPlaylistDia);
            this.grbAddMusicaPlaylist.Controls.Add(this.nudDia);
            this.grbAddMusicaPlaylist.Controls.Add(this.cmbMusica);
            this.grbAddMusicaPlaylist.Controls.Add(this.pictureBox2);
            this.grbAddMusicaPlaylist.Controls.Add(this.btnRemoverMusicaPl);
            this.grbAddMusicaPlaylist.Controls.Add(this.btnAddMusica);
            this.grbAddMusicaPlaylist.Controls.Add(this.lblAddNome);
            this.grbAddMusicaPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAddMusicaPlaylist.ForeColor = System.Drawing.Color.White;
            this.grbAddMusicaPlaylist.Location = new System.Drawing.Point(103, 384);
            this.grbAddMusicaPlaylist.Name = "grbAddMusicaPlaylist";
            this.grbAddMusicaPlaylist.Size = new System.Drawing.Size(664, 159);
            this.grbAddMusicaPlaylist.TabIndex = 25;
            this.grbAddMusicaPlaylist.TabStop = false;
            this.grbAddMusicaPlaylist.Text = "Adicionar / Remover";
            // 
            // lblPlaylistDia
            // 
            this.lblPlaylistDia.AutoSize = true;
            this.lblPlaylistDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylistDia.Location = new System.Drawing.Point(56, 114);
            this.lblPlaylistDia.Name = "lblPlaylistDia";
            this.lblPlaylistDia.Size = new System.Drawing.Size(40, 24);
            this.lblPlaylistDia.TabIndex = 23;
            this.lblPlaylistDia.Text = "Dia";
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
            this.btnRemoverMusicaPl.Location = new System.Drawing.Point(352, 107);
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
            this.btnAddMusica.Location = new System.Drawing.Point(352, 53);
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
            this.lblAddNome.Location = new System.Drawing.Point(30, 53);
            this.lblAddNome.Name = "lblAddNome";
            this.lblAddNome.Size = new System.Drawing.Size(66, 24);
            this.lblAddNome.TabIndex = 0;
            this.lblAddNome.Text = "Nome";
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
            this.nudDia.Location = new System.Drawing.Point(114, 115);
            this.nudDia.Name = "nudDia";
            this.nudDia.Size = new System.Drawing.Size(69, 26);
            this.nudDia.TabIndex = 22;
            // 
            // txbMusicaAdd
            // 
            this.txbMusicaAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMusicaAdd.Location = new System.Drawing.Point(114, 83);
            this.txbMusicaAdd.Name = "txbMusicaAdd";
            this.txbMusicaAdd.ReadOnly = true;
            this.txbMusicaAdd.Size = new System.Drawing.Size(217, 26);
            this.txbMusicaAdd.TabIndex = 24;
            // 
            // lblMAdd
            // 
            this.lblMAdd.AutoSize = true;
            this.lblMAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAdd.Location = new System.Drawing.Point(30, 85);
            this.lblMAdd.Name = "lblMAdd";
            this.lblMAdd.Size = new System.Drawing.Size(66, 24);
            this.lblMAdd.TabIndex = 25;
            this.lblMAdd.Text = "Nome";
            // 
            // GerenciamentoPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 582);
            this.Controls.Add(this.lblDia);
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cmbMusica;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblPlaylistDia;
        private System.Windows.Forms.NumericUpDown nudDia;
        private System.Windows.Forms.Label lblMAdd;
        private System.Windows.Forms.TextBox txbMusicaAdd;
    }
}