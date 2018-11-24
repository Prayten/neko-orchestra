using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class Configure : MonoBehaviour {

    private Load load;
    private Save save;
    private int lvlComplete;

    private string sceneName;
    private int lvl;
    // Use this for initialization

    void Start () {
        PlayerPrefs.SetInt("lvl" + 1, 0);
        PlayerPrefs.SetInt("lvl" + 2, 0);
        sceneName = SceneManager.GetActiveScene().name;
        lvl = int.Parse((sceneName.Substring(3)));
        print(lvl);
        load.loadLvls();
        if(lvlComplete != load.getProgress(lvl))
            lvlComplete = load.getProgress(lvl);
    }
    
    void OnApplicationQuit()
    {
        if(lvlComplete == 1)
        {
            save.setProgressComplete(lvl);
        }
        save.saveLvls();
    }
	
	
}
