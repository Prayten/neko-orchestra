using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointcon : MonoBehaviour {

    private int neededScore;
    
    public GameObject LvlSettings;
    public GameObject globarVar; //!!! Переделать!!!
    private int score = 0;
	// Use this for initialization
	void Start () {
        print("Pointcon");
        
	}

    private void Update()
    {
        score = globarVar.GetComponent<global_var>().getScore(); // !!! Переделать!!!
        
        if (LvlSettings.GetComponent<LvlSettings>().getScore() == score)
        {
            LvlSettings.GetComponent<LvlSettings>().setScore(score);
        }
    }

}
