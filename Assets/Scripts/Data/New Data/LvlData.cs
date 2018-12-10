using System.IO;
using UnityEngine;


public class LvlData{


    private LvlCollection lvlCollection;

    private string lvlPath = Application.dataPath + "/Data/lvls.json";

    public LvlCollection LoadLvlData()
    {
        Debug.Log(Application.dataPath + "/Data/lvls.json");
        using (StreamReader stream = new StreamReader(lvlPath)) // Считывает весь JSON в строку
        {
            string json = stream.ReadToEnd();
            lvlCollection = JsonUtility.FromJson<LvlCollection>(json);
        }

        Debug.Log("Levels loaded: " + lvlCollection.lvls.Length);
        return lvlCollection;
    }

    public void SaveLvlData(LvlCollection lCol)
    {
        using (StreamWriter stream = new StreamWriter(lvlPath)) // Считывает весь JSON в строку
        {
            string json = JsonUtility.ToJson(lCol);
            stream.Write(json);
        }

        Debug.Log("Levels saved: " + lCol.lvls.Length);
    }


}
