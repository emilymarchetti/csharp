using aula_solid.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_solid.Service
{
    internal class ContaService
    {
        public static void Depositar(Conta conta, decimal valor)
        {
            conta.Saldo =+ valor;
        }

        public static void Sacar(Conta conta, decimal valor)
        {
            if (valor <= conta.Saldo)
            {
                conta.Saldo =- valor;
            }
        }
    }
}
