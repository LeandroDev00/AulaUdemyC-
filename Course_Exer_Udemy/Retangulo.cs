using System;
using System.Globalization;

namespace Course_Exer_Udemy
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;
        
        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            double hipotenusa = (Math.Pow(Largura,2) + Math.Pow(Altura,2));
            return Math.Sqrt(hipotenusa);
        }
    }
}
