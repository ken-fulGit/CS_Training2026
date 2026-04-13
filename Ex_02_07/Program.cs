namespace Ex_02_07;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write($"数値を入力して下さい->");
        var input = int.Parse(Console.ReadLine());
        if(input < 0){
            Console.WriteLine("負の数です");
        } else if(input > 0) {
            Console.WriteLine("正の数です");
        } else {
            Console.WriteLine("0です");
        }
    }
}
