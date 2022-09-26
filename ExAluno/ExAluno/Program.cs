using System;

namespace ExAluno {
    internal class Program {
        static void Main(string[] args) {
            Aluno a = new Aluno();

            Console.Write("Nome do aluno: ");
            a.Nome=Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            a.Nota1 = double.Parse(Console.ReadLine());
            a.Nota2 = double.Parse(Console.ReadLine());
            a.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota Final = " + a.Soma().ToString("F2"));

            if (a.Soma() > 60.00) {
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + a.Falta().ToString("F2") + " PONTOS");

            }
            Console.ReadLine();
        }
        
    }
}
