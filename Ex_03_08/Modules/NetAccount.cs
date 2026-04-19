namespace Ex_03_08.Modules;

public class NetAccount : Account
{
    public NetAccount(string accountNo, string accountName, int blance, int point)
        : base(accountNo, accountName, blance)
    {
        Point = point;
    }
    public int Point
    {
        get; set;
    }
    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Point:{Point}");
    }

    public override string ToString()
    {
        return base.ToString() + $", Point:{Point}";
    }
}