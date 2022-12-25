System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                    System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

Console.WriteLine("Enter please the value of marks for current student between 1 and 5 :");
int mark, sum = 0, i;

for (i = 1; i <= 5; i++)
{
    Console.Write($"Mark{i} = ");
    mark = int.Parse(Console.ReadLine());
    if (mark >= 1 && mark <= 5)
    {
        sum += mark;
        if (i == 5)
        {
            mark = sum / 5;
            if (mark >= 4)
                Console.WriteLine($"Student IS admitted to the exam due to evarage mark = {mark}.");
            else
                Console.WriteLine($"Student ISN'T admitted to the exam due to evarage mark = {mark}.");
        }
    }
    else
    {
        Console.WriteLine($"The input mark aren't in acceptable range 1...5");
        break;
    }
}




