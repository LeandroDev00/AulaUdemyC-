using Course_Exer_Udemy;
using System.Globalization;
using ContaBancaria;

namespace App
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Retangulo r;
            r = new Retangulo();

            Console.WriteLine("Digite a largura e altura do retangulo:");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = "+ r.Area().ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("PERÍMETRO = " + r.Perimetro().ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("DIAGONAL = " +r.Diagonal().ToString("F2"), CultureInfo.InvariantCulture);
            Console.ReadLine();
            */
            /*
            Funcionario x = new Funcionario();
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();

            Console.Write("Salario Bruto: ");
            x.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            x.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: "+x);

            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double aument = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.AumentarSalario(aument);

            Console.WriteLine("Dados Atualizados: " + x);

            Console.ReadLine();
            */
            /*
            Aluno aluno = new Aluno();
            Console.Write("Nome do Aluno: ");
            aluno.NomeAluno = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.NotaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.NotaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.NotaC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(aluno);
            aluno.ValidarNota();

            Console.ReadLine();
            */
            /*
            Console.Write("Qual a cotação do dólar ? ");
            double vlrcota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares voce vai comprar ? ");
            double vlrReal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = "+ConversorDeMoeda.calcDolar(vlrReal, vlrcota).ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();
            */
            ContaBank conta, conta2;

            Console.Write("Entre com numero da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            Console.Write("Entre com Titular da Conta: ");
            string titular = Console.ReadLine();

            Console.Write("Havera deposito inicial (s/n) ? ");
            char res = char.Parse(Console.ReadLine());
            if (res == 's' || res == 'S')
            {
                Console.Write("Entre com valor de deposito inicial: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                conta = new ContaBank(numConta, titular, deposito);
            }
            else
            {
                conta = new ContaBank(numConta, titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.WriteLine("-------------------------------------------");
            Console.Write("Entre um valor para depósito: ");
            double vlrdeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(vlrdeposito);


            Console.WriteLine("Dados da conta Atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine("--------------------------------------------");

            Console.WriteLine();

            Console.Write("Entre um valor para Saque: ");
            double vlrsaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(vlrsaque);

            Console.WriteLine("Dados da conta Atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------");
            Console.Write("Deseja fazer uma transferencia entre contas ? (s/n): ");
            char resp = char.Parse(Console.ReadLine());


            if(resp == 's' || resp == 'S')
            {
                Console.Write("Digite a conta que fará a transferência: ");
                numConta = int.Parse(Console.ReadLine());

                Console.Write("Entre com valor transferido: ");
                double transferir = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                conta2 = new ContaBank(numConta);
                
                conta2.Deposito(transferir);
                conta.Deposito(transferir);

                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Dados atualizados:");
                Console.WriteLine("Conta: "+conta2.Numconta+ " Valor Transferido: $"+conta2.Saldo);
                Console.WriteLine(conta);

                Console.WriteLine();

                Console.WriteLine("FINALIZADO TRANSFERENCIA !");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("OK, FINALIZADO PROCESSO !");
                Console.ReadLine();
            }

        }
    }
}