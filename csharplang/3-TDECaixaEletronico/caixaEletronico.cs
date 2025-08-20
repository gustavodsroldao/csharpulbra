using System;

partial class Program
{
    static void Main()
    {
        double saldo = 1000.00;
        int opcao;

        do
        {
            Console.WriteLine("Olá, seja bem vindo ao caixa eletronico");
            Console.WriteLine("1 - Ver saldo");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3 - Sacar");
            Console.WriteLine("4 - Sair");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine($"Saldo disponível: R$ {saldo}");
                    break;
                case 2:
                    Console.WriteLine("Digite o valor a ser depositado: ");
                    double valorDeposito = Convert.ToDouble(Console.ReadLine());

                    if (valorDeposito > 0)
                    {
                        saldo += valorDeposito;
                        Console.WriteLine($"Novo saldo é de: R$ {saldo}");
                       
                    }
                    else
                    {
                        Console.WriteLine("O valor deve ser maior que 0");
                    }
                    break;
                case 3:
                    Console.Write("Digite o valor a ser sacado: ");
                    double valorASacar = Convert.ToDouble(Console.ReadLine());

                    if (valorASacar > 0)
                    {
                        saldo -= valorASacar;
                        Console.WriteLine($"Novo saldo é de: R$ {saldo}");
                    }
                    else
                    {
                        Console.WriteLine("O valor a sacar deve ser maior que 0");
                    }
                    break;
                case 4:
                    Console.WriteLine("Obrigado por usar nosso caixa eletronico");
                    break;
                    
            }
        } while (opcao != 4);
    }
}