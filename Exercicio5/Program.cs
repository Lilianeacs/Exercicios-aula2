namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char opcao = ' ';
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            bool naoSair = true;

            do 
            {
                Console.Clear();
                Console.WriteLine("Selecione o tipo de combustível: ");
                Console.WriteLine("1 - Álcool ");
                Console.WriteLine("2 - Gasolina ");
                Console.WriteLine("3 - Diesel ");
                Console.WriteLine("4 - Fim ");

               char.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case '1':
                        alcool++;
                        break;

                    case '2':
                        gasolina++;
                        break;

                    case '3':
                        diesel++;
                        break;

                    case '4':
                        naoSair = false;
                        break;
                    default: 
                        Console.WriteLine("O Código informado é inválido (fora da faixa de 1 a 4). Tente novamente.");
                        Console.ReadKey();
                        break;
                }
            } while(naoSair);

            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine($"Álcool: {alcool}" + Environment.NewLine + $"Gasolina: {gasolina}"
                + Environment.NewLine + $"Diesil: {diesel}");
        }
    }
}