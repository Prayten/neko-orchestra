using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitController : MonoBehaviour {

    public Button exit;

    void Start()
    {
        Button btn1 = exit.GetComponent<Button>();
        btn1.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        //Output this to console when the Button is clicked
        Debug.Log("You have clicked the button!");
        OnClick();
    }

    void OnClick()
    {
        print("Quiting...");
        //Output this to console when the Button is clicked
        Application.Quit();
    }
}
