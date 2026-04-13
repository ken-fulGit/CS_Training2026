namespace Ex_02_08;

static class Program
{
    static void Main(string[] args)
    {
        var stations = new[]{"品川","大崎","五反田","目黒","恵比寿","渋谷","原宿","代々木","新宿"};
        //stations.ToList().ForEach(x => Console.WriteLine(x));
        Console.WriteLine("駅名を入力して下さい");
        var input = Console.ReadLine();
        foreach (var station in stations) {
            if(station == input) {
                continue;
            }
            Console.WriteLine(station);
        }
    }
}
