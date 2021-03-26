using ByteBank.Funcionarios;

namespace ByteBank.Sistemas
{
    public interface IAutenticavel
    {
        #region Atributos
        #endregion


        #region Métodos
        bool Autenticar(string p_senha);
        
        #endregion
    }
}
