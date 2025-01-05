using AreaTriangulo;
using System.Globalization;

Console.WriteLine("Entre com as medidas do triângulo X: ");
Triangulo x = new Triangulo();
x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do triângulo Y: ");
Triangulo y = new Triangulo();
y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double areaX = x.Area();
double areaY = y.Area();

Console.WriteLine("Area de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

if (areaX > areaY)
{
    Console.WriteLine("Maior area: X");
}
else
{
    Console.WriteLine("Maior area: Y");
}




