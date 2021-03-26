using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        #region Atributos
        #endregion

        #region Construtor
        public Diretor()
        {

        }
        #endregion

        #region Métodos

        public override double GetBonificacao()
        {
            //Fazendo Referencia da nossa classe base
            return Salario + base.GetBonificacao();
        }

        #endregion
    }
}
