using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class LoadLvlData : MonoBehaviour {

    public Text text;

    [SerializeField]
    private string lvlPath;
    
    private LvlCollection lvlCollection;
    
    [ContextMenu("Load LvlData")]
    private void LoadLvls()
    {
        using (StreamReader stream = new StreamReader(lvlPath))
        {
            string json = stream.ReadToEnd();
            lvlCollection = JsonUtility.FromJson<LvlCollection>(json);
            
        }
        
        //Debug.Log("Levels loaded: " + lvlCollection.lvlDatas.Length);
        text.text = lvlCollection.ToString();
    }
}
