using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveLvlData : MonoBehaviour {

    //В процессе
    private readonly string lvlPath = "C:\\Obmen\neko-orchestra\\Assets\\Data\\lvls.json";

    private void SaveLvl(LvlCollection lCol)
    {

        using (StreamWriter stream = new StreamWriter(lvlPath)) // Считывает весь JSON в строку
        {
            string json = JsonUtility.ToJson(lCol);
            stream.Write(json);
        }

        Debug.Log("Levels saved: " + lCol.lvls.Length);
    }

    public void Save(LvlCollection lCol)
    {
        SaveLvl(lCol);
    }
}
