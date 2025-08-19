// Aula 1
Console.WriteLine("Hello World");

//// Aula 2
Console.WriteLine("Digite um número: ");
double numero1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite outro número: ");
double numero2 = Convert.ToDouble(Console.ReadLine());

double soma = numero1 + numero2;
double multiplicacao = numero1 * numero2;
double subtracao = numero1 - numero2;
double divisao = numero1 / numero2;

Console.WriteLine("A soma de " + numero1 + numero2, "é igual a:" + soma);
Console.WriteLine("A multiplicacao de " + numero1 + numero2, "é igual a:" + multiplicacao);
Console.WriteLine($"A subtração de {0} e {1} é igual a: {2}", numero1, numero2, soma);
Console.WriteLine($"A divisão de {0} e {1} é igual a {2}", numero1, numero2, divisao);
