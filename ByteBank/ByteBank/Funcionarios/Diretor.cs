using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor
    {
        #region Atributos
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }
        #endregion

        #region Construtor
        public Diretor()
        {

        }
        #endregion

        #region Métodos
        public double GetBonificacao()
        {
            return Salario;
        }
        #endregion
    }
}
