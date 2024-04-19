float n1 = 0, n2 = 0, n3 = 0, n4 = 0;
float resultado = 0;
int operacao;


Console.WriteLine("=====Calculadora=====");

Console.Write("Digite o primeiro numero: ");
n1 = float.Parse(Console.ReadLine());

do{
    Console.Write("Digite o segundo numero: ");
    n2 = float.Parse(Console.ReadLine());
    
    if(n2 == 0){
        Console.WriteLine("O numero digitado foi zero");
        Console.WriteLine("Tente novamente");
    }
} while (n2 == 0);

do{
    Console.Write("Digite o terceiro numero: ");
    n3 = float.Parse(Console.ReadLine());

    if (n3 == 0){
        Console.WriteLine("O numero digitado foi zero");
        Console.WriteLine("Tente novamente");
    }
} while (n3 == 0);

do{
    Console.Write("Digite o quarto numero: ");
    n4 = float.Parse(Console.ReadLine());

    if (n4 == 0){
        Console.WriteLine("O numero digitado foi zero");
        Console.WriteLine("Tente novamente");
    }
} while (n4 == 0);


do{
    Console.WriteLine("=============================");
    Console.WriteLine("Digite o numero da operacao");
    Console.WriteLine("1- Adição");
    Console.WriteLine("2- Subtracao");
    Console.WriteLine("3- Multiplicacao");
    Console.WriteLine("4- Divisão");

    Console.Write("Digite sua escolha: ");
    operacao = int.Parse(Console.ReadLine());

} while (operacao != 1 && operacao != 2 && operacao != 3 && operacao != 4);


if (operacao == 1)
    resultado = n1 + n2 + n3 + n4;
else if (operacao == 2)
    resultado = n1 - n2 - n3 - n4;
else if (operacao == 3)
    resultado = n1 * n2 * n3 * n4;
else
    resultado = n1 / n2 / n3 / n4;

Console.WriteLine("=============================");
Console.WriteLine($"Operacao escolhida: {operacao}");
Console.WriteLine($"Resultado: {resultado}");
Console.WriteLine("=============================");


Console.Write("\nDigite qualquer tecla para sair: ");
Console.ReadKey();
