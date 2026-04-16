namespace Ex_03_06;

static class Program
{
    static void Main(string[] args)
    {
        var item = new Item();
        //Console.WriteLine(item);

        item.ChangePrice("300000");
        item.Print();
        Console.WriteLine(item.CalculateTaxAmount());
    }
}
