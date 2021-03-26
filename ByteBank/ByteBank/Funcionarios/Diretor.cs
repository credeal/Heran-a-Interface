using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        #region Construtor
        public Diretor(string cpf) : base(cpf,5000)
        {
            
        }
        #endregion

        #region Métodos

        public override double GetBonificacao()
        {
            //Fazendo Referencia da nossa classe base
            //return Salario + base.GetBonificacao();
            return Salario * 0.50;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }


        #endregion
    }
}
