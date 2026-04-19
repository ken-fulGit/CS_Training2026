namespace Ex_04_03;

public class Employee
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }
    public Employee(int id, string name, string address)
    {
        Id = id;
        Name = name;
        Address = address;
    }
    public Employee()
    {

    }
    public override string ToString()
    {
        return $"{Id},{Name},{Address}";
    }

}