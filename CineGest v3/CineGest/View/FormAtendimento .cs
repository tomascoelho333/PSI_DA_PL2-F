﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Threading;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1
{
    public partial class FormMenu : Form
    {
        Thread nt;

        public FormMenu()
        {
            InitializeComponent();
           // ucHome uc = new ucHome();
            //adicionarUserControl(uc);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string diaDaSemana = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            string data = diaDaSemana;
            lb_data.Text = data;
            string permissao = DBConnection.permissaoUsuario;
            string username = FormLogin.username_global;

            txtUsername.Text = username;

            if (permissao == "1")
            {
                lblgestao.Visible = false;
                pbGestao.Visible = false;
                txtTipoUser.Text = "Funcionário";
            }
            else if (permissao == "2")
            {
                lblgestao.Visible = true;
                pbGestao.Visible = true;
                txtTipoUser.Text = "Administrador";
            }     
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            //ucHome uc = new ucHome();
            //adicionarUserControl(uc);
        }
        private void lblAtendimento_Click(object sender, EventArgs e)
        {
            //ucAtendimento uc = new ucAtendimento();
            //adicionarUserControl(uc);
        }

        private void lblCinema_Click(object sender, EventArgs e)
        {
            //ucCinema uc = new ucCinema();
            //adicionarUserControl(uc);
        }
        private void lblFilmes_Click(object sender, EventArgs e)
        {
            //ucFilmes uc = new ucFilmes();
            //adicionarUserControl(uc);
        }
        private void lblSessoes_Click(object sender, EventArgs e)
        {
            //ucSessoes uc = new ucSessoes();
            //adicionarUserControl(uc);
        }
        private void lblClientes_Click(object sender, EventArgs e)
        {
            //ucClientes uc = new ucClientes();
            //adicionarUserControl(uc);
            this.Close();
            nt = new Thread(novoform_cliente); //inicia um novo processo, que é o form
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        //Botão de Exit
        private void pbSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem a certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pbCinema_Click(object sender, EventArgs e)
        {
            //ucCinema uc = new ucCinema();
            //adicionarUserControl(uc);
        }

        private void pbFilmes_Click(object sender, EventArgs e)
        {
            //ucFilmes uc = new ucFilmes();
            //adicionarUserControl(uc);
        }

        private void pbSessoes_Click(object sender, EventArgs e)
        {   
            //ucSessoes uc = new ucSessoes();
            //adicionarUserControl(uc);
        }

        private void pbClientes_Click(object sender, EventArgs e)
        {
            //ucClientes uc = new ucClientes();
            //adicionarUserControl(uc);
            this.Close();
            nt = new Thread(novoform_cliente); //inicia um novo processo, que é o form
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        public void lblgestao_Click(object sender, EventArgs e)
        {
            //ucAdmin uc = new ucAdmin();
            //adicionarUserControl(uc);  
            this.Close();
            nt = new Thread(novoform_gestao); //inicia um novo processo, que é o form
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoform_gestao()
        {
            Application.Run(new FormAdmin());
        }
        private void novoform_cliente()
        {
            Application.Run(new FormCliente());
        }

        private void btnAdicionarBilhete_Click(object sender, EventArgs e)
        {

        }
    }
}



