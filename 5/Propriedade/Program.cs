using System;
using Propriedade.Models;

namespace Propriedade
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();

            data.Mes = 20;

            data.ApresentarMes();
        }
    }
}
