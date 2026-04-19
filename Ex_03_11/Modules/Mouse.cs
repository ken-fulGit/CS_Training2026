namespace Ex_03_11.Modules;

public class Mouse : IUSB
{
    public void SendData()
    {
        Console.WriteLine("マウスデータ送信");
    }
    public void ReviceData()
    {
        throw new NotImplementedException();
    }
}