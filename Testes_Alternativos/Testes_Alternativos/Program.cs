// See https://aka.ms/new-console-template for more information

/*
 * Nesse código farei alguns exemplos de uso de ferramentas alternativas como Var, Switch Case, Funções internas de String e etc
 */

using System.Globalization;
using System.Xml;

// Declaração de variáveis usando 'var'

var x = 10;
var y = 20.0;
var z = "Matheus";

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);

Console.WriteLine("-=--=-=--=-=-=-=-=-=--=-=-=-=-=-==-=-=-=-=-=-=-=");
/*-=--=-=--=-=-=-=-=-=--=-=-=-=-=-==-=-=-=-=-=-=-=*/

//Exemplo de Switch Case como um calendario

char resp;
do
{
    Console.WriteLine("Por favor digite um número de 1 á 7 para o sistema dizer o dia: ");
    int dia = Convert.ToInt32(Console.ReadLine());
    switch (dia)
    {
        case 1:
            Console.WriteLine("Domingo");
            break;
        case 2:
            Console.WriteLine("Segunda");
            break;
        case 3:
            Console.WriteLine("Terça");
            break;
        case 4:
            Console.WriteLine("Quarta");
            break;
        case 5:
            Console.WriteLine("Quinta");
            break;
        case 6:
            Console.WriteLine("Sexta");
            break;
        case 7:
            Console.WriteLine("Sábado");
            break;
        default:
            Console.WriteLine("Número Inválido");
            break;
    }

    Console.Write("Deseja repetir o sistema? (s/n): ");
    resp = Convert.ToChar(Console.ReadLine());
    Console.WriteLine();

} while (resp == 's');


Console.WriteLine("-=--=-=--=-=-=-=-=-=--=-=-=-=-=-==-=-=-=-=-=-=-=");
/*-=--=-=--=-=-=-=-=-=--=-=-=-=-=-==-=-=-=-=-=-=-=*/

//Exemplo de condional Ternária

Console.WriteLine("Digite o preço a baixo, se ele for menor que R$ 20,00 você tem um desconto de 10%, se não terá um desconto de 5%");
Console.WriteLine();
Console.Write("Preço: ");
double Preço = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();
double Desconto = (Preço < 20.0) ? Preço * 0.10 : Preço * 0.05;
Console.WriteLine($"O valor com o desconto deu: R${Desconto}");

Console.WriteLine("-=--=-=--=-=-=-=-=-=--=-=-=-=-=-==-=-=-=-=-=-=-=");

/*-=--=-=--=-=-=-=-=-=--=-=-=-=-=-==-=-=-=-=-=-=-=*/

//Exemplo de funções internas de String
string Original = "abcde FGHIJ ABC abc DEFG  ";
string s1 = Original.ToUpper();
string s2 = Original.ToLower();
string s3 = Original.Trim();
int n1 = Original.IndexOf("bc");
int n2 = Original.LastIndexOf("bc");
string s4 = Original.Substring(3);
string s5 = Original.Substring(3, 5);
string s6 = Original.Replace('a', 'x');
string s7 = Original.Replace("abc", "xy");
bool b1 = String.IsNullOrEmpty(Original);
bool b2 = String.IsNullOrWhiteSpace(Original);

Console.WriteLine($"Original: -{Original}-");
Console.WriteLine($"ToUpper: -{s1}-");
Console.WriteLine($"ToLower: -{s2}-");
Console.WriteLine($"Trim: -{s3}-");
Console.WriteLine($"IndexOf('bc'): -{n1}-");
Console.WriteLine($"LastIndexOf('bc'): -{n2}-");
Console.WriteLine($"Substring(3)-{s4}-");
Console.WriteLine($"Substring(3, 5): -{s5}-");
Console.WriteLine($"Replace('a', 'x'): -{s6}-");
Console.WriteLine($"Replace('abc', 'xy'): -{s7}-");
Console.WriteLine($"IsNullOrEmpty: -{b1}-");
Console.WriteLine($"IsNullOrWhiteSpace: -{b2}-");
Console.WriteLine("-=--=-=--=-=-=-=-=-=--=-=-=-=-=-==-=-=-=-=-=-=-=");
/*-=--=-=--=-=-=-=-=-=--=-=-=-=-=-==-=-=-=-=-=-=-=*/

//Date Time exemplo
DateTime d1 = DateTime.Now; //Fala a data e o horário de hoje
DateTime d2 = new DateTime(2000, 8, 15);//Nesse exemplo colocamos a data
DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);//Já nesse adicionamos o horário
DateTime d4 = new DateTime(2000, 8, 15, 13, 5, 58, 275);//E nesse colocamos os milésimos de segundos
DateTime d5 = DateTime.UtcNow; //Fala a data de hoje e utiliza o horário de Greenwich
DateTime d6 = DateTime.Today; //Fala a data de hoje mais zera o cronometro

Console.WriteLine("Uso de DateTime padrão:");
Console.WriteLine(d1);
Console.WriteLine(d2);
Console.WriteLine(d3);
Console.WriteLine(d4);
Console.WriteLine(d5);
Console.WriteLine(d6);
Console.WriteLine();

//Uso dos métodos Parse e ParseExact para converter string em DateTime
DateTime d7 = DateTime.Parse("2000-08-15");//Transforma string em Tiki/data
DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");//O mesmo exemplo só que com horário
DateTime d9 = DateTime.Parse("15/08/2000");
DateTime d10 = DateTime.Parse("15/08/2000 13:05:58");
DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);//Digita a data exata mais você indica o ano, mês e dia
DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);//A mesma coisa só que com horas a mais

Console.WriteLine("Uso de DataTime com Parse e ParseExact:");
Console.WriteLine(d7);
Console.WriteLine(d8);
Console.WriteLine(d9);
Console.WriteLine(d10);
Console.WriteLine(d11);
Console.WriteLine(d12);
Console.WriteLine();

//Propriedades do DateTime
DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

Console.WriteLine("Uso de propriedades do DateTime:");
Console.WriteLine(d);
Console.WriteLine($"1) Date: {d.Date}");
Console.WriteLine($"2) Day: {d.Day}");
Console.WriteLine($"3) DayOffWeek: {d.DayOfWeek}");
Console.WriteLine($"4) DayOffYear: {d.DayOfYear}");
Console.WriteLine($"5) Hour: {d.Hour}");
Console.WriteLine($"6) Kind: {d.Kind}");
Console.WriteLine($"7) Milliseconds: {d.Millisecond}");
Console.WriteLine($"8) Minute: {d.Minute}");
Console.WriteLine($"9) Month: {d.Month}");
Console.WriteLine($"10) Second: {d.Second}");
Console.WriteLine($"11) Ticks: {d.Ticks}");
Console.WriteLine($"12) TimeOfDay: {d.TimeOfDay}");
Console.WriteLine($"13) Year: {d.Year}");
Console.WriteLine();

//Formatação (DataTime -> String)
DateTime D = new DateTime(2001, 8, 15, 13, 45, 58);

String s01 = d.ToLongDateString();//Aqui será colocado nessa variável o dia e a data: Quinta-Feira, 15 de Agosto de 2001
String s02 = d.ToLongTimeString();//Aqui será colocado nessa variável o horário completo: 13:45:58
String s03 = d.ToShortDateString();//Aqui será colocado nessa variável a data: 15/08/2001
String s04 = d.ToShortTimeString();//Aqui será colocado nessa variável o horário e os minutos: 13:45
String s05 = d.ToString();//Aqui irá salvar a data e o horário da seguinte forma: 15/08/2001 13:45:58
String s06 = d.ToString("yyyy-MM-dd HH:mm:ss");//Já nesse exemplo configuramos a exibição de como vamos querer que será: 2001-08-15 13:45:58 
String s07 = d.ToString("yyyy-MM-dd HH:mm:ss.ff");//Já nesse será informado até os milisegundos: 2001-08-15 13:45:58.27

Console.WriteLine("Uso de DataTime para String:");
Console.WriteLine(D);
Console.WriteLine(s01);
Console.WriteLine(s02);
Console.WriteLine(s03);
Console.WriteLine(s04);
Console.WriteLine(s05);
Console.WriteLine(s06);
Console.WriteLine(s07);
Console.WriteLine();

//Operações com o DataTime
DateTime x2 = new DateTime(2026, 2, 15, 18, 41, 7);

DateTime y1 = x2.Add(TimeSpan.FromDays(7));
DateTime y2 = x2.AddDays(5);
DateTime y3 = x2.AddHours(2);
DateTime y4 = x2.AddMilliseconds(500);
DateTime y5 = x2.AddMinutes(30);
DateTime y6 = x2.AddMonths(1);
DateTime y7 = x2.AddSeconds(45);
DateTime y8 = x2.AddTicks(900000000L);
DateTime y9 = x2.AddYears(2);

Console.WriteLine("Operações com o DataTime");
Console.WriteLine($"Data original: {x2}");
Console.WriteLine($"1) Adiciona 7 dias: {y1}");
Console.WriteLine($"2) Adiciona 5 dias: {y2}");
Console.WriteLine($"3) Adiciona 2 horas: {y3}");
Console.WriteLine($"4) Adiciona 500 Milisegundos: {y4}");
Console.WriteLine($"5) Adiciona 30 minutos: {y5}");
Console.WriteLine($"6) Adiciona 1 mês: {y6}");
Console.WriteLine($"7) Adiciona 45 segundos: {y7}");
Console.WriteLine($"8) Adicona 900000000L ticks: {y8}");
Console.WriteLine($"9) Adiciona 2 anos: {y9}");
Console.WriteLine();

Console.WriteLine("-=--=-=--=-=-=-=-=-=--=-=-=-=-=-==-=-=-=-=-=-=-=");
/*-=--=-=--=-=-=-=-=-=--=-=-=-=-=-==-=-=-=-=-=-=-=*/

//Exemplo de TimeSpan
TimeSpan t1 = new TimeSpan();
TimeSpan t2 = new TimeSpan(900000000L);
TimeSpan t3 = new TimeSpan(2, 11, 21);
TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

Console.WriteLine("Exemplo de TimeSpan padrão");
Console.WriteLine(t1);
Console.WriteLine(t2);
Console.WriteLine(t3);
Console.WriteLine(t4);
Console.WriteLine(t5);
Console.WriteLine();

//Métodos From do TimeSpan
TimeSpan t6 = TimeSpan.FromDays(1.5);
TimeSpan t7 = TimeSpan.FromHours(1.5);
TimeSpan t8 = TimeSpan.FromMinutes(1.5);
TimeSpan t9 = TimeSpan.FromSeconds(1.5);
TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
TimeSpan t11 = TimeSpan.FromTicks(900000000L);

Console.WriteLine("Exemplo de TimeSpan usando o método From");
Console.WriteLine(t6);
Console.WriteLine(t7);
Console.WriteLine(t8);
Console.WriteLine(t9);
Console.WriteLine(t10);
Console.WriteLine(t11);
Console.WriteLine();

//Propriedades e Operações do TimeSpan
TimeSpan T1 = TimeSpan.MaxValue;
TimeSpan T2 = TimeSpan.MinValue;
TimeSpan T3 = TimeSpan.Zero;
Console.WriteLine("Propriedades com o TimeSpan:");
Console.WriteLine($"MaxValue:{T1}");//Aqui será mostrado o maior valor possível de um TimeSpan
Console.WriteLine($"MinValue:{T2}");//Aqui será mostrado o menor valor possível de um TimeSpan
Console.WriteLine($"Zero: {T3}");//Aqui será mostrado o valor zero de um TimeSpan
Console.WriteLine();

TimeSpan T = new TimeSpan(2, 3, 5, 7, 11);
Console.WriteLine(T);
Console.WriteLine($"Days: {T.Days}");//Aqui será mostrado o número de dias do TimeSpan
Console.WriteLine($"Hours: {T.Hours}");//Aqui será mostrado o número de horas do TimeSpan
Console.WriteLine($"Minutes: {T.Minutes}");//Aqui será mostrado o número de minutos do TimeSpan
Console.WriteLine($"Milliseconds: {T.Milliseconds}");//Aqui será mostrado o número de milisegundos do TimeSpan
Console.WriteLine($"Seconds: {T.Seconds}");//Aqui será mostrado o número de segundos do TimeSpan
Console.WriteLine($"Ticks: {T.Ticks}");//Aqui será mostrado o número de ticks do TimeSpan

Console.WriteLine($"TotalDays: {T.TotalDays}");//Aqui será mostrado o número total de dias do TimeSpan, incluindo as horas, minutos e etc
Console.WriteLine($"TotalHours: {T.TotalHours}");
Console.WriteLine($"TotalMinutes: {T.TotalMinutes}");
Console.WriteLine($"TotalSeconds: {T.TotalSeconds}");
Console.WriteLine($"TotalMilliseconds: {T.TotalMilliseconds}");
Console.WriteLine();

TimeSpan T01 = new TimeSpan(1, 30, 45);
TimeSpan T02 = new TimeSpan(0, 10, 5);

TimeSpan sum = T01.Add(T02);//Aqui será mostrado a soma dos dois TimeSpan
TimeSpan dif = T01.Subtract(T02);//Aqui será mostrado a diferença dos dois TimeSpan
TimeSpan mult = T01.Multiply(2.0);//Aqui será mostrado o resultado da multiplicação do TimeSpan por um número
TimeSpan div = T01.Divide(2.0);//Aqui será mostrado o resultado da divisão do TimeSpan por um número

Console.WriteLine($"Aqui teremos nosso primeiro TimeSpan: {T01}");
Console.WriteLine($"Aqui teremos nosso segundo TimeSpan: {T02}");
Console.WriteLine($"A soma de {T01} e de {T02} resultou: {sum}");
Console.WriteLine($"A diferença ou subtração de {T01} e de {T02} resulta: {dif}");
Console.WriteLine($"A multiplicação entre {T01} e 2 dará: {mult}");
Console.WriteLine($"A divisão entre {T01} e 2 dará: {div}");
Console.WriteLine();

Console.WriteLine("-=--=-=--=-=-=-=-=-=--=-=-=-=-=-==-=-=-=-=-=-=-=");
/*-=--=-=--=-=-=-=-=-=--=-=-=-=-=-==-=-=-=-=-=-=-=*/

//DateTimeKind Local, Utc e Unspecified 
DateTime D01 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
DateTime D02 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
DateTime D03 = new DateTime(2000, 8, 15, 13, 5, 58);

Console.WriteLine($"D1: {D01}");
Console.WriteLine($"D1 Kind: {D01.Kind}");
Console.WriteLine($"D1 to Local: {D01.ToLocalTime()}");
Console.WriteLine($"D1 to Utc: {D01.ToUniversalTime()}");
Console.WriteLine();

Console.WriteLine($"D2: {D02}");
Console.WriteLine($"D2 Kind: {D02.Kind}");
Console.WriteLine($"D2 to Local: {D02.ToLocalTime()}");
Console.WriteLine($"D2 to Utc: {D02.ToUniversalTime()}");
Console.WriteLine();

Console.WriteLine($"D3: {D03}");
Console.WriteLine($"D3 Kind: {D03.Kind}");
Console.WriteLine($"D3 to Local: {D03.ToLocalTime()}");
Console.WriteLine($"D3 to Utc: {D03.ToUniversalTime()}");
Console.WriteLine();

//Padrão ISO 8601
DateTime D04 = DateTime.Parse("2000-08-15 13:05:58Z");
DateTime D05 = DateTime.Parse("2000-08-15T13:05:58Z");
/*
 * O Z nessa situação indica que a data e o horário estão no formato UTC e o T é um separador entre a data e o horário.
 */

Console.WriteLine($"D4: {D04}");
Console.WriteLine($"D4 Kind: {D04.Kind}");
Console.WriteLine($"D4 to Local: {D04.ToLocalTime()}");
Console.WriteLine($"D4 to Utc: {D04.ToUniversalTime()}");
Console.WriteLine();

Console.WriteLine($"D5: {D05}");
Console.WriteLine($"D5 Kind: {D05.Kind}");
Console.WriteLine($"D5 to Local: {D05.ToLocalTime()}");
Console.WriteLine($"D5 to Utc: {D05.ToUniversalTime()}");
Console.WriteLine();

Console.WriteLine(D05.ToString("yyyy-MM-ddTHH:mm:ssZ"));
/*
 * Cuidado com esse formato, ele irá mostrar a data e o horário no formato UTC, mesmo que o DateTime seja do tipo Local ou Unspecified, ele irá mostrar a data e o horário como se fosse do tipo Utc, por isso é importante sempre verificar o tipo do DateTime antes de formatar a string.
 */
Console.WriteLine(D05.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));