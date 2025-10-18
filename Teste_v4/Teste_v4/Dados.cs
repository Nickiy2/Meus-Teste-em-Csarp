using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_v4
{
    internal class Dados
    {
        //propriedades
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quartos { get; set; }

        //método construtor
        public Dados(string nome, string email, int quartos)
        {
            Nome = nome;
            Email = email;
            Quartos = quartos;
        }

        //método sobrescrito
        public override string ToString()
        {
            return Nome + ", " + Email + ", " + Quartos + ".";
        }
    }
}
