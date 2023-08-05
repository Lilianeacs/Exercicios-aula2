namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[100];
            int numMaior = 0;
            int indiceNumMaior = 0;
            int numMenor = 0;
            int indiceNumMenor = 0;


            Random numAleatorio = new Random();

            for (int i = 0; i < vetor.Length; i++)
            { 
                vetor[i] = numAleatorio.Next();
            }
            
            for(int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] > numMaior)
                {                    
                    numMaior = vetor[i];
                    indiceNumMaior = i;
                }                
            }
            numMenor = numMaior;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] < numMenor)
                {
                    numMenor = vetor[i];
                    indiceNumMenor = i;
                }
            }           

            Console.WriteLine($"Número maior: {numMaior}" + Environment.NewLine +
                $" Posição do número: {indiceNumMaior}");
            Console.WriteLine($"Numero menor: {numMenor}" + Environment.NewLine +
                $"Posição do número: {indiceNumMenor}");
        }
    }
}