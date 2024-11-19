namespace Generic_Game;

using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Equipment equipment = new Equipment(
            new Inventory<Tool>(),
            new Inventory<Armor>(),
            new Inventory<Elixir>());
        
        equipment.Tools.AddItem(new Hammer("Iron Hammer", 10, 150, 5));
        equipment.Tools.AddItem(new Screwdriver("Steel Screwdriver", 2, 50, 3));
        
        equipment.Armor.AddItem(new Helmet("Steel Helmet", 5, 200, 4));
        equipment.Armor.AddItem(new Chestplate("Iron Chestplate", 15, 300, 6));
        
        equipment.Elixirs.AddItem(new HealingPotion("Minor Healing Potion", 1, 25, 2));
        equipment.Elixirs.AddItem(new StaminaPotion("Stamina Potion", 1, 30, 3));


        foreach (var tool in equipment.Tools.GetItems())
        {
            tool.Use();
        }

        foreach (var armor in equipment.Armor.GetItems())
        {
            armor.Equip();
        }

        foreach (var elixir in equipment.Elixirs.GetItems())
        {
            elixir.Drink();
        }
    }
}