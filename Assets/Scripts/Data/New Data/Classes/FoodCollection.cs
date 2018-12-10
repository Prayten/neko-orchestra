
using System;

[Serializable]
public class FoodCollection{

    public Food[] foods;
    public string collectionName;

    public override string ToString()
    {
        string result = "Food Data\n";
        foreach (var food in foods)
        {
            result += string.Format("{0}\n Cost: {1}\n", food.name, food.cost);
        }
        return result;
    }
}
