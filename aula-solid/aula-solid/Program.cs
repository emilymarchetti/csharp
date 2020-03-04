using aula_solid.Entidades;
using aula_solid.Entity;
using aula_solid.Service;
using aula_solid.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_solid
{
    class Program
    {
        static void Main(string[] args)
        {
            //var documento = "";
            //var nome = "";
            //var email = "";

            //while (documento == "")
            //{
            //    Console.WriteLine("Digite o seu cpf: ");
            //    documento = Console.ReadLine();
            //}

            //while (nome == "")
            //{
            //    Console.WriteLine("Digite o seu nome: ");
            //    nome = Console.ReadLine();
            //}

            //while (email == "")
            //{
            //    Console.WriteLine("Digite o seu email: ");
            //    email = Console.ReadLine();
            //}

            //EmailService.SendEmail(new Pessoa(documento, nome, email));

            var conta = new Conta(new Pessoa("645484884", "Emily", "emilymarchetti@outlook.com"), TipoConta.CONTA_POUPANCA)

            Console.ReadLine();

        }
    }
}
