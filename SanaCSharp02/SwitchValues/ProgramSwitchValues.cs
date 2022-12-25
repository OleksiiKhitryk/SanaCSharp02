System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                    System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

Console.WriteLine("Enter please the integer  value between 0 and 9 :");
Console.Write("Number = ");
int number = int.Parse(Console.ReadLine());
if(number >= 0 && number <= 9) 
{
    switch (number)
    {
        case 0:
            Console.WriteLine($"{number} is zero");
            break;
        case 1:
            Console.WriteLine($"{number} is one");
            break;
        case 2:
            Console.WriteLine($"{number} is two");
            break;
        case 3:
            Console.WriteLine($"{number} is three");
            break;
        case 4:
            Console.WriteLine($"{number} is four");
            break;
        case 5:
            Console.WriteLine($"{number} is five");
            break;
        case 6:
            Console.WriteLine($"{number} is six");
            break;
        case 7:
            Console.WriteLine($"{number} is seven");
            break;
        case 8:
            Console.WriteLine($"{number} is eight");
            break;
        case 9:
            Console.WriteLine($"{number} is nine");
            break;
    }
}
else
    Console.Write($"The input Number = {number} is out of acceptable range [0...9]");
