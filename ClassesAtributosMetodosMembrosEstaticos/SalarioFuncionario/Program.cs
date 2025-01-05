using SalarioFuncionario;
using System.Globalization;

Funcionario a = new Funcionario();
Console.WriteLine("Dados do primeiro funcionário");
Console.Write("Nome: ");
a.nome = Console.ReadLine();
Console.Write("Salário: ");
a.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Funcionario b = new Funcionario();
Console.WriteLine("Dados do segundo funcionário");
Console.Write("Nome: ");
b.nome = Console.ReadLine();
Console.Write("Salário: ");
b.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double salarioMedio = (a.salario + b.salario) / 2.0;

Console.WriteLine("Salário medio = " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));