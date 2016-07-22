using System;

namespace BusinnessLayer
{
    public class Calculadora
    {
        public Calculadora(string nome)
        {
            Console.WriteLine($"Calculadora {nome}");
            Console.WriteLine(string.Empty);
        }

        public int soma(int a, int b)
        {
            return a + b;
        }

        public int subtracao(int a, int b)
        {
            return a - b;
        }

        public int divisao(int a, int b)
        {
            return a / b;
        }

        public int multiplicacao(int a, int b)
        {
            return a * b;
        }
    }
}
