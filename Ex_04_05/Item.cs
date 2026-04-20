public class Item
{
    public int No { get; set; }
    public String Name { get; set; }
    public int Price { get; set; }
    public Item(int no, string name, int price)
    {
        No = no;
        Name = name;
        Price = price;
    }
    public Item()
    {

    }
    public override string ToString()
    {
        return $"{No},{Name},{Price}";
    }
}