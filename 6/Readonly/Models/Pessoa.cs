namespace Readonly.Models
{
    public class Pessoa
    {
        // Usando readonly só pode ser modificado no começo e com o construtor
        private readonly string nome = "Lucas";
        private readonly string sobrenome;
        public Pessoa()
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }
        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
        }
        public void Apresentar()
        {
             System.Console.WriteLine($"Olá, meu nome é: {nome} {sobrenome}");
        }
    }
}