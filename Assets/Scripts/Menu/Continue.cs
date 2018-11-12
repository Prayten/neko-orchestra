using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Continue : MonoBehaviour {

    public Button continu;

    void Start()
    {
        Button btn1 = continu.GetComponent<Button>();
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
        Time.timeScale = 1;
    }
}
