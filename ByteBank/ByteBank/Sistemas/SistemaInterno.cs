using System;

namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {

        public bool Logar(IAutenticavel usuario, string p_senha)
        {
            bool usuarioAutenticado = usuario.Autenticar(p_senha);

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
