using UnityEngine;
using System.IO;

public class FoodData{
    private FoodCollection foodCollection;

    private string foodPath = Application.dataPath + "/Data/foods.json";

    public FoodCollection LoadfoodData()
    {
        Debug.Log(Application.dataPath + "/Data/foods.json");
        using (StreamReader stream = new StreamReader(foodPath)) // Считывает весь JSON в строку
        {
            string json = stream.ReadToEnd();
            foodCollection = JsonUtility.FromJson<FoodCollection>(json);
        }

        Debug.Log("Foods loaded: " + foodCollection.foods.Length);
        return foodCollection;
    }

    public void SavefoodData(FoodCollection fCol)
    {
        using (StreamWriter stream = new StreamWriter(foodPath)) // Считывает весь JSON в строку
        {
            string json = JsonUtility.ToJson(fCol);
            stream.Write(json);
        }

        Debug.Log("Foods saved: " + fCol.foods.Length);
    }
}
