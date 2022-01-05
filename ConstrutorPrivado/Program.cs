using System;
using ConstrutorPrivado.Models; 

namespace ConstrutorPrivado
{
    class Program
    {
        static void Main(string[] args)
        {
            Log log = Log.GetInstance();
            
            log.PropriedadeLog = "Teste instancia";

            Log log2 = Log.GetInstance();
            System.Console.WriteLine(log2.PropriedadeLog);

        }
    }
}
