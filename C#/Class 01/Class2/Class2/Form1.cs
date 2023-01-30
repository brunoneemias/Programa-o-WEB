using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Instaciando a classe Conta 
        Conta ct = new Conta(); 

        private void btnAdicionar(object sender, EventArgs e)
        {
            ct.agencia = txtAgencia.Text;
            ct.numero = Convert.ToInt32(txtNumero.Text);
            ct.nomecliente = txtNome.Text;


            MessageBox.Show("Agência: "+ct.agencia + "\n Conta: "+ct.numero + "\n Nome do Cliente:" + ct.nomecliente,
                            "Informações Conta.",MessageBoxButtons.OK);


        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            ct.Deposito(Convert.ToDouble(txtValor.Text));
            lblSaldo.Text = ct.ImprimirSaldo().ToString();  

        }

        private void txtAdicionar_Click(object sender, EventArgs e)
        {
            ct.agencia = txtAgencia.Text;
            ct.numero = Convert.ToInt32(txtNumero.Text);
            ct.nomecliente = txtNome.Text;


            MessageBox.Show("Agência: " + ct.agencia + "\n Conta: " + ct.numero + "\n Nome do Cliente:" + ct.nomecliente,
                            "Informações Conta.", MessageBoxButtons.OK);

        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtValor.Text);
            ct.Saque(valor);
            lblSaldo.Text ="" + ct.ImprimirSaldo().ToString();
        }
    }
}
