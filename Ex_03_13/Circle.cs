namespace Ex_03_13;

public class Circle
{

    public static double PI { get; set; } = 3.14;
    public int radius;
    public double AreaCalculation()
    {
        return radius * radius * PI;
    }
    public static double AreaCalculation(int radius)
    {
        return radius * radius * PI;
    }
    public Circle(int pradius)
    {
        this.radius = pradius;
    }
}