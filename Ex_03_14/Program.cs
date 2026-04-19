using Ex_03_15;
namespace Ex_03_14;

class Program
{
    static void Main(string[] args)
    {
        Calculator cal = new Calculator();
        Console.WriteLine($"{cal.Div(10, 2)}");
        int num = 200;
        Console.WriteLine($"{num.Add(50)}");
        Console.WriteLine($"{num.Avarage(50)}");
    }
}
