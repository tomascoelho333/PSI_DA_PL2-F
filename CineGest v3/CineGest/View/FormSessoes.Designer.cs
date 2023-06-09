﻿using System;

namespace WindowsFormsApp1.View
{
    partial class FormSessoes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSessoes));
            this.pbGestao = new System.Windows.Forms.PictureBox();
            this.lblgestao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbSair = new System.Windows.Forms.PictureBox();
            this.pbClientes = new System.Windows.Forms.PictureBox();
            this.pbDashboard = new System.Windows.Forms.PictureBox();
            this.pbSessoes = new System.Windows.Forms.PictureBox();
            this.pbFilmes = new System.Windows.Forms.PictureBox();
            this.pbCinema = new System.Windows.Forms.PictureBox();
            this.pbLogoMenu = new System.Windows.Forms.PictureBox();
            this.lb_data = new System.Windows.Forms.Label();
            this.painelContentor = new System.Windows.Forms.Panel();
            this.dataGridView_Users = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessaoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cineGestDataSet2 = new WindowsFormsApp1.CineGestDataSet2();
            this.gbConfigSessoes = new System.Windows.Forms.GroupBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.horaPicker = new System.Windows.Forms.DateTimePicker();
            this.txtValorBilhete = new System.Windows.Forms.TextBox();
            this.lblValorBilhete = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.dataPicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxFilmes = new System.Windows.Forms.ComboBox();
            this.comboBoxSalas = new System.Windows.Forms.ComboBox();
            this.btnAdicionarSessão = new System.Windows.Forms.Button();
            this.lblEscolherFilme = new System.Windows.Forms.Label();
            this.lblEscolherSala = new System.Windows.Forms.Label();
            this.sessaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pbAtendimento = new System.Windows.Forms.PictureBox();
            this.lblUpperMenu = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblSessoes = new System.Windows.Forms.Label();
            this.lblFilmes = new System.Windows.Forms.Label();
            this.lblCinema = new System.Windows.Forms.Label();
            this.lblAtendimento = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.lblMenuMenu = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.cineGestDataSetSessoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cineGestDataSetSessoesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sessaoTableAdapter = new WindowsFormsApp1.CineGestDataSet2TableAdapters.SessaoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pbGestao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSessoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilmes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCinema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoMenu)).BeginInit();
            this.painelContentor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessaoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet2)).BeginInit();
            this.gbConfigSessoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtendimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSetSessoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSetSessoesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGestao
            // 
            this.pbGestao.Image = ((System.Drawing.Image)(resources.GetObject("pbGestao.Image")));
            this.pbGestao.Location = new System.Drawing.Point(47, 459);
            this.pbGestao.Margin = new System.Windows.Forms.Padding(2);
            this.pbGestao.Name = "pbGestao";
            this.pbGestao.Size = new System.Drawing.Size(33, 38);
            this.pbGestao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGestao.TabIndex = 75;
            this.pbGestao.TabStop = false;
            this.pbGestao.Visible = false;
            this.pbGestao.Click += new System.EventHandler(this.lblgestao_click);
            // 
            // lblgestao
            // 
            this.lblgestao.AutoSize = true;
            this.lblgestao.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgestao.ForeColor = System.Drawing.Color.White;
            this.lblgestao.Location = new System.Drawing.Point(87, 463);
            this.lblgestao.Name = "lblgestao";
            this.lblgestao.Size = new System.Drawing.Size(79, 24);
            this.lblgestao.TabIndex = 74;
            this.lblgestao.Text = "Gestão";
            this.lblgestao.Visible = false;
            this.lblgestao.Click += new System.EventHandler(this.lblgestao_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(245, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 567);
            this.label1.TabIndex = 73;
            // 
            // pbSair
            // 
            this.pbSair.Image = ((System.Drawing.Image)(resources.GetObject("pbSair.Image")));
            this.pbSair.Location = new System.Drawing.Point(11, 525);
            this.pbSair.Margin = new System.Windows.Forms.Padding(2);
            this.pbSair.Name = "pbSair";
            this.pbSair.Size = new System.Drawing.Size(36, 28);
            this.pbSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSair.TabIndex = 72;
            this.pbSair.TabStop = false;
            this.pbSair.Click += new System.EventHandler(this.pbSair_Click);
            // 
            // pbClientes
            // 
            this.pbClientes.Image = ((System.Drawing.Image)(resources.GetObject("pbClientes.Image")));
            this.pbClientes.Location = new System.Drawing.Point(47, 413);
            this.pbClientes.Margin = new System.Windows.Forms.Padding(2);
            this.pbClientes.Name = "pbClientes";
            this.pbClientes.Size = new System.Drawing.Size(33, 38);
            this.pbClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClientes.TabIndex = 71;
            this.pbClientes.TabStop = false;
            this.pbClientes.Click += new System.EventHandler(this.lblClientes_Click);
            // 
            // pbDashboard
            // 
            this.pbDashboard.Image = ((System.Drawing.Image)(resources.GetObject("pbDashboard.Image")));
            this.pbDashboard.Location = new System.Drawing.Point(45, 181);
            this.pbDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.pbDashboard.Name = "pbDashboard";
            this.pbDashboard.Size = new System.Drawing.Size(33, 38);
            this.pbDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDashboard.TabIndex = 66;
            this.pbDashboard.TabStop = false;
            this.pbDashboard.Click += new System.EventHandler(this.lblDashboard_Click);
            // 
            // pbSessoes
            // 
            this.pbSessoes.Image = ((System.Drawing.Image)(resources.GetObject("pbSessoes.Image")));
            this.pbSessoes.Location = new System.Drawing.Point(46, 228);
            this.pbSessoes.Margin = new System.Windows.Forms.Padding(2);
            this.pbSessoes.Name = "pbSessoes";
            this.pbSessoes.Size = new System.Drawing.Size(33, 38);
            this.pbSessoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSessoes.TabIndex = 68;
            this.pbSessoes.TabStop = false;
            // 
            // pbFilmes
            // 
            this.pbFilmes.Image = ((System.Drawing.Image)(resources.GetObject("pbFilmes.Image")));
            this.pbFilmes.Location = new System.Drawing.Point(46, 368);
            this.pbFilmes.Margin = new System.Windows.Forms.Padding(2);
            this.pbFilmes.Name = "pbFilmes";
            this.pbFilmes.Size = new System.Drawing.Size(33, 38);
            this.pbFilmes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFilmes.TabIndex = 69;
            this.pbFilmes.TabStop = false;
            this.pbFilmes.Click += new System.EventHandler(this.lblFilmes_Click);
            // 
            // pbCinema
            // 
            this.pbCinema.Image = ((System.Drawing.Image)(resources.GetObject("pbCinema.Image")));
            this.pbCinema.Location = new System.Drawing.Point(46, 320);
            this.pbCinema.Margin = new System.Windows.Forms.Padding(2);
            this.pbCinema.Name = "pbCinema";
            this.pbCinema.Size = new System.Drawing.Size(33, 38);
            this.pbCinema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCinema.TabIndex = 70;
            this.pbCinema.TabStop = false;
            this.pbCinema.Click += new System.EventHandler(this.lblCinema_Click);
            // 
            // pbLogoMenu
            // 
            this.pbLogoMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoMenu.Image")));
            this.pbLogoMenu.Location = new System.Drawing.Point(23, 18);
            this.pbLogoMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogoMenu.Name = "pbLogoMenu";
            this.pbLogoMenu.Size = new System.Drawing.Size(196, 86);
            this.pbLogoMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoMenu.TabIndex = 65;
            this.pbLogoMenu.TabStop = false;
            // 
            // lb_data
            // 
            this.lb_data.BackColor = System.Drawing.Color.Silver;
            this.lb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data.Location = new System.Drawing.Point(245, 6);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(207, 20);
            this.lb_data.TabIndex = 64;
            // 
            // painelContentor
            // 
            this.painelContentor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.painelContentor.Controls.Add(this.dataGridView_Users);
            this.painelContentor.Controls.Add(this.gbConfigSessoes);
            this.painelContentor.Location = new System.Drawing.Point(246, 30);
            this.painelContentor.Name = "painelContentor";
            this.painelContentor.Size = new System.Drawing.Size(782, 537);
            this.painelContentor.TabIndex = 63;
            // 
            // dataGridView_Users
            // 
            this.dataGridView_Users.AutoGenerateColumns = false;
            this.dataGridView_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.filmeDataGridViewTextBoxColumn,
            this.salaDataGridViewTextBoxColumn});
            this.dataGridView_Users.DataSource = this.sessaoBindingSource1;
            this.dataGridView_Users.Location = new System.Drawing.Point(96, 279);
            this.dataGridView_Users.Name = "dataGridView_Users";
            this.dataGridView_Users.Size = new System.Drawing.Size(538, 216);
            this.dataGridView_Users.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DataHora";
            this.dataGridViewTextBoxColumn2.HeaderText = "DataHora";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Preco";
            this.dataGridViewTextBoxColumn3.HeaderText = "Preco";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // filmeDataGridViewTextBoxColumn
            // 
            this.filmeDataGridViewTextBoxColumn.DataPropertyName = "Filme";
            this.filmeDataGridViewTextBoxColumn.HeaderText = "Filme";
            this.filmeDataGridViewTextBoxColumn.Name = "filmeDataGridViewTextBoxColumn";
            // 
            // salaDataGridViewTextBoxColumn
            // 
            this.salaDataGridViewTextBoxColumn.DataPropertyName = "Sala";
            this.salaDataGridViewTextBoxColumn.HeaderText = "Sala";
            this.salaDataGridViewTextBoxColumn.Name = "salaDataGridViewTextBoxColumn";
            // 
            // sessaoBindingSource1
            // 
            this.sessaoBindingSource1.DataMember = "Sessao";
            this.sessaoBindingSource1.DataSource = this.cineGestDataSet2;
            // 
            // cineGestDataSet2
            // 
            this.cineGestDataSet2.DataSetName = "CineGestDataSet2";
            this.cineGestDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbConfigSessoes
            // 
            this.gbConfigSessoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.gbConfigSessoes.Controls.Add(this.lblHora);
            this.gbConfigSessoes.Controls.Add(this.horaPicker);
            this.gbConfigSessoes.Controls.Add(this.txtValorBilhete);
            this.gbConfigSessoes.Controls.Add(this.lblValorBilhete);
            this.gbConfigSessoes.Controls.Add(this.lblData);
            this.gbConfigSessoes.Controls.Add(this.dataPicker);
            this.gbConfigSessoes.Controls.Add(this.comboBoxFilmes);
            this.gbConfigSessoes.Controls.Add(this.comboBoxSalas);
            this.gbConfigSessoes.Controls.Add(this.btnAdicionarSessão);
            this.gbConfigSessoes.Controls.Add(this.lblEscolherFilme);
            this.gbConfigSessoes.Controls.Add(this.lblEscolherSala);
            this.gbConfigSessoes.Location = new System.Drawing.Point(103, 48);
            this.gbConfigSessoes.Name = "gbConfigSessoes";
            this.gbConfigSessoes.Size = new System.Drawing.Size(576, 214);
            this.gbConfigSessoes.TabIndex = 4;
            this.gbConfigSessoes.TabStop = false;
            this.gbConfigSessoes.Text = "Criar Sessões";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblHora.Location = new System.Drawing.Point(23, 182);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(43, 17);
            this.lblHora.TabIndex = 13;
            this.lblHora.Text = "Hora:";
            // 
            // horaPicker
            // 
            this.horaPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horaPicker.Location = new System.Drawing.Point(70, 182);
            this.horaPicker.Name = "horaPicker";
            this.horaPicker.Size = new System.Drawing.Size(101, 20);
            this.horaPicker.TabIndex = 12;
            // 
            // txtValorBilhete
            // 
            this.txtValorBilhete.Location = new System.Drawing.Point(192, 112);
            this.txtValorBilhete.Name = "txtValorBilhete";
            this.txtValorBilhete.Size = new System.Drawing.Size(97, 20);
            this.txtValorBilhete.TabIndex = 11;
            // 
            // lblValorBilhete
            // 
            this.lblValorBilhete.AutoSize = true;
            this.lblValorBilhete.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblValorBilhete.Location = new System.Drawing.Point(23, 113);
            this.lblValorBilhete.Name = "lblValorBilhete";
            this.lblValorBilhete.Size = new System.Drawing.Size(163, 17);
            this.lblValorBilhete.TabIndex = 10;
            this.lblValorBilhete.Text = "Valor do Bilhete (euros):";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblData.Location = new System.Drawing.Point(23, 150);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(43, 17);
            this.lblData.TabIndex = 9;
            this.lblData.Text = "Data:";
            // 
            // dataPicker
            // 
            this.dataPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataPicker.Location = new System.Drawing.Point(70, 150);
            this.dataPicker.Name = "dataPicker";
            this.dataPicker.Size = new System.Drawing.Size(101, 20);
            this.dataPicker.TabIndex = 8;
            // 
            // comboBoxFilmes
            // 
            this.comboBoxFilmes.FormattingEnabled = true;
            this.comboBoxFilmes.Location = new System.Drawing.Point(70, 74);
            this.comboBoxFilmes.Name = "comboBoxFilmes";
            this.comboBoxFilmes.Size = new System.Drawing.Size(219, 21);
            this.comboBoxFilmes.TabIndex = 7;
            // 
            // comboBoxSalas
            // 
            this.comboBoxSalas.FormattingEnabled = true;
            this.comboBoxSalas.Location = new System.Drawing.Point(70, 38);
            this.comboBoxSalas.Name = "comboBoxSalas";
            this.comboBoxSalas.Size = new System.Drawing.Size(219, 21);
            this.comboBoxSalas.TabIndex = 6;
            // 
            // btnAdicionarSessão
            // 
            this.btnAdicionarSessão.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.btnAdicionarSessão.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(185)))), ((int)(((byte)(221)))));
            this.btnAdicionarSessão.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarSessão.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnAdicionarSessão.Location = new System.Drawing.Point(374, 65);
            this.btnAdicionarSessão.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionarSessão.Name = "btnAdicionarSessão";
            this.btnAdicionarSessão.Size = new System.Drawing.Size(143, 76);
            this.btnAdicionarSessão.TabIndex = 5;
            this.btnAdicionarSessão.Text = "ADICIONAR SESSÃO";
            this.btnAdicionarSessão.UseVisualStyleBackColor = false;
            this.btnAdicionarSessão.Click += new System.EventHandler(this.btnAdicionarSessão_Click);
            // 
            // lblEscolherFilme
            // 
            this.lblEscolherFilme.AutoSize = true;
            this.lblEscolherFilme.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblEscolherFilme.Location = new System.Drawing.Point(23, 75);
            this.lblEscolherFilme.Name = "lblEscolherFilme";
            this.lblEscolherFilme.Size = new System.Drawing.Size(48, 17);
            this.lblEscolherFilme.TabIndex = 1;
            this.lblEscolherFilme.Text = "Filme:";
            // 
            // lblEscolherSala
            // 
            this.lblEscolherSala.AutoSize = true;
            this.lblEscolherSala.Font = new System.Drawing.Font("Arial", 10.75F);
            this.lblEscolherSala.Location = new System.Drawing.Point(23, 39);
            this.lblEscolherSala.Name = "lblEscolherSala";
            this.lblEscolherSala.Size = new System.Drawing.Size(41, 17);
            this.lblEscolherSala.TabIndex = 0;
            this.lblEscolherSala.Text = "Sala:";
            // 
            // sessaoBindingSource
            // 
            this.sessaoBindingSource.DataMember = "Sessao";
            // 
            // pbAtendimento
            // 
            this.pbAtendimento.Image = ((System.Drawing.Image)(resources.GetObject("pbAtendimento.Image")));
            this.pbAtendimento.Location = new System.Drawing.Point(40, 272);
            this.pbAtendimento.Margin = new System.Windows.Forms.Padding(2);
            this.pbAtendimento.Name = "pbAtendimento";
            this.pbAtendimento.Size = new System.Drawing.Size(40, 39);
            this.pbAtendimento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAtendimento.TabIndex = 67;
            this.pbAtendimento.TabStop = false;
            this.pbAtendimento.Click += new System.EventHandler(this.lblAtendimento_Click);
            // 
            // lblUpperMenu
            // 
            this.lblUpperMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.lblUpperMenu.Location = new System.Drawing.Point(246, 0);
            this.lblUpperMenu.Name = "lblUpperMenu";
            this.lblUpperMenu.Size = new System.Drawing.Size(782, 31);
            this.lblUpperMenu.TabIndex = 62;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.White;
            this.lblClientes.Location = new System.Drawing.Point(87, 417);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(86, 24);
            this.lblClientes.TabIndex = 61;
            this.lblClientes.Text = "Clientes";
            this.lblClientes.Click += new System.EventHandler(this.lblClientes_Click);
            // 
            // lblSessoes
            // 
            this.lblSessoes.AutoSize = true;
            this.lblSessoes.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessoes.ForeColor = System.Drawing.Color.White;
            this.lblSessoes.Location = new System.Drawing.Point(86, 232);
            this.lblSessoes.Name = "lblSessoes";
            this.lblSessoes.Size = new System.Drawing.Size(93, 24);
            this.lblSessoes.TabIndex = 60;
            this.lblSessoes.Text = "Sessões";
            // 
            // lblFilmes
            // 
            this.lblFilmes.AutoSize = true;
            this.lblFilmes.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmes.ForeColor = System.Drawing.Color.White;
            this.lblFilmes.Location = new System.Drawing.Point(86, 373);
            this.lblFilmes.Name = "lblFilmes";
            this.lblFilmes.Size = new System.Drawing.Size(71, 24);
            this.lblFilmes.TabIndex = 59;
            this.lblFilmes.Text = "Filmes";
            this.lblFilmes.Click += new System.EventHandler(this.lblFilmes_Click);
            // 
            // lblCinema
            // 
            this.lblCinema.AutoSize = true;
            this.lblCinema.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCinema.ForeColor = System.Drawing.Color.White;
            this.lblCinema.Location = new System.Drawing.Point(86, 325);
            this.lblCinema.Name = "lblCinema";
            this.lblCinema.Size = new System.Drawing.Size(81, 24);
            this.lblCinema.TabIndex = 58;
            this.lblCinema.Text = "Cinema";
            this.lblCinema.Click += new System.EventHandler(this.lblCinema_Click);
            // 
            // lblAtendimento
            // 
            this.lblAtendimento.AutoSize = true;
            this.lblAtendimento.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtendimento.ForeColor = System.Drawing.Color.White;
            this.lblAtendimento.Location = new System.Drawing.Point(85, 280);
            this.lblAtendimento.Name = "lblAtendimento";
            this.lblAtendimento.Size = new System.Drawing.Size(125, 24);
            this.lblAtendimento.TabIndex = 57;
            this.lblAtendimento.Text = "Atendimento";
            this.lblAtendimento.Click += new System.EventHandler(this.lblAtendimento_Click);
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.Color.White;
            this.lblDashboard.Location = new System.Drawing.Point(85, 190);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(112, 24);
            this.lblDashboard.TabIndex = 56;
            this.lblDashboard.Text = "Dashboard";
            this.lblDashboard.Click += new System.EventHandler(this.lblDashboard_Click);
            // 
            // lblMenuMenu
            // 
            this.lblMenuMenu.AutoSize = true;
            this.lblMenuMenu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenuMenu.Location = new System.Drawing.Point(27, 150);
            this.lblMenuMenu.Name = "lblMenuMenu";
            this.lblMenuMenu.Size = new System.Drawing.Size(43, 17);
            this.lblMenuMenu.TabIndex = 55;
            this.lblMenuMenu.Text = "Menu";
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Silver;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(744, 6);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(271, 20);
            this.lblInfo.TabIndex = 76;
            // 
            // sessaoTableAdapter
            // 
            this.sessaoTableAdapter.ClearBeforeFill = true;
            // 
            // FormSessoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1027, 564);
            this.ControlBox = false;
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pbGestao);
            this.Controls.Add(this.lblgestao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbSair);
            this.Controls.Add(this.pbClientes);
            this.Controls.Add(this.pbDashboard);
            this.Controls.Add(this.pbSessoes);
            this.Controls.Add(this.pbFilmes);
            this.Controls.Add(this.pbCinema);
            this.Controls.Add(this.pbLogoMenu);
            this.Controls.Add(this.lb_data);
            this.Controls.Add(this.painelContentor);
            this.Controls.Add(this.pbAtendimento);
            this.Controls.Add(this.lblUpperMenu);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.lblSessoes);
            this.Controls.Add(this.lblFilmes);
            this.Controls.Add(this.lblCinema);
            this.Controls.Add(this.lblAtendimento);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.lblMenuMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSessoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinegest - Sessões";
            this.Load += new System.EventHandler(this.FormSessoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGestao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSessoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilmes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCinema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoMenu)).EndInit();
            this.painelContentor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessaoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSet2)).EndInit();
            this.gbConfigSessoes.ResumeLayout(false);
            this.gbConfigSessoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtendimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSetSessoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineGestDataSetSessoesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lblgestao_click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pbGestao;
        private System.Windows.Forms.Label lblgestao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbSair;
        private System.Windows.Forms.PictureBox pbClientes;
        private System.Windows.Forms.PictureBox pbDashboard;
        private System.Windows.Forms.PictureBox pbSessoes;
        private System.Windows.Forms.PictureBox pbFilmes;
        private System.Windows.Forms.PictureBox pbCinema;
        private System.Windows.Forms.PictureBox pbLogoMenu;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Panel painelContentor;
        private System.Windows.Forms.PictureBox pbAtendimento;
        private System.Windows.Forms.Label lblUpperMenu;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblSessoes;
        private System.Windows.Forms.Label lblFilmes;
        private System.Windows.Forms.Label lblCinema;
        private System.Windows.Forms.Label lblAtendimento;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Label lblMenuMenu;
        private System.Windows.Forms.GroupBox gbConfigSessoes;
        private System.Windows.Forms.ComboBox comboBoxFilmes;
        private System.Windows.Forms.ComboBox comboBoxSalas;
        private System.Windows.Forms.Button btnAdicionarSessão;
        private System.Windows.Forms.Label lblEscolherFilme;
        private System.Windows.Forms.Label lblEscolherSala;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.BindingSource cineGestDataSetSessoesBindingSource;
        //private CineGestDataSet_Sessoes cineGestDataSet_Sessoes;
        private System.Windows.Forms.BindingSource cineGestDataSetSessoesBindingSource1;
        private System.Windows.Forms.DateTimePicker dataPicker;
        private System.Windows.Forms.BindingSource sessaoBindingSource;
        //private CineGestDataSet_SessoesTableAdapters.SessaoTableAdapter sessaoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtValorBilhete;
        private System.Windows.Forms.Label lblValorBilhete;
        private System.Windows.Forms.DataGridView dataGridView_Users;
        private CineGestDataSet2 cineGestDataSet2;
        private System.Windows.Forms.BindingSource sessaoBindingSource1;
        private CineGestDataSet2TableAdapters.SessaoTableAdapter sessaoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DateTimePicker horaPicker;
    }
}