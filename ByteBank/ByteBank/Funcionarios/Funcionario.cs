namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        //0 - Funcionário
        //1 - Diretor
        //2 - Designer
        //N - ...

        #region Atributos
        private int _tipo;


        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }
        #endregion

        #region Construtor
        public Funcionario(int Tipo)
        {
            _tipo = Tipo;
        }
        #endregion

        #region Métodos
        public double GetBonificacao()
        {
            if (_tipo == 1)
                return Salario;

            return Salario * 0.10;
        }
        #endregion
    }
}
