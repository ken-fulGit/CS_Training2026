namespace Ex_02_03;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("数値を入力");
        string? s = Console.ReadLine();
        int num = int.TryParse(s,out int result) ? result : 0;
        Console.WriteLine($"5を加算すると{num + 5}");
        Console.WriteLine($"5を減算すると{num - 5}");
    }
}
