using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quit : MonoBehaviour {

    //Make sure to attach these Buttons in the Inspector
    public Button exit;

    void Start()
    {
        Button btn1 = exit.GetComponent<Button>();
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
        Application.Quit();
    }
}
