using System.Globalization;

namespace ContaBancaria
{
    public class ContaBank
    {
        public int Numconta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBank(int numconta, string titular)
        {
            Numconta = numconta;
            Titular = titular;
        }

        public ContaBank(int numconta, string titular, double depositoInicial) : this(numconta, titular)
        {
            Deposito(depositoInicial);
        }

        public ContaBank(int numconta)
        {
            Numconta = numconta;
        }

        public void Deposito(double deposito)
        {
             Saldo += deposito;
        }

        public void Saque(double ValorSaque)
        {
            Saldo -= ValorSaque;
        }

        public override string ToString()
        {
            return "Conta "+Numconta+ ", Titular: "+ Titular + ", Saldo: $"+Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}