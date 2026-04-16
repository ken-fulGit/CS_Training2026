public class Item
{
    public int itemNo;
    public string itemName;
    public int price;
    public double salesTaxRate = 0.10;
    public Item(int pitemNo, string pitemName, int pprice)
    {
        itemNo = pitemNo;
        itemName = pitemName;
        price = pprice;
    }
    public Item()
    {

    }
    public override string ToString()
    {
        return $"商品番号:{itemNo},商品名:{itemName},価格:{price}";
    }
    public void Print()
    {
        Console.WriteLine($"商品番号:{itemNo},商品名:{itemName},価格:{price}");
    }
    public void ChangePrice(int price)
    {
        this.price = price;
    }
    public int CalculateTaxAmount()
    {
        return (int)(salesTaxRate * price) + price;
    }
}