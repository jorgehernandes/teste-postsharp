using System;
using BusinnessLayer;

namespace TestePostSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora("TestePostSharp");

            int resultado = calculadora.divisao(5, 0);

            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}