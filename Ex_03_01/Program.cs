namespace Ex_03_01;

class Program
{
    static void Main(string[] args)
    {
        var human = new Human();
        Console.WriteLine($"名前:{human.name} 体力:{human.hp}");
        // var item = new Item();
        // item.itemNo = 100;
        // item.itemName = "iphone";
        // item.price = 300;
        var item = new Item() { itemNo = 100, itemName = "iphone", price = 300 };
        //Console.WriteLine(item);
        item.ChangePrice(300000);
        item.Print();
        Console.WriteLine(item.CalculateTaxAmount());
    }
}
