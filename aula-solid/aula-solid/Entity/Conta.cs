using aula_solid.Entidades;
using aula_solid.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_solid.Entity
{
    class Conta
    {
        public Pessoa Pessoa { get; private set; }
        public decimal Saldo { get; set; }
        public TipoConta TipoConta { get; private set; }

        public Conta(Pessoa pessoa, TipoConta tipoConta)
        {
            Pessoa = pessoa;
            Saldo = 0.00m;
            TipoConta = tipoConta;
        }
    }
}
