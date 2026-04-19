namespace Ex_03_08.Modules;

public class Account
{
    public Account(string accountNo, string accountName, int blance)
    {
        AccountNo = accountNo;
        AccountName = accountName;
        Balance = blance;
    }
    public string? AccountNo { get; set; }
    public string? AccountName { get; set; }
    public int Balance { get; set; }
    public override string ToString()
    {
        return $"AccountNo:{AccountNo}, AccountName:{AccountName}, Balance:{Balance}";
    }
    public virtual void Print()
    {
        Console.WriteLine(ToString());
    }

}