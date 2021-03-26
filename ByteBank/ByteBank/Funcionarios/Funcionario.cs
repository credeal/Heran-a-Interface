namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        #region Atributos
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }
        #endregion

        #region Construtor
        public Funcionario()
        {
           
        }
        #endregion

        #region Métodos
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
        #endregion
    }
}
