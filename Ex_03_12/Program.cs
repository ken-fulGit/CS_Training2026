using Ex_03_12.Modules;
namespace Ex_03_12;

class Program
{
    static void Main(string[] args)
    {
        Player player = new DVDPlayer("となりなトトロ");
        player.UseMachine();
        Player blurayPlayer = new BlurayPlayer("ライオンキング");
        blurayPlayer.UseMachine();
    }
}
