namespace Ex_03_10.Modules;

public abstract class Player
{
    public Player(string media)
    {
        this.Media = media;
    }
    public string Media { get; set; }
    public abstract void Play();
    public abstract void Stop();
    public virtual void Clush()
    {
        Console.WriteLine("Player壊す！！！！");
    }
}