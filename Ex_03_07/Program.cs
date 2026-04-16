using System.Runtime.CompilerServices;

namespace Ex_03_07.Modules;


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
