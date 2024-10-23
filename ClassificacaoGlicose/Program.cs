using System.Globalization;

namespace ClassificacaoGlicose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorGlicose;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Digite o valor da glicose: ");
            valorGlicose = double.Parse(Console.ReadLine(), CI);

            Console.Write("Classificacao: ");
            if (valorGlicose <= 100)
            {
                Console.WriteLine("normal");
            }
            else if (valorGlicose <= 140)
            {
                Console.WriteLine("elevado");
            }
            else
            {
                Console.WriteLine("diabetes");
            }
        }
    }
}
