using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario Carlos = new Funcionario(1);
            Carlos.Nome = "Carlos";
            Carlos.CPF = "444.444.222.01";
            Carlos.Salario = 1000.00;

            Console.WriteLine(Carlos.GetBonificacao());
        }
    }
}
