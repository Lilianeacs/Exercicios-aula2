namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ok1 = false;
            bool ok2 = false;
            bool ok3 = false;
            int quantAtual = 0;
            int quantMax = 0;
            int quantMin = 0;
            int quantMedia = 0;

            do
            {
                Console.Clear(); 
                Console.WriteLine("Digite a quantidade atual em estoque:");
                ok1 = int.TryParse(Console.ReadLine(), out quantAtual);
                Console.WriteLine("Digite a quantidade máxima em estoque:");
                ok2 = int.TryParse(Console.ReadLine(), out quantMax);
                Console.WriteLine("Digite a quantidade mínima em estoque:");
                ok3 = int.TryParse(Console.ReadLine(), out quantMin);

            } while(!ok1 && !ok2 && !ok3);
            
            quantMedia = (quantMax + quantMin) / 2;

            if (quantAtual >= quantMedia)
                Console.WriteLine("Não efetuar compra!");
            else
                Console.WriteLine("Efetuar compra!");
        }
    }
}