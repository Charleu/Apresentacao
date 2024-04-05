using System;

namespace Apresentacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Charleu", 43, 1.90);
            pessoa.Apresentar();
        }
    }
}
