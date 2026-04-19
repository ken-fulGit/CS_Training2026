//using Ex_03_14;

namespace Ex_03_15;

class Program
{
    static void Main(string[] args)
    {
        // int a = 20;
        // a = a.Add(20);
        // Console.WriteLine(a);
        Calculator cal = new Calculator();
        try
        {
            cal.Div(-10, 0);
        }
        catch (InputParameterLessThanZeroException e)
        {
            Console.WriteLine($"{e.Message}ですけんne");
        }
        catch (Exception e)
        {
            Console.WriteLine($"{e.TargetSite}ですけ");
        }

    }
}
