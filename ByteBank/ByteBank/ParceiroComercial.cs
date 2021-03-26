using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }

        public ParceiroComercial(string p_senha)
        {
            Senha = p_senha;
        }

        public bool Autenticar(string p_senha)
        {
            return Senha == p_senha;
        }
    }
}
