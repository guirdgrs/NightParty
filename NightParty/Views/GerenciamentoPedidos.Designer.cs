﻿namespace NightParty.Views
{
    partial class GerenciamentoPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciamentoPedidos));
            this.pibSair = new System.Windows.Forms.PictureBox();
            this.dgvBebidas = new System.Windows.Forms.DataGridView();
            this.dgvComida = new System.Windows.Forms.DataGridView();
            this.grbPedido = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pibP2 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLancar = new System.Windows.Forms.Button();
            this.nudQtdComida = new System.Windows.Forms.NumericUpDown();
            this.nudQtdBebida = new System.Windows.Forms.NumericUpDown();
            this.txbComida = new System.Windows.Forms.TextBox();
            this.txbBebida = new System.Windows.Forms.TextBox();
            this.lblComida = new System.Windows.Forms.Label();
            this.lblBebida = new System.Windows.Forms.Label();
            this.grbLancamento = new System.Windows.Forms.GroupBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.txbIdProduto = new System.Windows.Forms.TextBox();
            this.txbMesa = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblMesa = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pibSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComida)).BeginInit();
            this.grbPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdComida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdBebida)).BeginInit();
            this.grbLancamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pibSair
            // 
            this.pibSair.BackColor = System.Drawing.Color.Transparent;
            this.pibSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pibSair.Image = ((System.Drawing.Image)(resources.GetObject("pibSair.Image")));
            this.pibSair.Location = new System.Drawing.Point(956, 30);
            this.pibSair.Name = "pibSair";
            this.pibSair.Size = new System.Drawing.Size(41, 41);
            this.pibSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibSair.TabIndex = 2;
            this.pibSair.TabStop = false;
            this.pibSair.Click += new System.EventHandler(this.pibSair_Click);
            // 
            // dgvBebidas
            // 
            this.dgvBebidas.AllowUserToAddRows = false;
            this.dgvBebidas.AllowUserToDeleteRows = false;
            this.dgvBebidas.AllowUserToResizeColumns = false;
            this.dgvBebidas.AllowUserToResizeRows = false;
            this.dgvBebidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBebidas.Location = new System.Drawing.Point(12, 60);
            this.dgvBebidas.Name = "dgvBebidas";
            this.dgvBebidas.Size = new System.Drawing.Size(416, 207);
            this.dgvBebidas.TabIndex = 3;
            this.dgvBebidas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBebidas_CellClick);
            // 
            // dgvComida
            // 
            this.dgvComida.AllowUserToAddRows = false;
            this.dgvComida.AllowUserToDeleteRows = false;
            this.dgvComida.AllowUserToResizeColumns = false;
            this.dgvComida.AllowUserToResizeRows = false;
            this.dgvComida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComida.Location = new System.Drawing.Point(507, 60);
            this.dgvComida.Name = "dgvComida";
            this.dgvComida.Size = new System.Drawing.Size(416, 207);
            this.dgvComida.TabIndex = 4;
            this.dgvComida.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComida_CellClick);
            // 
            // grbPedido
            // 
            this.grbPedido.BackColor = System.Drawing.Color.Transparent;
            this.grbPedido.Controls.Add(this.pictureBox2);
            this.grbPedido.Controls.Add(this.pictureBox1);
            this.grbPedido.Controls.Add(this.pibP2);
            this.grbPedido.Controls.Add(this.btnCancelar);
            this.grbPedido.Controls.Add(this.btnLancar);
            this.grbPedido.Controls.Add(this.nudQtdComida);
            this.grbPedido.Controls.Add(this.nudQtdBebida);
            this.grbPedido.Controls.Add(this.txbComida);
            this.grbPedido.Controls.Add(this.txbBebida);
            this.grbPedido.Controls.Add(this.lblComida);
            this.grbPedido.Controls.Add(this.lblBebida);
            this.grbPedido.Enabled = false;
            this.grbPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPedido.ForeColor = System.Drawing.Color.White;
            this.grbPedido.Location = new System.Drawing.Point(12, 326);
            this.grbPedido.Name = "grbPedido";
            this.grbPedido.Size = new System.Drawing.Size(416, 170);
            this.grbPedido.TabIndex = 5;
            this.grbPedido.TabStop = false;
            this.grbPedido.Text = "Pedido";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(99, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pibP2
            // 
            this.pibP2.BackColor = System.Drawing.Color.Transparent;
            this.pibP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pibP2.Image = ((System.Drawing.Image)(resources.GetObject("pibP2.Image")));
            this.pibP2.Location = new System.Drawing.Point(6, 42);
            this.pibP2.Name = "pibP2";
            this.pibP2.Size = new System.Drawing.Size(34, 29);
            this.pibP2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibP2.TabIndex = 15;
            this.pibP2.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(220, 123);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(177, 31);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLancar
            // 
            this.btnLancar.BackColor = System.Drawing.Color.LightGreen;
            this.btnLancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancar.ForeColor = System.Drawing.Color.Black;
            this.btnLancar.Location = new System.Drawing.Point(24, 123);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(177, 31);
            this.btnLancar.TabIndex = 6;
            this.btnLancar.Text = "Lançar Pedido";
            this.btnLancar.UseVisualStyleBackColor = false;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // nudQtdComida
            // 
            this.nudQtdComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQtdComida.Location = new System.Drawing.Point(325, 81);
            this.nudQtdComida.Name = "nudQtdComida";
            this.nudQtdComida.Size = new System.Drawing.Size(72, 26);
            this.nudQtdComida.TabIndex = 5;
            // 
            // nudQtdBebida
            // 
            this.nudQtdBebida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQtdBebida.Location = new System.Drawing.Point(325, 44);
            this.nudQtdBebida.Name = "nudQtdBebida";
            this.nudQtdBebida.Size = new System.Drawing.Size(72, 26);
            this.nudQtdBebida.TabIndex = 4;
            // 
            // txbComida
            // 
            this.txbComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbComida.Location = new System.Drawing.Point(152, 80);
            this.txbComida.Name = "txbComida";
            this.txbComida.Size = new System.Drawing.Size(167, 26);
            this.txbComida.TabIndex = 3;
            // 
            // txbBebida
            // 
            this.txbBebida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBebida.Location = new System.Drawing.Point(152, 47);
            this.txbBebida.Name = "txbBebida";
            this.txbBebida.Size = new System.Drawing.Size(167, 26);
            this.txbBebida.TabIndex = 2;
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComida.Location = new System.Drawing.Point(47, 81);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(81, 24);
            this.lblComida.TabIndex = 1;
            this.lblComida.Text = "Comida";
            // 
            // lblBebida
            // 
            this.lblBebida.AutoSize = true;
            this.lblBebida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebida.Location = new System.Drawing.Point(47, 47);
            this.lblBebida.Name = "lblBebida";
            this.lblBebida.Size = new System.Drawing.Size(75, 24);
            this.lblBebida.TabIndex = 0;
            this.lblBebida.Text = "Bebida";
            // 
            // grbLancamento
            // 
            this.grbLancamento.BackColor = System.Drawing.Color.Transparent;
            this.grbLancamento.Controls.Add(this.pictureBox7);
            this.grbLancamento.Controls.Add(this.pictureBox6);
            this.grbLancamento.Controls.Add(this.pictureBox3);
            this.grbLancamento.Controls.Add(this.btnContinuar);
            this.grbLancamento.Controls.Add(this.txbIdProduto);
            this.grbLancamento.Controls.Add(this.txbMesa);
            this.grbLancamento.Controls.Add(this.lblProduto);
            this.grbLancamento.Controls.Add(this.lblMesa);
            this.grbLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLancamento.ForeColor = System.Drawing.Color.White;
            this.grbLancamento.Location = new System.Drawing.Point(599, 326);
            this.grbLancamento.Name = "grbLancamento";
            this.grbLancamento.Size = new System.Drawing.Size(265, 170);
            this.grbLancamento.TabIndex = 8;
            this.grbLancamento.TabStop = false;
            this.grbLancamento.Text = "Lançamento";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(225, 78);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(34, 29);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(225, 45);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(34, 29);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(169, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.LightGreen;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.Color.Black;
            this.btnContinuar.Location = new System.Drawing.Point(6, 123);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(253, 31);
            this.btnContinuar.TabIndex = 6;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // txbIdProduto
            // 
            this.txbIdProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdProduto.Location = new System.Drawing.Point(120, 80);
            this.txbIdProduto.Name = "txbIdProduto";
            this.txbIdProduto.Size = new System.Drawing.Size(97, 26);
            this.txbIdProduto.TabIndex = 3;
            // 
            // txbMesa
            // 
            this.txbMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMesa.Location = new System.Drawing.Point(120, 43);
            this.txbMesa.Name = "txbMesa";
            this.txbMesa.Size = new System.Drawing.Size(97, 26);
            this.txbMesa.TabIndex = 2;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(20, 80);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(83, 24);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "Produto";
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesa.Location = new System.Drawing.Point(20, 43);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(60, 24);
            this.lblMesa.TabIndex = 0;
            this.lblMesa.Text = "Mesa";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(409, 251);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(498, 251);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 29);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(337, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(273, 44);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "     Pedidos     ";
            // 
            // GerenciamentoPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1009, 536);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.grbLancamento);
            this.Controls.Add(this.grbPedido);
            this.Controls.Add(this.dgvComida);
            this.Controls.Add(this.dgvBebidas);
            this.Controls.Add(this.pibSair);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GerenciamentoPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.pibSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBebidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComida)).EndInit();
            this.grbPedido.ResumeLayout(false);
            this.grbPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdComida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdBebida)).EndInit();
            this.grbLancamento.ResumeLayout(false);
            this.grbLancamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibSair;
        private System.Windows.Forms.DataGridView dgvBebidas;
        private System.Windows.Forms.DataGridView dgvComida;
        private System.Windows.Forms.GroupBox grbPedido;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.NumericUpDown nudQtdComida;
        private System.Windows.Forms.NumericUpDown nudQtdBebida;
        private System.Windows.Forms.TextBox txbComida;
        private System.Windows.Forms.TextBox txbBebida;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.Label lblBebida;
        private System.Windows.Forms.GroupBox grbLancamento;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox txbIdProduto;
        private System.Windows.Forms.TextBox txbMesa;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.PictureBox pibP2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}