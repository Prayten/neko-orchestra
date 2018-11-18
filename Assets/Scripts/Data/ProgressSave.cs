using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class ProgressSave : MonoBehaviour {


    private int NumLvl;
    private bool lvlComplete;
    private LoadLvlData LLD;
    private SaveLvlData SLD;
    private LvlCollection lvlCollection;
	// Use this for initialization
	void Start () {
        LLD = new LoadLvlData();
        lvlCollection = LLD.getLoad();
        Convert();
	}

    private void Convert()
    {
        string lvlname = SceneManager.GetActiveScene().name;
        NumLvl = int.Parse(lvlname.Substring(3));
    }

    public void setComplete()
    {
        lvlComplete = true;
    }

    private void OnApplicationQuit()
    {
        SLD = new SaveLvlData();
        if(lvlComplete)
        {
            lvlCollection.lvls[NumLvl-1].progress = true;
        }
        SLD.Save(lvlCollection);
    }
}
