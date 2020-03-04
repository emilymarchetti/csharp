using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_solid.Entidades
{
    public class Pessoa
    {
        public string Documento { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }

        public Pessoa(string documento, string nome, string email)
        {
            Documento = documento ?? throw new Exception("Documento não informado.");
            Nome = nome ?? throw new Exception("Nome não informado.");
            Email = email ?? throw new Exception("Email não informado.");
        }
    }
}
