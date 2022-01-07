using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class FactoryMethod
    {
        public Pessoa getPessoa(string nome, string tipo)
        {
            if (tipo.Equals("PF"))
            {
                Console.WriteLine("Pessoa física");
                return new PessoaF(nome);
            }
            else if (tipo.Equals("PJ"))
            {
                Console.WriteLine("Vai ser juridica");
                return new PessoaJ(nome);
            }
            else
            {
                Console.WriteLine("Nada");
                return null;
            }
        }


    }

}
