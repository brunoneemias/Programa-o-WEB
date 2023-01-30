using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_OO
{
    class ContaPoupanca : Conta //Mostrar herança da classe Conta
    {
        public void Rendimento (double PercentualRendimento)
        {        
            saldo= saldo + ((100*PercentualRendimento)/saldo); 
        }
    }
}
