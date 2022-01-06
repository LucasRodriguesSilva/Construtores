namespace ConstrutorHeranca.Models
{
    public class Pessoa
    {
        private string nome;
        private string sobrenome;
        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("Construtor classe Pessoa");
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Olá meu nome é: {nome} {sobrenome}");
        }
    }
}