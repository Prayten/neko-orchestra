using System.IO;
using UnityEngine;

public class ShopData
{

    private ItemCollection itemCollection;
    private string itemPath = "C:\\Obmen\\neko-orchestra\\Assets\\Data\\items.json";

    //Загрузка прогресса
    public ItemCollection LoadShopData()
    {
        using (StreamReader stream = new StreamReader(itemPath)) // Считывает весь JSON в строку
        {
            string json = stream.ReadToEnd();
            itemCollection = JsonUtility.FromJson<ItemCollection>(json);
        }
        
        Debug.Log("Levels loaded: " + itemCollection.items.Length);
        return itemCollection;
    }
    //Сохранение прогресса
    public void SaveShopData(ItemCollection iCol)
    {
        using (StreamWriter stream = new StreamWriter(itemPath)) // Считывает весь JSON в строку
        {
            string json = JsonUtility.ToJson(iCol);
            stream.Write(json);
        }

        Debug.Log("Levels saved: " + iCol.items.Length);
    }


}

