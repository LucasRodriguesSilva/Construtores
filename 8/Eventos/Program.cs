using System;
using Eventos.Models;

namespace Eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematica m = new Matematica(10,20);
            m.Somar();
        }
    }
}
