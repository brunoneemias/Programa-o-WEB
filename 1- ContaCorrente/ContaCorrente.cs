using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_OO
{
    class ContaCorrente : Conta
    {
        public void CobrancaServicos (double Valor)
        {
            saldo -= Valor; //saldo = saldo - Valor; 
        }
    }
}
