using System.Globalization;

namespace Course_Exer_Udemy
{
	internal class Aluno
	{
		public string? NomeAluno;
		public double NotaA, NotaB, NotaC;

		public double NotaFinal()
		{
			return  NotaA + NotaB + NotaC;
			
		}

		public double FaltaPonto()
		{
			return 60 - NotaFinal();
		}

		public void ValidarNota()
		{
			if(NotaFinal() >= 60.0)
			{
				Console.WriteLine("APROVADO");
			}
			else if(NotaFinal() < 60.0)
			{
				Console.WriteLine("REPROVADO");
				Console.WriteLine("FALTARAM " + FaltaPonto().ToString("F2", CultureInfo.InvariantCulture)+ " PONTOS ");
			}
		}

		public override string ToString()
		{
			return "NOTA FINAL = " + NotaFinal().ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}
