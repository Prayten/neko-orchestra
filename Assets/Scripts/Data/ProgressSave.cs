using UnityEngine;
using UnityEngine.SceneManagement;


public class ProgressSave{


    private int NumLvl;
    private bool lvlComplete;
    private LoadLvlData LLD;
    private SaveLvlData SLD;
    private LvlCollection lvlCollection;
	// Use this for initialization
	private void Start () {
        LLD = new LoadLvlData();
        lvlCollection = LLD.getLoad();
        Convert();
        Debug.Log("Progress Save Started.");
	}

    //Конвертирует имя сцены, чтобы получить номер уровня
    private void Convert()
    {
        string lvlname = SceneManager.GetActiveScene().name;
        NumLvl = int.Parse(lvlname.Substring(3));
    }

    public void setComplete()
    {
        Start();
        
        SLD = new SaveLvlData();
        
        lvlCollection.lvls[NumLvl - 1].progress = true;
        
        SLD.Save(lvlCollection);
    }



    
        
    
}
