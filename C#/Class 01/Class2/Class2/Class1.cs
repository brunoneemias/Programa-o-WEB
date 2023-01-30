using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    class Conta
    {
        //Atributos 
        public int numero;
        public string agencia;
        public string nomecliente;
        public double saldo;


        //Métodos

        public void Saque(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;

            }

        }

        public void Deposito(double valor)
        {
            saldo += valor; 

        }

        public double ImprimirSaldo()
        {
            return Math.Round(saldo); 
        }
    }
}
