namespace Ex_04_03;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new();
        for (int i = 0; i < 3; i++)
        {
            employees.Add(new Employee(i + 1, $"名前{i + 1}さん", $"住所{i + 1}さん"));
        }
        //        employees.Sort((a, b) => b.Id.CompareTo(a.Id));
        //        var sorted = employees.OrderByDescending(e => e.Id).ToList();
        var sorted = employees.OrderByDescending(e => e.Name).ToList();
        employees.ForEach(Console.WriteLine);
        sorted.ForEach(Console.WriteLine);
    }
}
