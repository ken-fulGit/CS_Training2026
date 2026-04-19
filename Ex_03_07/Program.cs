
using System.Runtime.CompilerServices;
using Ex_03_07.Modules;
namespace Ex_03_07;


static class Program
{
    static void Main(string[] args)
    {
        Item item = new Item
        {
            ItemNo = 1,
            ItemName = "Sample Item",
            Price = 100
        };
        item.print();
    }
}
