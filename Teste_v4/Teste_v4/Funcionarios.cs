using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_v4
{
    internal class Funcionarios
    {
        //propriedades
        public string Nome { get; set; }
        public int Id { get; set; }
        public double Salario { get; set; }

        //método construtor
        public Funcionarios(string nome, int id, double salario)
        {
            Nome = nome;
            Id = id;
            Salario = salario;
        }

        //método para aumentar o salário
        public void AumentarSalario(double porcentagem)
        {
            Salario += Salario * porcentagem / 100.0;
        }

        //método sobrescrito
        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
