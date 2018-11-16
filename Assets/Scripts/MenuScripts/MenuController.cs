using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    public int count = 0;
    
    public Button startMenu;
    public Button exitMenu;
    public Button achievementsMenu;
    public Button loadlvlMenu;
    public Button loadlvl1Menu;
    public Button loadlvl2Menu;
    public Button loadlvl3Menu;
    public Button loadextralvlMenu;

    // Use this for initialization
    void Start () {

        //Main Menu buttons
        Button start = startMenu.GetComponent<Button>();
        start.onClick.AddListener(TaskOnClickStart);
        Button exit = exitMenu.GetComponent<Button>();
        exit.onClick.AddListener(TaskOnClickExit);
        Button achievements = achievementsMenu.GetComponent<Button>();
        achievements.onClick.AddListener(TaskOnClickAchieveMenu);
        Button loadlvl = loadlvlMenu.GetComponent<Button>();
        loadlvl.onClick.AddListener(TaskOnClickLoadLvlMenu);

        Button loadlvl1 = loadlvl1Menu.GetComponent<Button>();
        loadlvl1.onClick.AddListener(TaskOnClickLoadLvl1);
        Button loadlvl2 = loadlvl2Menu.GetComponent<Button>();
        loadlvl2.onClick.AddListener(TaskOnClickLoadLvl2);
        Button loadlvl3 = loadlvl3Menu.GetComponent<Button>();
        loadlvl3.onClick.AddListener(TaskOnClickLoadLvl3);
        Button loadextralvl = loadextralvlMenu.GetComponent<Button>();
        loadextralvl.onClick.AddListener(TaskOnClickLoadExtraLvl);
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
