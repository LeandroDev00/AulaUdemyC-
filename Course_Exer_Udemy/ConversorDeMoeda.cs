using System.Globalization;

namespace Course_Exer_Udemy
{
	public class ConversorDeMoeda
	{
		public static double IOF = 1.06;

		public static double calcDolar(double dolar, double vlrDolar)
		{
			return dolar * (vlrDolar * IOF);
		}
	}
}
