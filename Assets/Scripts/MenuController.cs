using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {


    public Button startMenu;
    public Button exitMenu;
	// Use this for initialization
	void Start () {
        Button start = startMenu.GetComponent<Button>();
        start.onClick.AddListener(TaskOnClickStart);
        Button exit = exitMenu.GetComponent<Button>();
        exit.onClick.AddListener(TaskOnClickExit);
	}
	
    public void TaskOnClickStart()
    {
        Debug.Log("Button Start clicked");
        OnClickStart();
    }

    public void TaskOnClickExit()
    {
        Debug.Log("Button Exit clicked");
        OnclickExit();
    }

    void OnClickStart()
    {
        Debug.Log("Loading SampleScene...");
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

    void OnclickExit()
    {
        Debug.Log("Application Quit");
        Application.Quit();
    }
}
