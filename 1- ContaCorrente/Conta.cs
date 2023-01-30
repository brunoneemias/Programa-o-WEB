using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_OO
{
    class Conta
    {
        //Atributos
        protected int numero;
        public int Numero
        {
            set { numero = value; }
            get { return (numero); }
        }

        protected string agencia;
        public string Agencia
        {
            set { agencia = value; }
            get { return (agencia); }
        }

        protected string nomecliente;
        public string Nomecliente
        {
            set { nomecliente = value; }
            get { return (nomecliente); }
        }

        protected double saldo;

        //Metodos
        public void Saque(double valor)
        {
            if(valor<=saldo)
                saldo-=valor;//saldo = saldo - valor;
        }
        
        public void Deposito(double valor)
        {
            saldo += valor; //saldo = saldo + valor;
        }

        public double ImprimirSaldo()
        {
            return Math.Round(saldo,2); 
        }
    }
}
