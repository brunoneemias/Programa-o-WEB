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
    public partial class frmCC : Form
    {
        public frmCC()
        {
            InitializeComponent();
        }

        ContaCorrente cc = new ContaCorrente();

        private void btnAdicionarConta_Click(object sender, EventArgs e)
        {
            cc.Agencia = txtAgencia.Text;
            cc.Numero = Convert.ToInt32(txtNumero.Text);
            cc.Nomecliente = txtNomeCliente.Text;

            MessageBox.Show("Agência: " + cc.Agencia + "\n" +
                            "Número Conta: " + cc.Numero + "\n" +
                            "Nome do Cliente: " + cc.Nomecliente,
                            "Dados Conta Corrente");
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            double saldo = cc.ImprimirSaldo();
            double valor = Convert.ToDouble(txtValor.Text);

            if (saldo>=valor)
                cc.Saque(valor);
            else
                MessageBox.Show("Operação inválida, o valor escolhido para saque é superior ao saldo em conta!", "Erro ao Efetuar o Saque");


            lblSaldo.Text = "Saldo: " + cc.ImprimirSaldo().ToString("C"); 
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            cc.Deposito(Convert.ToDouble(txtValor.Text));
            lblSaldo.Text = "Saldo: " + cc.ImprimirSaldo().ToString("C");
        }

        private void btnCobrancaServicos_Click(object sender, EventArgs e)
        {
            cc.CobrancaServicos(Convert.ToDouble(txtVlCobracaServico.Text));
            lblSaldo.Text = "Saldo: " + cc.ImprimirSaldo().ToString("C"); 
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
