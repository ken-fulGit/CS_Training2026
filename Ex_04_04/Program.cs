using System.Dynamic;
using Microsoft.VisualBasic;

namespace Ex_04_04;

class Program
{
    static void Main(string[] args)
    {
        var items = new Dictionary<int, Item>();
        items.Add(101, new Item(101, "水性ボールペン(黒)", 150));
        items.Add(102, new Item(102, "油性ボールペン(黒)", 100));
        items.Add(103, new Item(103, "鉛筆(黒)", 60));
        items.Add(104, new Item(104, "鉛筆(赤)", 80));
        Console.WriteLine($"{items.Count}個");
        Console.WriteLine($"103は{items[103]}");
        if (!items.ContainsKey(105))
        {
            Console.WriteLine("105はないです");
        }
        ShowItems(items);
        items.Remove(102);
        Console.WriteLine($"{items.Count}個");
        ShowItems(items);
        var sorted = items.OrderBy(d => d.Value.Price);
        foreach (var kv in sorted)
        {
            Console.WriteLine(kv.GetType());
        }


    }
    public static void ShowItems(Dictionary<int, Item> items)
    {
        Console.WriteLine("一覧表示");
        foreach (var key in items.Keys)
        {
            Console.WriteLine(items[key]);
        }
    }
}
