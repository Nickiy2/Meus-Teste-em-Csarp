using Composicao_EX02.Entites;
using System;

namespace Composicao_EX02
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Tenha uma boa viagem!");
            Comment c2 = new Comment("Uau isso é incrível!");
            Post p1 = new Post(
                DateTime.Parse("21/01/2026 16:08:50"),
                "Viagem para Nova Zelândia",
                "Estou indo para esse lindo país. Abraços!",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Boa Noite");
            Comment c4 = new Comment("Que a força esteja com você");
            Post p2 = new Post(
                DateTime.Now,
                "Boa noite galera",
                "Vou dormir, até amanhã",
                5);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}