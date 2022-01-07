using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá");

            FactoryMethod fd1 = new FactoryMethod();
            Pessoa p1 = fd1.getPessoa("AN", "PJ");
            Console.WriteLine(p1.nome);

            FactoryMethod fd2 = new FactoryMethod();
            Pessoa p2 = fd2.getPessoa("FE", "PJ");
            Console.WriteLine(p2.nome);

            Pessoa p3 = fd1.getPessoa("Snow", "Dog");
            Console.WriteLine(p3.nome);
        }

    }
}
