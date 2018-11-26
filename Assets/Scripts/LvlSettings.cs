using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LvlSettings : MonoBehaviour {

    public global_var global_score;
    private int score;
    private int stars;
    private bool end;
    

    public Data data;
    public GameObject Victory;

    //Условия уровня, которые можно выставить в меню Unity
    [SerializeField]
    private float timer;
    [SerializeField]
    private int neededScore;

    private void Start()
    {
        
    }

    private void Update()
    {
        //setScore(global_score.score);
        //Проверяет, выполнено ли условие уровня
        if(neededScore == score && !end)
        {
            Debug.Log("Условие уровня выполнено");
            data.setLvlData(data.getNumLvl(),score,stars,true);
            end = true;
            Time.timeScale = 0;
            Victory.SetActive(true);

        }
    }

    //Выдает время , отведенное на уровень
    public float getTimer()
    {
        return timer;
    }
    
    public void setScore(int scorePlus)
    {
        score = scorePlus;
    }

    //Выдает очки, необходимые для окончания уровня
    public int getScore()
    {
        return neededScore;
    }
}
