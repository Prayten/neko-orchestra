using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class LoadLvlData : MonoBehaviour {

    private LvlCollection lvlCollection;
    
    
    [ContextMenu("Load LvlData")]
    private void LoadLvls(string lvlPath)
    {
        using (StreamReader stream = new StreamReader(lvlPath))
        {
            string json = stream.ReadToEnd();
            lvlCollection = JsonUtility.FromJson<LvlCollection>(json);
        }
        
        Debug.Log("Levels loaded: " + lvlCollection.lvls.Length);
        
    }

    public LvlCollection getLoad(string lvlPath)
    {
        LoadLvls(lvlPath);
        print(lvlCollection.ToString());
        return lvlCollection;
    }

}
