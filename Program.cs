using System;
using System.Globalization;


namespace EstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod1, cod2, quant1, quant2;
            double preco1, preco2;

            string[] s = Console.ReadLine().Split();
            cod1 = int.Parse(s[0]);
            quant1 = int.Parse(s[1]);
            preco1 = double.Parse(s[2], CultureInfo.InvariantCulture);

            s = Console.ReadLine().Split();
            cod2 = int.Parse(s[0]);
            quant2 = int.Parse(s[1]);
            preco2 = double.Parse(s[2], CultureInfo.InvariantCulture);

            double soma = 0.0;
            soma = (quant1 * preco1) + (quant2 * preco2);

            Console.WriteLine("VALOR A PAGAR: R$ " + soma.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
