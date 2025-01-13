using ExercicioFixacao;
using System.Globalization;

ContaBancaria conta;

Console.Write("Entre com o número da conta: ");
int numero = int.Parse(Console.ReadLine());
Console.Write("Entre com o titular da conta: ");
string titular = Console.ReadLine();
Console.Write("Haverá Deposito inicial (s/n)? ");
char opcao = char.Parse(Console.ReadLine());
if (opcao == 's' || opcao == 'S')
{
    Console.Write("Entre com o valor de depósito inicial: ");
    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    conta = new ContaBancaria(numero, titular, depositoInicial);
}
else
{
    conta = new ContaBancaria(numero, titular);
}

Console.WriteLine();
Console.WriteLine("Dados da conta: ");
Console.WriteLine(conta);

Console.WriteLine();
Console.Write("Entre um valor para depósito: ");
double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Depositar(quantia);

Console.WriteLine();
Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(conta);

Console.WriteLine();
Console.Write("Entre um valor para saque: ");
quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Sacar(quantia);

Console.WriteLine();
Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(conta);

