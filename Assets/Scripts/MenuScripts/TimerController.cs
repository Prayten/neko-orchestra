using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{

    public GameObject gameOver;
    public Text timerLabel;
    public GameObject lvlSettings;

    private float lvlTime;

    private void Start()
    {
        lvlTime = lvlSettings.GetComponent<LvlSettings>().getTimer();
    }

    void Update()
    {
        if(lvlTime <= 0)
        {
            Time.timeScale = 0;
            gameOver.SetActive(true);
        }
        lvlTime -= Time.deltaTime;

        var minutes = lvlTime / 60; //Divide the guiTime by sixty to get the minutes.
        var seconds = lvlTime % 60;//Use the euclidean division for the seconds.
        var fraction = (lvlTime * 100) % 100;

        //update the label value
        timerLabel.text = string.Format("{0:00} : {1:00} : {2:000}", minutes, seconds, fraction);
    }
}