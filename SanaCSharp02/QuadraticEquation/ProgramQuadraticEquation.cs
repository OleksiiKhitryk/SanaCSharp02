System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                    System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

Console.WriteLine("Enter please the value of coefficients a, b, c:");

Console.Write("a = ");
double a = double.Parse(Console.ReadLine());

Console.Write("b = ");
double b = double.Parse(Console.ReadLine());

Console.Write("c = ");
double c = double.Parse(Console.ReadLine());

double xRoot,x1Root, x2Root, discriminator;

if (a == 0 && b == 0)
    Console.WriteLine("Roots of equation are absent. Please write  down another coefficients: a, b.");
else if (a == 0 && b != 0)
{
    xRoot = -c / b;
    Console.WriteLine($"Root of equation is just one, x = {xRoot}");
}
else
{
    discriminator = Math.Pow(b, 2) - 4 * a * c;

    if (discriminator == 0)
    {
        xRoot = -b / (2 * a);
        Console.WriteLine($"Root of equation is just one, x = {xRoot}");
    }
    else if (discriminator > 0)
    {
        x1Root = (- b + Math.Sqrt(discriminator)) / (2 * a);
        x2Root = (- b - Math.Sqrt(discriminator)) / (2 * a);
        Console.WriteLine($"Roots of equation are, x1 = {x1Root}, x2 = {x2Root} ");
        Console.WriteLine($"Discriminator D = {discriminator}");
    }
    else
        Console.WriteLine($"Roots of equation are complex. Discriminator < 0, D = {discriminator}.  Please write  down another coefficients: a, b, c");
}