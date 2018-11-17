using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    public int count = 0;
    
    private Button startMenu;

    // Use this for initialization
    void Start () {

        //Main Menu buttons
        startMenu.onClick.AddListener(TaskOnClickStart);
        startMenu.onClick.AddListener(TaskOnClickExit);
        startMenu.onClick.AddListener(TaskOnClickAchieveMenu);
        startMenu.onClick.AddListener(TaskOnClickLoadLvlMenu);

        startMenu.onClick.AddListener(TaskOnClickLoadLvl1);
        startMenu.onClick.AddListener(TaskOnClickLoadLvl2);
        startMenu.onClick.AddListener(TaskOnClickLoadLvl3);
        startMenu.onClick.AddListener(TaskOnClickLoadExtraLvl);
    }
	
    public void TaskOnClickStart()
    {
        Debug.Log("Button Start clicked");
        Debug.Log("Loading lvl1...");
        SceneManager.LoadScene("lvl1", LoadSceneMode.Single);
        count += 1;
    }

    public void TaskOnClickExit()
    {
        Debug.Log("Button Exit clicked");
        Debug.Log("Application Quit");
        Application.Quit();
    }

    void OnClickLoadLvl(string scene)
    {
        Debug.Log("Loading " + scene + "...");
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }

    

    public void TaskOnClickAchieveMenu()
    {

    }

    public void TaskOnClickLoadLvlMenu()
    {

    }

    public void TaskOnClickLoadLvl1()
    {
        OnClickLoadLvl("lvl1");
    }

    public void TaskOnClickLoadLvl2()
    {
        OnClickLoadLvl("lvl2");
    }

    public void TaskOnClickLoadLvl3()
    {
        OnClickLoadLvl("lvl3");
    }

    public void TaskOnClickLoadExtraLvl()
    {
        OnClickLoadLvl("extralvl");
    }

}
