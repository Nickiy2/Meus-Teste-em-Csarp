using Composição_Ex01.Entites;
using Composição_Ex01.Entites.Enums;
using System.Globalization;
using System;

namespace Composicao_Ex01{
    class Program{
        static void Main(string[] args){

            // Lendo os dados do Departamento e do Worker
            Console.Write("Coloque o nome do Departamento: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Coloque os dados do funcionário:");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Nível (Junior/MidLevel/Senior): ");
            WorkerLevel level = WorkerLevel.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Salário Base: ");
            double baseSalary = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Instanciando o Departamento e o Worker
            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            // Lendo os dados dos contratos do Worker
            Console.Write("Quantos contratos terão esse funcionário? ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------------");

            // Para cada contrato, ler os dados e adicionar o contrato ao Worker
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do contrato #{i}:");
                Console.Write("Data (Dia/Mês/Ano): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por Hora: ");
                double valuePerHour = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duração (Horas): ");
                int hours = Convert.ToInt32(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
                Console.WriteLine("---------------------------------------");
            }
            
            Console.WriteLine();
            Console.Write("Coloque o mês e o ano para calcular o salário (Mês/Ano): ");
            string monthAndYear = Console.ReadLine();
            int month = Convert.ToInt32(monthAndYear.Substring(0, 2));
            int year = Convert.ToInt32(monthAndYear.Substring(3));
            Console.WriteLine($"Nome: {worker.Name}");
            Console.WriteLine($"Departamento: {worker.Department.Name}");
            Console.WriteLine($"Salário para {monthAndYear}: {worker.Income(year, month)}");

        }
    }
}