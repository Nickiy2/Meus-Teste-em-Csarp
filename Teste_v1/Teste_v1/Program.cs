using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

//Primeiro Programa em C# e primeiro exercício
Console.WriteLine("Olá mundo! \n");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
Console.WriteLine("Por Favor tenha paciência! \n S2 ");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

int X, Y, Z;
X = 30;
Console.WriteLine("Por Favor digite um número para somar com um segundo número: ");
Y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nPor Favor digite outro número: ");
Z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"\nVamos oferecer um número para você: {X}");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
Console.Write("\nTeste de operações, números que você digitou");
Console.WriteLine($" {Y} e {Z}, o número que oferecemos é {X}, quanto é {X} + {Y}? O resultado é = {X + Y}");

//Segundo exercício
string nome = " ";
int idade;
Console.WriteLine("Digite seu nome: ");
nome = Console.ReadLine();
Console.WriteLine("\nDigite sua idade: ");
idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Seu nome é: {nome}");
Console.WriteLine($"Sua idade é: {idade}");

//Terceiro exercício
//Entrada de dados de materias
string nomedoAluno = "Sophia Johnson";
string nomedoCurso1 = "Inglês   101";
string nomedoCurso2 = "Algebra  101";
string nomedoCurso3 = "Biologia 101";
string nomedoCurso4 = "Ciências da Computação I";
string nomedoCurso5 = "Pisicologia 101";

//Entrada das notas
int creditodoCurso1 = 3;
int creditodoCurso2 = 3;
int creditodoCurso3 = 4;
int creditodoCurso4 = 4;
int creditodoCurso5 = 3;

//Notas 4 se tornam A e notas 3 se tornam B
int gradeA = 4;
int gradeB = 3;

//Variaveis para armazenar notas
int notadoCurso1 = gradeA;
int notadoCurso2 = gradeB;
int notadoCurso3 = gradeB;
int notadoCurso4 = gradeB;
int notadoCurso5 = gradeA;

//Conta para total de credito de horas 
int totaldeCreditodeHoras = 0;
totaldeCreditodeHoras += creditodoCurso1;
totaldeCreditodeHoras += creditodoCurso2;
totaldeCreditodeHoras += creditodoCurso3;
totaldeCreditodeHoras += creditodoCurso4;
totaldeCreditodeHoras += creditodoCurso5;

//conta para total para nota
int totaldeNotasPontos = 0;
totaldeNotasPontos += creditodoCurso1 * notadoCurso1;
totaldeNotasPontos += creditodoCurso2 * notadoCurso2;
totaldeNotasPontos += creditodoCurso3 * notadoCurso3;
totaldeNotasPontos += creditodoCurso4 * notadoCurso4;
totaldeNotasPontos += creditodoCurso5 * notadoCurso5;

//Calculo GPA
decimal pontuacaoMedia = (decimal)totaldeNotasPontos / totaldeCreditodeHoras;

//Arredondar o GPA
int antesdaVirgula = (int)pontuacaoMedia;
int primeiroDigito = (int)(pontuacaoMedia * 10) % 10;
int segundoDigito = (int)(pontuacaoMedia * 100) % 10;

//Exibir nome do curso e notas em forma de letras
Console.WriteLine($"Aluno: {nomedoAluno}\n");
Console.WriteLine("Curso\t\t\t\t\t\tNota\t\t\tCredito de Horas");
Console.WriteLine($"{nomedoCurso1}\t\t\t\t\t {notadoCurso1}\t\t\t {creditodoCurso1}");
Console.WriteLine($"{nomedoCurso2}\t\t\t\t\t {notadoCurso2}\t\t\t {creditodoCurso2}");
Console.WriteLine($"{nomedoCurso3}\t\t\t\t\t {notadoCurso3}\t\t\t {creditodoCurso3}");
Console.WriteLine($"{nomedoCurso4}\t\t\t {notadoCurso4}\t\t\t {creditodoCurso4}");
Console.WriteLine($"{nomedoCurso5}\t\t\t\t\t {notadoCurso5}\t\t\t {creditodoCurso5}");
Console.WriteLine($"\nGPA Final:\t\t\t\t\t {antesdaVirgula}.{primeiroDigito}{segundoDigito}");

//Quarto Exercício
string nome_1 = Console.ReadLine();
int quartos = Convert.ToInt32(Console.ReadLine());
double valor = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

string[] x = Console.ReadLine().Split(' ');
string cor = x[0];
int numero = Convert.ToInt32(x[1]);
double preco = Convert.ToDouble(x[2], CultureInfo.InvariantCulture);

Console.WriteLine("Seu nome é: ");
Console.WriteLine(nome_1);
Console.WriteLine("Quantos quartos tem na sua casa? ");
Console.WriteLine(quartos);
Console.WriteLine("Qual o valor da sua casa? ");
Console.WriteLine(valor.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Esses são os dados da sua casa:");
Console.WriteLine(cor);
Console.WriteLine(numero);
Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));

//Quinto Exercício
Console.WriteLine("Seja bem vindo a calculadora de terreno");

//Entrada de dados
Console.Write("\nDigite a largura do seu terreno: ");
double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("\nDigite o Comprimento do terreno: ");
double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double calculo_01 = largura * comprimento;

Console.WriteLine("\nA área do terreno é de:" + calculo_01.ToString("F2", CultureInfo.InvariantCulture));

Console.WriteLine("Agora digite o valor do terreno: ");
double valor_01 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double preco_01 = valor_01 * calculo_01;
Console.WriteLine("\nO valor do terreno é de: R$ " + preco_01.ToString("F2", CultureInfo.InvariantCulture));

//Sexto Exercício
double triangulo, circulo, trapezeo, quadrado, retangulo, A, B, C;

string[] valores = Console.ReadLine().Split(' ');
A = double.Parse(valores[0], CultureInfo.InvariantCulture);
C = double.Parse(valores[1], CultureInfo.InvariantCulture);
B = double.Parse(valores[2], CultureInfo.InvariantCulture);

triangulo = A * C / 2.0;
circulo = 3.14159 * C * C;
trapezeo = (A + B) / 2.0 * C;
quadrado = B * B;
retangulo = A * B;

Console.WriteLine("TRIANGULO:" + triangulo.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("CIRCULO:" + circulo.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("TRAPEZEO:" + trapezeo.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("QUADRADO:" + quadrado.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("RETANGULO:" + retangulo.ToString("F3", CultureInfo.InvariantCulture));

//Sétimo Exercício
Char resposta_01;
do
{
    Console.WriteLine("Digite seu nome Completo:");
    string nome_02 = Console.ReadLine();

    Console.WriteLine("Quanto quartos tem em sua casa?");
    int quartos_02 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Entre com o valor de um produto:");
    double valor_02 = Convert.ToDouble((Console.ReadLine()), CultureInfo.InvariantCulture);

    Console.WriteLine("Digite seu sobrenome, sexo, idade e altura (Na mesma linha)");
    string[] dados = Console.ReadLine().Split(' ');
    string sobrenome = dados[0];
    char sexo = Convert.ToChar(dados[1]);
    byte idade_01 = Convert.ToByte(dados[2]);
    double altura = Convert.ToDouble(dados[3], CultureInfo.InvariantCulture);

    Console.Write("-=--=--=--=--=--=--=--=--=--=--=--=--=--=---=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--\n");

    Console.WriteLine($"Seu nome é: {nome_02}");
    Console.WriteLine($"Tem {quartos_02} quartos em sua casa");
    Console.WriteLine($"O valor do produto digitado é: {valor_02.ToString("F2", CultureInfo.InvariantCulture)}");
    Console.WriteLine($"Seu sobrenome é: {sobrenome}");
    Console.WriteLine($"Seu sexo é: {sexo}");
    Console.WriteLine($"Sua idade é: {idade_01}");
    Console.WriteLine($"Sua altura é: {altura:F2}");

    Console.Write("-=--=--=--=--=--=--=--=--=--=--=--=--=--=---=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--\n");
    Console.WriteLine("Deseja repitir o programa? (s/n)");
    resposta_01 = Convert.ToChar(Console.ReadLine());
    Console.Write("-=--=--=--=--=--=--=--=--=--=--=--=--=--=---=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--\n");

} while (resposta_01 == 's');

//Oitavo Exercício
int A_01, B_01;
Console.Write("\n");
Console.Write("-=--=--=--=--=--=--=--=--=--=--=--=--=--=---=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--\n");

Console.WriteLine("Digite dois números inteiros (Na mesma linha):");
string[] valores_03 = Console.ReadLine().Split(' ');
A_01 = Convert.ToInt32(valores_03[0]);
B_01 = Convert.ToInt32(valores_03[1]);

Console.Write("-=--=--=--=--=--=--=--=--=--=--=--=--=--=---=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--\n");

int SOMA = A_01 + B_01;
Console.WriteLine($"A soma de {A_01} e {B_01} deu: {SOMA}");
Console.Write("-=--=--=--=--=--=--=--=--=--=--=--=--=--=---=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--\n");
Console.Write("\n");

//Nono Exercício
double raio, area, pi = 3.14159;

Console.Write("\n");
Console.Write("-=--=--=--=--=--=--=--=--=--=--=--=--=--=---=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--\n");

Console.WriteLine("Digite um valor do raio para calcularmos a area de um circulo:");
raio = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

area = pi * Math.Pow(raio, 2.0);
Console.Write("-=--=--=--=--=--=--=--=--=--=--=--=--=--=---=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--\n");

Console.WriteLine($"O valor do raio digitado foi {raio}, e o calculo da area deu: {area}");

Console.Write("-=--=--=--=--=--=--=--=--=--=--=--=--=--=---=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--\n");

//Décimo Exercício
int a, b, c, d, DIFERENCA;
Console.Write("\n");
Console.Write("-=--=--=--=--=--=--=--=--=--=--=--=--=--=---=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--\n");

Console.WriteLine("Digite 5 numeros para calcularmos a diferença entre eles:");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
d = Convert.ToInt32(Console.ReadLine());

Console.Write("-=--=--=--=--=--=--=--=--=--=--=--=--=--=---=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--\n");

DIFERENCA = (a * b - c * d);

Console.WriteLine($"A diferença entre os números {a}, {b}, {c}, {d} é {DIFERENCA}");
Console.Write("-=--=--=--=--=--=--=--=--=--=--=--=--=--=---=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--\n");

//Décimo Primeiro Exercício
int numero_01;
double horas, salario, valorhora;
Console.Write("\n");
Console.Write("-=--=--=--=--=--=--=--=--=--=--=--=--=--=---=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--\n");

Console.WriteLine("Digite abaixo o número do fúncionario, suas horas trabalhadas e o valor que ganha por hora para podermos calcular o salário:");
numero_01 = Convert.ToInt32(Console.ReadLine());
horas = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
valorhora = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

salario = horas * valorhora;
Console.Write("-=--=--=--=--=--=--=--=--=--=--=--=--=--=---=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--\n");

Console.WriteLine($"O número do funcionário é {numero_01} e seu salário do mês deu {salario}");

Console.Write("-=--=--=--=--=--=--=--=--=--=--=--=--=--=---=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--\n");

//Décimo Segundo Exercício
int codigo1, codigo2, numeropecas1, numeropecas2;
double valorpeca1, valorpeca2, total;
Console.Write("\n");
Console.Write("-=--=--=--=--=--=--=--=--=--=--=--=--=--=---=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--\n");

Console.WriteLine("Digite a baixo o código, a quantidade e o valor das peças:");
string[] valores_01 = Console.ReadLine().Split(' ');
codigo1 = Convert.ToInt32(valores_01[0]);
numeropecas1 = Convert.ToInt32(valores_01[1]);
valorpeca1 = Convert.ToDouble(valores_01[2], CultureInfo.InvariantCulture);

Console.Write("-=--=--=--=--=--=--=--=--=--=--=--=--=--=---=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--\n");

string[] valores_02 = Console.ReadLine().Split(' ');
codigo2 = Convert.ToInt32(valores_02[0]);
numeropecas2 = Convert.ToInt32(valores_02[1]);
valorpeca2 = Convert.ToDouble(valores_02[2], CultureInfo.InvariantCulture);

total = (numeropecas1 * valorpeca1) + (numeropecas2 * valorpeca2);
Console.Write("-=--=--=--=--=--=--=--=--=--=--=--=--=--=---=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--\n");

Console.WriteLine($"O valor das peças deu no total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");

Console.Write("-=--=--=--=--=--=--=--=--=--=--=--=--=--=---=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--\n");