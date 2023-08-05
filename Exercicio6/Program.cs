/*Leia um valor inteiro N. Este valor será a quan0dade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo,
mostrando essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para
fora do intervalo).
    */
namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quant = 0;
            int[] numInteiros;
            int dentroInter = 0;
            int foraInter = 0;

            Console.WriteLine("Digite a quantidade de números inteiros:");
            int.TryParse(Console.ReadLine(), out quant);

            numInteiros = new int[quant];
            for (int i = 0;i < numInteiros.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("Digite um número:");
                int.TryParse(Console.ReadLine(), out numInteiros[i]);
            }
            for (int i = 0; i < numInteiros.Length; i++)
            {
                if (numInteiros[i] >= 10 && numInteiros[i] <=20)
                {
                    dentroInter++;
                }else
                    foraInter++;
            }
            Console.Clear();
            Console.WriteLine($"{dentroInter} in");
            Console.WriteLine($"{foraInter} out");

        }
    }
}