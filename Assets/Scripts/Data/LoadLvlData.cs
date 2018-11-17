using UnityEngine;
using System.IO;

public class LoadLvlData{

    private LvlCollection lvlCollection;
    private readonly string lvlPath = "C:\\Obmen\neko-orchestra\\Assets\\Data\\lvls.json";    
    private void LoadLvls()
    {   

        using (StreamReader stream = new StreamReader(lvlPath)) // Считывает весь JSON в строку
        {
            string json = stream.ReadToEnd();
            lvlCollection = JsonUtility.FromJson<LvlCollection>(json);
        }
        
        Debug.Log("Levels loaded: " + lvlCollection.lvls.Length);
        
    }
    //Функция для внешнего вызова скрипта
    public LvlCollection getLoad()
    {
        LoadLvls();
        return lvlCollection;
    }
}
