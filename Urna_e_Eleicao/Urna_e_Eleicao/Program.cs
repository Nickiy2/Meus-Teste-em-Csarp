using System;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Urna_e_Eleicao { 
    class Program { 
        static async Task Main(string[] args) {
            
            Console.Write("Digite o caminho do arquivo: ");
            string path = Console.ReadLine();

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            try {
                using (StreamReader sr = File.OpenText(path)) {
                   
                    Dictionary<string, int> Registro = new Dictionary<string, int>();

                    while (!sr.EndOfStream){
                       
                        string[] linhas = sr.ReadLine().Split(',');
                        string Candidatos = linhas[0];
                        int Votos = Convert.ToInt32(linhas[1]);

                        if (Registro.ContainsKey(Candidatos)){
                            Registro[Candidatos] += Votos;
                        }
                        else{
                            Registro[Candidatos] = Votos;
                        }
                    }
                    
                    Console.WriteLine($"Contabilizando votos dos candidatos registrados no arquivo {path}....");
                    await Task.Delay(5000);
                   
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                   
                    Console.WriteLine("VOTOS:");
                    await Task.Delay(5000);
                    
                    foreach(var itens in Registro) {

                        await Task.Delay(2500);
                        Console.WriteLine($"{itens.Key}: {itens.Value}");
                        await Task.Delay(2500);
                    }
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                }
            }
            catch (IOException Ex) {
                Console.WriteLine($"Erro na leitura do arquivo motivo: {Ex.Message}");
            }
        }
    }
}