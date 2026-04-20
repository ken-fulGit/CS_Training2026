using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace Ex_04_05;

class Program
{
    static void Main(string[] args)
    {
        var item = new Item(100, "みかん", 1400);
        var jsonStr = JsonConvert.SerializeObject(item);
        Console.WriteLine(jsonStr);
        var item2 = JsonConvert.DeserializeObject<Item>(jsonStr);
        Console.WriteLine(item2);
        JObject jsonObj = JObject.Parse(jsonStr);
        Console.WriteLine($"{jsonObj["Name"]}");
        File.WriteAllText("item.json", jsonStr);
    }
}
