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


            Funcionario Carlos = new Funcionario("444.444.222.01", 1000.00);
            Carlos.Nome = "Carlos";
            Carlos.AumentarSalario();

            Gerenciador.Registrar(Carlos);
            Console.WriteLine($"Bonificação {Carlos.Nome}: {Carlos.GetBonificacao()}");

            Diretor Roberta = new Diretor("111.111.111.11");
            Roberta.Nome = "Roberta";

            Gerenciador.Registrar(Roberta);
            Console.WriteLine($"Bonificação {Roberta.Nome}: {Roberta.GetBonificacao()}");

            Funcionario Pedro = new Diretor("222.222.222.22");
            Pedro.Nome = "Pedro";

            Gerenciador.Registrar(Pedro);

            Console.WriteLine($"Total de bonificação: {Gerenciador.GetTotalBonificacao()}");

            Console.WriteLine($"O maior é: {Calcular.Maior(3,7,8)}");
            Console.WriteLine($"O maior é: {Calcular.MaiorNew(3, 7, 8)}");
            Console.WriteLine($"Total de Funcionários: {Funcionario.TotalFuncionarios}");

        }
    }
}
