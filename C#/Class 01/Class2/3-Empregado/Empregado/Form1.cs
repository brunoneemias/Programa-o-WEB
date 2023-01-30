using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empregado
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        Empregado Fun = new Empregado(); 


        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnAumento_Click(object sender, EventArgs e)
        {
            Fun.ImprimirDados(Convert.ToInt32(txtID.Text), txtNome.Text, Convert.ToDouble(txtSalario.Text), txtCargo.Text);

            if (txtAumento.Text.Length > 0)
            {
                Fun.AumentarSalario(Convert.ToDouble(txtAumento.Text), Convert.ToDouble(txtSalario.Text));

            }
            else
            {
                Fun.SalarioComAumento = Fun.salario; 
            }

            MessageBox.Show("ID: " + Fun.id + "\n" +
                            "Nome: " + Fun.nome + "\n" +
                            "Salário: " + Fun.SalarioComAumento + "\n" +
                            "Cargo: " + Fun.cargo + "\n", "Transação Realizada!"); 
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Fun.SalarioComAumento = 0;
            Fun.salario = 0;
            Fun.nome = "";
            Fun.cargo = "";
            Fun.id = 0; 
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSalario.Text = "";
            txtNome.Text = "";
            txtID.Text = "";
            txtCargo.Text = "";
            txtAumento.Text = ""; 

            Fun.SalarioComAumento = 0;
            Fun.salario = 0;
            Fun.nome = "";
            Fun.cargo = "";
            Fun.id = 0;
        }
    }
}
