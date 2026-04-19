namespace Ex_04_02;

class Program
{
    static void Main(string[] args)
    {
        DateTime now = DateTime.Now;
        DateTime afterNoew = now.AddMonths(1);
        Console.WriteLine($"{afterNoew.Month}");
        Console.WriteLine($"{now.DayOfWeek}");
        Console.WriteLine($"{now.Day}");
        Console.WriteLine($"{now.Month}");
        /*
        string input = Console.ReadLine();

        if (DateTime.IsLeapYear(int.Parse(input)))
        {
            Console.WriteLine("うるう年");
        }
        else
        {
            Console.WriteLine("うるう年ではない");
        }
    */
        Calculator<string> cal = new Calculator<string>("高", "橋");
        Console.WriteLine(cal.Add());
    }
}
