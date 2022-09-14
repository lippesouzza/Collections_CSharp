using System;
using System.Collections.Generic;

namespace Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> livro = new Stack<string>();

            livro.Push("O Mundo de Sofia");
            livro.Push("O Dia do Coringa");
            livro.Push("O CAPITAL");

            Console.WriteLine($"{livro.Peek()}");

            livro.Pop();

            Console.WriteLine($"{livro.Count}");

            foreach (var item in livro)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}