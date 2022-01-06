using System;
using GetSet.Models;

namespace GetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            //Mês inválido
            data.SetMes(20);
            data.ApresentarMes();
            //Mês valido
            data.SetMes(12);
            data.ApresentarMes();
        }
    }
}
