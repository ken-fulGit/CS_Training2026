namespace Ex_02_05;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("数値を入力して下さい");
        var input = int.Parse(Console.ReadLine());
        if(input % 2 ==0) {
            Console.WriteLine("偶数です");
        } else {
            Console.WriteLine("奇数です");
        }
        
    }
}
