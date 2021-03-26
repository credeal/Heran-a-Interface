namespace ByteBank.Exemplos
{
    public class CalcularMaiorNumero
    {
        public double Maior(double n1, double n2)
        {
            if (n1 > n2)
                return n1;

            return n2;
        }

        public double Maior(double n1, double n2, double n3)
        {
            if(n1 > n2)
            {
                if (n1 > n3)
                    return n1;
            }

            if (n2 > n3)
                return n2;

            return n3;
        }

        public double MaiorNew(double n1, double n2, double n3)
        {
            return Maior(Maior(n1, n2), n3);
        }
    }
}
