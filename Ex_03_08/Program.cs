using Ex_03_08.Modules;
namespace Ex_03_08;

static class Program
{
    static void Main(string[] args)
    {
        //        var netAccount = new NetAccount() { AccountNo = "100", AccountName = "山田太郎", Balance = 1000, Point = 100 };
        //        var warrior = new Warrior() { Name = "アーサー", hp = 100 };
        var netAccount = new NetAccount("20001", "高橋", 20000, 1000);
        netAccount.Print();
    }
}
