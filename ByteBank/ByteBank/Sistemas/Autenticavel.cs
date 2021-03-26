using ByteBank.Funcionarios;

namespace ByteBank.Sistemas
{
    public abstract class Autenticavel : Funcionario
    { 
        #region Atributos
        public string Senha { get; set; }
        #endregion

        public Autenticavel(string cpf, double salario) : base(cpf,salario)
        {

        }

        #region Métodos
        public bool Autenticar(string p_senha)
        {
            return Senha == p_senha;
        }
        #endregion
    }
}
