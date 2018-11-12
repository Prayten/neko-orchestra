using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour {


    public Button pause;

    void Start()
    {
        Button btn1 = pause.GetComponent<Button>();
        btn1.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        OnClick();
    }

    void OnClick()
    {
        print("Quiting...");
        Time.timeScale = 0; 
    }
}
