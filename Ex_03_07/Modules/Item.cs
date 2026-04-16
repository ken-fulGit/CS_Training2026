namespace Ex_03_07;

public class Item
{
    public int ItemNo { get; set; }
    public string ItemName { get; set; }
    public int Price { get; set; }
    public void print()
    {
        Console.WriteLine($"ItemNo:{ItemNo}, ItemName:{ItemName}, Price:{Price}");
    }
}