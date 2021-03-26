using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao Gerenciador = new GerenciadorBonificacao();

            Funcionario Carlos = new Funcionario();
            Carlos.Nome = "Carlos";
            Carlos.CPF = "444.444.222.01";
            Carlos.Salario = 1000.00;

            Gerenciador.Registrar(Carlos);

            Diretor Roberta = new Diretor();
            Roberta.Nome = "Roberta";
            Roberta.CPF = "111.111.111.11";
            Roberta.Salario = 5000.00;

            Gerenciador.Registrar(Roberta);
            
            Console.WriteLine($"Total de bonificação: {Gerenciador.GetTotalBonificacao()}");
        }
    }
}
