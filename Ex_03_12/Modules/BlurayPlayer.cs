namespace Ex_03_12.Modules;

public class BlurayPlayer : Player
{
    public BlurayPlayer(string media) : base(media)
    {

    }
    public override void Play()
    {
        Console.WriteLine($"BlurayPlayer{Media}を再生しています。");
    }
    public override void Stop()
    {
        Console.WriteLine($"BlurayPlayer{Media}の再生を停止しました。");
    }
    public override void Clush()
    {
        Console.WriteLine($"ブルーレイは壊しませんよ");
    }

}