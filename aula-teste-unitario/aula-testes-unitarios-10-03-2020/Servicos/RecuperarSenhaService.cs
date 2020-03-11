using aula_testes_unitarios_10_03_2020.Entidades;
using aula_testes_unitarios_10_03_2020.Interfaces;
using aula_testes_unitarios_10_03_2020.Repositorio;
using System;
using System.Linq;

namespace aula_testes_unitarios_10_03_2020.Servicos
{
    internal class RecuperarSenhaService : ISubitemMenu
    {
        private readonly UsuarioRepositorio _usuarioRepositorio;

        public RecuperarSenhaService(UsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public void Executar()
        {
            Console.WriteLine("Informe seu usuário: ");
            var nomeUsuario = Console.ReadLine();
            var usuario = _usuarioRepositorio.GetAll().FirstOrDefault(x => x.Nome.Equals(nomeUsuario));

            if (usuario == null)
            {
                Console.WriteLine("Usuário inválido.");
                return;
            }

            Console.WriteLine("Informe a nova senha: ");
            var senhaUsuario = Console.ReadLine();

            Console.WriteLine("Informe a nova senha novamente: ");
            var senhaUsuarioDois = Console.ReadLine();

            if (senhaUsuario != senhaUsuarioDois)
            {
                Console.WriteLine("Senhas não conferem.");
                return;
            }
                
            usuario.SetSenha(senhaUsuario);
            _usuarioRepositorio.Update(usuario);

            Console.WriteLine("Senha alterada com sucesso!");
        }
    }
}
