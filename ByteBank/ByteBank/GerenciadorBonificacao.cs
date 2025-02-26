﻿using ByteBank.Funcionarios;

namespace ByteBank
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;

        //Sobre-carga do método Registrar
        public void Registrar(Funcionario funcionario)
        {
           _totalBonificacao += funcionario.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
