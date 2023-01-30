using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo_OO
{
    public partial class frmCP : Form
    {
        public frmCP()
        {
            InitializeComponent();
        }

        ContaPoupanca cp = new ContaPoupanca();

        private void btnAdicionarConta_Click(object sender, EventArgs e)
        {
            cp.Agencia = txtAgencia.Text;
            cp.Numero = Convert.ToInt32(txtNumero.Text);
            cp.Nomecliente = txtNomeCliente.Text;

            MessageBox.Show("Agência: " + cp.Agencia + "\n" +
                            "Número: " + cp.Numero + "\n" +
                            "Nome do Cliente: " + cp.Nomecliente, "Dados Conta Poupança");
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtValor.Text);
            double saldo = cp.ImprimirSaldo();

            if (saldo >= valor)
                cp.Saque(valor);
            else
                MessageBox.Show("Operação inválida, o valor escolhido para saque é superior ao saldo em conta!", "Erro ao Efetuar o Saque");

            lblSaldo.Text = "Saldo: " + cp.ImprimirSaldo().ToString("C");
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            cp.Deposito(Convert.ToDouble(txtValor.Text));
            lblSaldo.Text = "Saldo: " + cp.ImprimirSaldo().ToString("C"); 
        }

        private void btnRendimento_Click(object sender, EventArgs e)
        {
            cp.Rendimento(Convert.ToDouble(txtPercentualRendimento.Text));
            lblSaldo.Text = "Saldo: " + cp.ImprimirSaldo().ToString("C");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
