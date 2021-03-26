using ByteBank.Exemplos;
using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao Gerenciador = new GerenciadorBonificacao();
            CalcularMaiorNumero Calcular = new CalcularMaiorNumero();


            Funcionario Carlos = new Funcionario();
            Carlos.Nome = "Carlos";
            Carlos.CPF = "444.444.222.01";
            Carlos.Salario = 1000.00;

            Gerenciador.Registrar(Carlos);
            Console.WriteLine($"Bonificação {Carlos.Nome}: {Carlos.GetBonificacao()}");

            Diretor Roberta = new Diretor();
            Roberta.Nome = "Roberta";
            Roberta.CPF = "111.111.111.11";
            Roberta.Salario = 5000.00;

            Gerenciador.Registrar(Roberta);
            Console.WriteLine($"Bonificação {Roberta.Nome}: {Roberta.GetBonificacao()}");

            Funcionario Pedro = new Diretor();
            Pedro.Nome = "Pedro";
            Pedro.CPF = "222.222.222.22";
            Pedro.Salario = 10000.00;

            Gerenciador.Registrar(Pedro);

            Console.WriteLine($"Total de bonificação: {Gerenciador.GetTotalBonificacao()}");

            Console.WriteLine($"O maior é: {Calcular.Maior(3,7,8)}");
            Console.WriteLine($"O maior é: {Calcular.MaiorNew(3, 7, 8)}");

        }
    }
}
