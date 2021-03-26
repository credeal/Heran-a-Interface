using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario , IAutenticavel
    {
        #region Atributos
        public string Senha { get; set; }
        #endregion

        #region Construtor
        public FuncionarioAutenticavel(string cpf, double salario) : base(cpf,salario)
        {

        }
        #endregion

        #region Métodos
        public bool Autenticar(string p_senha)
        {
            return Senha == p_senha;
        }
        #endregion
    }
}
