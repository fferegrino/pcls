using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PclCalculadora.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculadora = new Calculadora();

            Console.WriteLine("Primer número:");
            calculadora.SetPrimerNumero(Int32.Parse(Console.ReadLine()));
            Console.WriteLine("Segundo número:");
            calculadora.SetSegundoNumero(Int32.Parse(Console.ReadLine()));

            Console.WriteLine("Resultado:");
            Console.WriteLine(calculadora.Calcula());
            Console.ReadLine();
        }
    }
}
