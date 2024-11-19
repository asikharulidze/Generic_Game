namespace Generic_Game;

public abstract class Item
{
    public double Weight { get; set; }
    public double Price { get; set; }
    public int RarityLevel { get; set; }
    public string Title { get; set; }

    public Item(string title, double weight, double price, int rarityLevel)
    {
        Title = title;
        Weight = weight;
        Price = price;
        RarityLevel = rarityLevel;
    }

    public override string ToString()
    {
        return $"Title: {Title}, Weight: {Weight}, Price: {Price}, Rarity Level: {RarityLevel}";
    }
}


public abstract class Tool : Item
{
    public Tool(string title, double weight, double price, int rarityLevel)
        : base(title, weight, price, rarityLevel) { }

    public abstract void Use();
}

public class Hammer : Tool
{
    public Hammer(string title, double weight, double price, int rarityLevel)
        : base(title, weight, price, rarityLevel) { }

    public override void Use()
    {
        Console.WriteLine($"Using {ToString()} to hammer nails!");
    }
}

public class Screwdriver : Tool
{
    public Screwdriver(string title, double weight, double price, int rarityLevel)
        : base(title, weight, price, rarityLevel) { }

    public override void Use()
    {
        Console.WriteLine($"Using {ToString()} to tighten screws!");
    }
}


public abstract class Armor : Item
{
    public Armor(string title, double weight, double price, int rarityLevel)
        : base(title, weight, price, rarityLevel) { }

    public abstract void Equip();
}

public class Helmet : Armor
{
    public Helmet(string title, double weight, double price, int rarityLevel)
        : base(title, weight, price, rarityLevel) { }

    public override void Equip()
    {
        Console.WriteLine($"Equipping {ToString()} for head protection!");
    }
}

public class Chestplate : Armor
{
    public Chestplate(string title, double weight, double price, int rarityLevel)
        : base(title, weight, price, rarityLevel) { }

    public override void Equip()
    {
        Console.WriteLine($"Equipping {ToString()} for chest protection!");
    }
}


public abstract class Elixir : Item
{
    public Elixir(string title, double weight, double price, int rarityLevel)
        : base(title, weight, price, rarityLevel) { }

    public abstract void Drink();
}

public class HealingPotion : Elixir
{
    public HealingPotion(string title, double weight, double price, int rarityLevel)
        : base(title, weight, price, rarityLevel) { }

    public override void Drink()
    {
        Console.WriteLine($"Drinking {ToString()} to restore health!");
    }
}

public class StaminaPotion : Elixir
{
    public StaminaPotion(string title, double weight, double price, int rarityLevel)
        : base(title, weight, price, rarityLevel) { }

    public override void Drink()
    {
        Console.WriteLine($"Drinking {ToString()} to restore stamina!");
    }
}