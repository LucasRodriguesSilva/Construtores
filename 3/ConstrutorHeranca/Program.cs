using System;
using ConstrutorHeranca.Models;

namespace ConstrutorHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno p1 = new Aluno("Lucas","Rodrigues","Matemática");
            p1.Apresentar();
        }
    }
}