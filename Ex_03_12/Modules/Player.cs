namespace Ex_03_12.Modules;

public abstract class Player
{
    public Player(string media)
    {
        this.Media = media;
    }
    public void UseMachine()
    {
        Play();
        Stop();
    }
    public string Media { get; set; }
    public abstract void Play();
    public abstract void Stop();
    public virtual void Clush()
    {
        Console.WriteLine("Player壊す！！！！");
    }
}