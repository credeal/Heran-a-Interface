namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        #region Atributos
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalFuncionarios { get; private set; }
        #endregion

        #region Construtor
        public Funcionario(string p_cpf , double p_salario)
        {
            CPF = p_cpf;
            Salario = p_salario;
            TotalFuncionarios++;
        }
        #endregion

        #region Métodos
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }

        public virtual void AumentarSalario()
        {
            //Salario = Salario + (Salario * 0.1);
            //Salario = Salario * 1.1;
            Salario *= 1.1;
        }
        #endregion
    }
}
