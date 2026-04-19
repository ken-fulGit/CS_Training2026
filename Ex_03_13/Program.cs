using System.Runtime.InteropServices;
using static Ex_03_13.Circle;
namespace Ex_03_13;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"{AreaCalculation(5)}");
        var circle = new Circle(5);
        Circle.PI = 3;

        Console.WriteLine($"{circle.AreaCalculation()}");
    }
}
