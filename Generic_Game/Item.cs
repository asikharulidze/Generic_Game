namespace Generic_Game;

public abstract class Item
{
    public double Weight { get; set; }
    public double Price { get; set; }
    public int RarityLevel { get; set; }
    
    public Item(double weight, double price, int rarityLevel)
    {
        Weight = weight;
        Price = price;
        RarityLevel = rarityLevel;
    }
}