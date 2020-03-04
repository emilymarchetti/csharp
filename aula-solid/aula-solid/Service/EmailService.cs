using aula_solid.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_solid.Service
{
    internal class EmailService
    {
        public static void SendEmail(Pessoa pessoa)
            => Console.WriteLine($"Para: {pessoa.Email}; Mensagem: Olá sou {pessoa.Nome}");
    }
}
