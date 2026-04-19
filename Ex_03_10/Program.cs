using Ex_03_10.Modules;
namespace Ex_03_10;

class Program
{
    static void Main(string[] args)
    {
        Player player = new DVDPlayer("となりなトトロ");
        player.Play();
        player.Stop();
        Player blurayPlayer = new BlurayPlayer("ライオンキング");
        blurayPlayer.Play();
        blurayPlayer.Stop();
        player.Clush();
        blurayPlayer.Clush();
    }
}
