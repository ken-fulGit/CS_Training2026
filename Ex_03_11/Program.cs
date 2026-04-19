using System.Security.Cryptography.X509Certificates;
using Ex_03_11.Modules;
namespace Ex_03_11;

class Program
{
    static void Main(string[] args)
    {

        IUSB dis = new Display();
        IUSB flash = new FlashMemory();
        IUSB mouse = new Mouse();
        IUSB[] usbs = { new Display(), new FlashMemory(), new Mouse() };
        //        usbs[0].SendData();
        usbs[0].ReviceData();
        usbs[1].ReviceData();
        usbs[1].SendData();
        usbs[2].SendData();
    }
}
