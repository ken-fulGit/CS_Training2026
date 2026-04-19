namespace Ex_03_12.Modules;

public class DVDPlayer : Player
{
    public DVDPlayer(string media) : base(media)
    {

    }
    public override void Play()
    {
        Console.WriteLine($"DVDPlayer{Media}を再生しています。");
    }
    public override void Stop()
    {
        Console.WriteLine($"DVDPlayer{Media}の再生を停止しました。");
    }

}