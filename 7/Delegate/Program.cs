using System;
using Delegate.Models;

namespace Delegate
{
    class Program
    {
        // parâmetros do delegate tem que ser igual ao do método.
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
            // Delegate sem new.
            Operacao op1= Calculadora.Somar;
            
            // Adicionar mais um método para o delegate.
            op1 += Calculadora.Subtrair;
            
            // Delegate com new.
            Operacao op2 = new Operacao(Calculadora.Somar);
            
            // declarar com Invoke.
            op1.Invoke(20, 10);
            
            // Ou sem Invoke.
            op2(10,10);
        }
    }
}
