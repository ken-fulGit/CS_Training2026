namespace Ex_02_04;

class Program
{
    static void Main(string[] args)
    {
        //var array = new string[10];
//        var array = new[] {"りんご","アボガド","どりあん"};
        // string[] array =  {"りんご","アボガド","どりあん"};
        // Array.ForEach(array,x=>Console.WriteLine(x));
        // Console.WriteLine($"要素数:{array.Length}");
        // int[,] arraysA = new int[3, 3];
        // int[,] arraysB = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        // for(int i = 0; i < arraysB.GetLength(0);i++) {
        //     for(int j = 0; j < arraysB.GetLength(1);j++) {
        //         Console.Write($"{arraysB[i,j]}\t");
        //     }
        //     Console.WriteLine();
        // }
        // arraysB.Cast<int>().ToList().ForEach(x=>Console.WriteLine(x));
        int[] array = new int[3];
        Console.WriteLine($"数値1を入力して下さい");
        array[0] = int.Parse(Console.ReadLine());
        Console.WriteLine($"数値2を入力して下さい");
        array[1] = int.Parse(Console.ReadLine());
        Console.WriteLine($"数値3を入力して下さい");
        array[2] = int.Parse(Console.ReadLine());
        Console.WriteLine("入力結果");
        for(int i= 0; i < array.Length;i++) {
            Console.WriteLine($"数値{i+1}:{array[i]}");
        }

    }
}
