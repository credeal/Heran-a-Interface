using ByteBank.Exemplos;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();
            UsarSistema();

        }

        public static void UsarSistema()
        {
            SistemaInterno sistema = new SistemaInterno();

            Diretor Roberta = new Diretor("222.222.222.22");
            Roberta.Senha = "abcd";
            Roberta.Nome = "Roberta";

            GerenteDeConta Camila = new GerenteDeConta("444.444.444.44");
            Camila.Senha = "dcba";
            Camila.Nome = "Camila";


            sistema.Logar(Roberta, "abcd");
            sistema.Logar(Camila, "dcba");
             

        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario Pedro = new Designer("111.111.111.11");
            Pedro.Nome = "Pedro";

            Funcionario Roberta = new Diretor("222.222.222.22");
            Roberta.Nome = "Roberta";

            Funcionario Igor = new Auxiliar("333.333.333.33");
            Igor.Nome = "Igor";

            Funcionario Camila = new GerenteDeConta("444.444.444.44");
            Camila.Nome = "Camila";


            gerenciador.Registrar(Pedro);
            gerenciador.Registrar(Roberta);
            gerenciador.Registrar(Igor);
            gerenciador.Registrar(Camila);

            Console.WriteLine($"Total de bonificação do mês: R$ {gerenciador.GetTotalBonificacao()}");
        }
    }
}
