using ExercicioMembroEstaticoDolar;
using System.Globalization;

Console.Write("Qual a cotação do dolar: ");
double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantos dolares você irá comprar? ");
double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Valor a ser pago em reais: " + ConversorDeMoeda.DolarParaReal(quantia, cotacao).ToString("F2", CultureInfo.InvariantCulture));
