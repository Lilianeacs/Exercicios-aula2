namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double horasTrab = 0;
            double salarioHora = 0;
            double horaExtra = 0;
            double result = 0;
            bool ok1 = false;
            bool ok2 = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Digite o número de horas trabalhadas no mês: ");
                ok1 = double.TryParse(Console.ReadLine(), out horasTrab);
                Console.WriteLine("Digite o salário por hora: ");
                ok2 = double.TryParse(Console.ReadLine(), out salarioHora);
            } while (!ok1 && !ok2);


            if (horasTrab > 160)
            {
                horaExtra = horasTrab - 160;
                horaExtra *= (salarioHora * 0.5 + salarioHora);
                result = horaExtra + salarioHora * 160;

                Console.WriteLine("Seu salário é: " + result.ToString("C"));
            }
            else
            {
                result= horasTrab * salarioHora;
                Console.WriteLine("Seu salário é: " + result.ToString("C"));
            }
        }
    }
}