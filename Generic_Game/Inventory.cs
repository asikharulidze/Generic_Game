namespace Generic_Game;

public class Inventory<T> where T : Item
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void RemoveItem(T item)
    {
        items.Remove(item);
    }

    public double CalculateTotalWeight()
    {
        return items.Sum(item => item.Weight);
    }

    public IEnumerable<T> GetItems()
    {
        return items;
    }
}