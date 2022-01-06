using System;

namespace Readonly
{
    class Program
    {
        static void Main(string[] args)
        {
            // Não pode ser modificado depois e também não pode ser vazio.
            // Serve para números que não são imutáveis.
            const double pi =  3.14;
            System.Console.WriteLine(pi);
        }
    }
}
