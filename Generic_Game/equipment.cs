﻿namespace Generic_Game;

public class Equipment
{
    public string Tools { get; set; }
    public string Armor { get; set; }
    public string Elixirs { get; set; }
    
    public Equipment(string tools, string armor, string elixirs)
    {
        Tools = tools;
        Armor = armor;
        Elixirs = elixirs;
    }
}