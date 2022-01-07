using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PessoaF : Pessoa
    {
        public PessoaF(string nome)
        {
            this.nome = nome;
        }
    }
}
