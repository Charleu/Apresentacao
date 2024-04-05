using System;

namespace Apresentacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Charleu", 30, 1.75);
            pessoa.Apresentar();
        }
    }
}
