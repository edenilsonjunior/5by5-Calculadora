float n1 = 0, n2 = 0, resultado = 0;
char operacao;

Console.WriteLine("\n-----Calculadora-----\n");

Console.Write("Digite o primeiro numero: ");
n1 = float.Parse(Console.ReadLine());


Console.Write("Digite o segundo numero: ");
n2 = float.Parse(Console.ReadLine());

while(n2 == 0)
{
    Console.Write("Numero invalido, digite novamente: ");
    n2 = float.Parse(Console.ReadLine());
}

Console.Write("Digite o caractere da operacao(+-*/): ");
operacao = char.Parse(Console.ReadLine());

while(operacao != '+' && operacao != '-' && operacao != '*' && operacao != '/')
{
    Console.WriteLine("Operacao errada.");
    Console.Write("Digite o caractere da operacao(+-*/): ");
    operacao = char.Parse(Console.ReadLine());
}

if (operacao == '+')
    resultado = n1 + n2;
else if (operacao == '-')
    resultado = n1 - n2;
else if (operacao == '*')
    resultado = n1 * n2;
else
    resultado = n1 / n2;

Console.WriteLine("=============================");
Console.WriteLine($"Operacao escolhida: {operacao}");
Console.WriteLine($"Resultado: {resultado}");
Console.WriteLine("=============================");


Console.Write("\nDigite qualquer tecla para sair: ");
Console.ReadKey();