using System;
using System.Collections.Generic;

namespace Fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> pessoas = new Queue<string>();

            pessoas.Enqueue("Amanda");
            pessoas.Enqueue("Gabriela");
            pessoas.Enqueue("Fabíola");
            pessoas.Enqueue("Bárbara");
            pessoas.Enqueue("Mariana");

            Console.WriteLine($"{pessoas.Dequeue()}");

            pessoas.Peek();

            Console.WriteLine($"{pessoas.Count}");

            foreach (string nome in pessoas)
            {
                Console.WriteLine($"{nome}");
            }
        }
    }
}