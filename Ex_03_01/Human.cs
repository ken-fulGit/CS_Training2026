public class Human
{
    public string name;
    public int hp;
    public Human() : this("村悲母") { }
    public Human(string name) : this(name, 10)
    {
        this.name = name;
    }
    public Human(string name, int hp)
    {
        this.name = name;
        this.hp = hp;
    }

}