namespace Ex_03_11.Modules;

public class FlashMemory : IUSB
{
    public void SendData()
    {
        Console.WriteLine("フラッシュメモリ送信");
    }
    public void ReviceData()
    {
        Console.WriteLine("フラッシュメモリ記録");
    }
}