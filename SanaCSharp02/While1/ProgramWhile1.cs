System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                    System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

double a = 0, b = 0;
int c = 0, n = 0, i = 0, k = 0, factorial;

Console.Write("Enter please a natural number n = ");
n = int.Parse(Console.ReadLine());
if (n > 0)
{
    while (i < n)
    {
        i++;
        a = a + Math.Pow(-1, i) / (2 * i + 1);

        b = b + (1 + 1 / Math.Pow(i, 2));

        factorial = 1;
        for (k = 0; k < i; k++)
            factorial = factorial * (i - k);
        c = c + factorial;

    }
    Console.WriteLine($"a = {a}");
    Console.WriteLine($"b = {b}");
    Console.WriteLine($"c = {c}");
}
else
{
    Console.WriteLine($"A number n = {n} isn't natural number ");
}

