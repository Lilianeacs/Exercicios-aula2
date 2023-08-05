namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioBruto = 0;
            double resultado = 0;
            do
            {
                Console.Clear();    
                Console.WriteLine("Digite seu salário bruto: ");                
            } while (!double.TryParse(Console.ReadLine(), out salarioBruto));
                      
            if (salarioBruto >= 1201 && salarioBruto <= 2500)
            {
                resultado = salarioBruto * 0.1;
                Console.WriteLine("O imposto a pagar é " + resultado.ToString("C"));
            }
            else if (salarioBruto >= 2501 && salarioBruto <= 5000)
            {
                resultado = salarioBruto * 0.15;
                Console.WriteLine("O imposto a pagar é " + resultado.ToString("C"));
            }
            else if (salarioBruto > 5000)
            {
                resultado = salarioBruto * 0.2;
                Console.WriteLine("O imposto a pagar é " + resultado.ToString("C"));
            }
            else
                Console.WriteLine("O valor é isento de imposto!");
        }
    }
}