using System.Runtime.CompilerServices;
using Ex_04_01_Lib;
namespace Ex_04_01;

class Program
{
    static void Main(string[] args)
    {
        Item item = new Item();
        item.ItemName = "だいこん";
        Console.WriteLine($"{item.ItemName}");
    }
}
