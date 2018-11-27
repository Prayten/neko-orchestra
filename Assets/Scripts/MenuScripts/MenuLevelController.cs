using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuLevelController : MonoBehaviour
{
    public Button menuLvl;
    public Data data;
    // Use this for initialization
    void Start()
    {
        #region AddListenerОбработчиковКнопок
        menuLvl.onClick.AddListener(TaskOnClickUnpause);
        menuLvl.onClick.AddListener(TaskOnClickPause);
        menuLvl.onClick.AddListener(TaskOnClickQuit);
        menuLvl.onClick.AddListener(TaskOnClickRestart);
        menuLvl.onClick.AddListener(TaskOnClickNextLvl);
        #endregion

    }
    #region ОбработчикиСобытийКнопокМеню
    public void TaskOnClickUnpause()
    {
        Debug.Log("You have clicked the button");
        OnClickUnpause();
    }

    public void TaskOnClickPause()
    {
        Debug.Log("You have clicked the button");
        OnClickPause();
    }

    public void TaskOnClickQuit()
    {
        Debug.Log("You have clicked the button");
        OnClickQuit();
    }

    public void TaskOnClickRestart()
    {
        Debug.Log("You have clicked the button");
        OnClickRestart();
    }

    public void TaskOnClickNextLvl()
    {
        Debug.Log("You have clicked the button");
        TaskOnClickNextLvl();
    }


    void OnClickNextLvl()
    {
        //Нужно понять, как получить имя следующего уровня
        Debug.Log("Loading Next Lvl...");
        SceneManager.LoadScene("lvl" + data.getNumLvl(), LoadSceneMode.Single);
    }

    void OnClickUnpause()
    {
        print("Continue...");
        Time.timeScale = 1;
    }

    void OnClickPause()
    {
        print("Pause...");
        Time.timeScale = 0;
    }

    void OnClickQuit()
    {
        print("Quiting...");
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        
    }

    void OnClickRestart()
    {
        Debug.Log("Restarting scene " + SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
    }
    #endregion
}