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
    public partial class FrmConta : Form
    {
        public FrmConta()
        {
            InitializeComponent();
        }

        private void btnContaCorrente_Click(object sender, EventArgs e)
        {
            frmCC frmcc = new frmCC();
            frmcc.Show();
        }

        private void btnContaPoupanca_Click(object sender, EventArgs e)
        {
            frmCP frmcp = new frmCP();
            frmcp.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
