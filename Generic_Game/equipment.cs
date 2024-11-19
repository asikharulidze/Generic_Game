namespace Generic_Game;

public class Equipment
{
    public Inventory<Tool> Tools { get; set; }
    public Inventory<Armor> Armor { get; set; }
    public Inventory<Elixir> Elixirs { get; set; }

    public Equipment(Inventory<Tool> tools, Inventory<Armor> armor, Inventory<Elixir> elixirs)
    {
        Tools = tools;
        Armor = armor;
        Elixirs = elixirs;
    }
}