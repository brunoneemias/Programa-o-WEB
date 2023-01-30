using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregado
{
    class Empregado
    {
        public int id;
        public string nome;
        public double salario;
        public string cargo;
        public double SalarioComAumento; 
      

    public void ImprimirDados(int indent, string name, double salary, string position)
        {
            id = indent;
            nome = name;
            salario = salary;
            cargo = position; 
        }
    public void AumentarSalario(double perc, double salary)
        {
            double aumento = perc / 100;
            SalarioComAumento = salary * (1 + aumento);
        }
    }
}
