using System;

namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {

        public bool Logar(Autenticavel p_funcionario, string p_senha)
        {
            bool usuarioAutenticado = p_funcionario.Autenticar(p_senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao Sistema");
                return true;
            }

            Console.WriteLine("Senha Incorreta");
            return false;

        }
    }
}
