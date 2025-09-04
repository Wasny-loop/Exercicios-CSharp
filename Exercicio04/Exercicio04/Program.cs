using System;
using System.Globalization;

namespace Exercicio04 {
    class Program {
        static void Main(string[] args) {

            double note_1, note_2, sum;

            Console.Write("Digite a primeira nota do aluno: ");
            note_1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite a segunda nota do aluno: ");
            note_2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            sum = note_1 + note_2;

            Console.WriteLine("NOTA FINAL = " + sum.ToString(CultureInfo.InvariantCulture));

            if (sum > 60.0) {
                Console.WriteLine("APROVADO");
            } else {
                Console.WriteLine("REPROVADO");
            }

            Console.ReadLine();
        }
    }
}