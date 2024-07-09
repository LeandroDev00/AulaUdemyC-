using System.Globalization;

namespace Course_Exer_Udemy
{
	internal class Funcionario
	{
		public string? Nome;
		public double SalarioBruto;
		public double Imposto;

		public double SalarioLiquido()
		{
			return SalarioBruto - Imposto;
		}

		public void AumentarSalario(double porcentagem)
		{
            double valorporcent = (SalarioBruto * (porcentagem / 100.00));
            SalarioBruto = SalarioBruto + valorporcent;
        }

		public override string ToString()
		{
			return Nome + ", $ " +SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}
