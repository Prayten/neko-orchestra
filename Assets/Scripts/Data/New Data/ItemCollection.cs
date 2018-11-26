using System;

[Serializable]
public class ItemCollection{

    public Item[] items;
    public string collectionName;

    public override string ToString()
    {
        string result = "Lvl Data\n";
        foreach (var item in items)
        {
            result += string.Format("{0}\n Cost: {1}\nSaled: {2}\nPower: {3}\n", item.name, item.cost, item.saled, item.power);
        }
        return result;
    }
}
