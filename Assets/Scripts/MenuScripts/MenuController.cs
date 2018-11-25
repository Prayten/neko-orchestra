using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    


    public Button menu;

    // Use this for initialization
    void Start() {

        #region AddListenerДлякнопокзагрузки
        menu.onClick.AddListener(TaskOnClickStart);
        menu.onClick.AddListener(TaskOnClickExit);
        menu.onClick.AddListener(TaskOnClickLoadLvl1);
        menu.onClick.AddListener(TaskOnClickLoadLvl2);
        /*menu.onClick.AddListener(TaskOnClickLoadLvl3);
        menu.onClick.AddListener(TaskOnClickLoadLvl4);
        menu.onClick.AddListener(TaskOnClickLoadLvl5);
        menu.onClick.AddListener(TaskOnClickLoadLvl6);
        menu.onClick.AddListener(TaskOnClickLoadLvl7);
        menu.onClick.AddListener(TaskOnClickLoadLvl8);
        menu.onClick.AddListener(TaskOnClickLoadLvl9);
        menu.onClick.AddListener(TaskOnClickLoadLvl10);
        menu.onClick.AddListener(TaskOnClickLoadExtraLvl);*/
        #endregion

    
    }

    

    public void TaskOnClickStart()
    {
        Debug.Log("Button Start clicked");
        Debug.Log("Loading lvl1...");
        OnClickLoadLvl("lvl1");
        
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

    #region ОбработчикиСобытийДляКнопокЗагрузки
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

        public void TaskOnClickLoadLvl4()
        {
            OnClickLoadLvl("lvl4");
        }

        public void TaskOnClickLoadLvl5()
        {
            OnClickLoadLvl("lvl5");
        }

        public void TaskOnClickLoadLvl6()
        {
            OnClickLoadLvl("lvl6");
        }

        public void TaskOnClickLoadLvl7()
        {
            OnClickLoadLvl("lvl7");
        }

        public void TaskOnClickLoadLvl8()
        {
            OnClickLoadLvl("lvl8");
        }

        public void TaskOnClickLoadLvl9()
        {
            OnClickLoadLvl("lvl9");
        }

        public void TaskOnClickLoadLvl10()
        {
            OnClickLoadLvl("lvl10");
        }
    #endregion

    public void TaskOnClickLoadExtraLvl()
    {
        OnClickLoadLvl("extralvl");
    }
}
