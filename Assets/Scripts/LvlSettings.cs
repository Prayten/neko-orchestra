using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LvlSettings : MonoBehaviour {

    private int score;
    private ProgressSave PS;

    [SerializeField]
    private float timer;
    [SerializeField]
    private int neededScore;

    private void Start()
    {
        PS = new ProgressSave();
    }

    private void Update()
    {

        if(neededScore == score)
        {
            PS.setComplete();
        }
    }

    public float getTimer()
    {
        return timer;
    }

    public void setScore(int scorePlus)
    {
        score = scorePlus;
    }
}
