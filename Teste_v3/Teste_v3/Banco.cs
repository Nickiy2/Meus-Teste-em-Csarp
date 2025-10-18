using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_v3
{
    internal class Banco
    {
        public int Id { get; private set; }
        public string _nome;
        public double Saldo { get; private set; }

        public Banco(int id, string nome)
        {
            Id = id;
            _nome = nome;
            Saldo = 0.0;
        }
        public Banco(int id, string nome, double depositoInicial) : this(id, nome)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.00;
        }

        public override string ToString()
        {
            return "Conta "
                + Id
                + ", Titular: "
                + _nome
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
