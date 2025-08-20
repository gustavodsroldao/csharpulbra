namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 18;

            // if else
            if (idade >= 18) 
            {
                Console.WriteLine("Voce é maior de idade");
            } 
            else 
            {
                Console.WriteLine("Voce é menor de idade");
            }

            // Switch
            string? cor = "vermelho";

            switch (cor) 
            {
                case "vermelho":
                    Console.WriteLine("A cor é vermelha");
                    break;
                default:
                    Console.WriteLine("A cor não é vermelha");
                    break;
            }

            // For
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Contador: {i}");
            }

            // While
            int contador = 0;

            while (contador < 5)
            {
                Console.WriteLine($"Contador: {contador}");
                contador++;
            }

            // DoWhile
            int contadorDoWhile = 0;

            do
            {
                Console.WriteLine($"Contador do-while: {contadorDoWhile}");
                contadorDoWhile++;
            } while (contadorDoWhile < 5); // Executa uma única vez se a condição não for verdadeira

            // break e continue
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine("Caiu no continue");
            }
        }
    }
}
