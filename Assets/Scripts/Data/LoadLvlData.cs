using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class LoadLvlData : MonoBehaviour {

    public Text text;

    [SerializeField]
    private string lvlPath;
    
    private LvlCollectior lvlCollectior;
	
    private void LoadLvls()
    {
        using (StreamReader stream = new StreamReader(lvlPath))
        {
            string json = stream.ReadToEnd();
            print(json);
            lvlCollectior = JsonUtility.FromJson<LvlCollectior>(json);
        }
        print(lvlCollectior.lvlDatas[0].lvlName);
        Debug.Log("Levels loaded: " + lvlCollectior.lvlDatas.Length);
        text.text = lvlCollectior.ToString();
    }

    void Start()
    {
        LoadLvls();
    }
}
