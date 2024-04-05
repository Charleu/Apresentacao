using System;

namespace Apresentacao
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Pessoa pessoa = new Pessoa("Charleu Limeira", 45, 1.90);
            Console.WriteLine($"Nome da pessoa: {pessoa.Nome}");
            Console.WriteLine($"A idade é: {pessoa.Idade} anos");
            Console.WriteLine($"A altura é: {pessoa.Altura} metros");
        }
    }
}
