using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuLevelController : MonoBehaviour
{



    public Button unpauseMenu;
    public Button quitMenu;
    public Button pauseMenu;
    public Button restartMenu;

    // Use this for initialization
    void Start()
    {
        Button unpause = unpauseMenu.GetComponent<Button>();
        unpause.onClick.AddListener(TaskOnClickUnpause);
        Button pause = pauseMenu.GetComponent<Button>();
        pause.onClick.AddListener(TaskOnClickPause);
        Button quit = quitMenu.GetComponent<Button>();
        quit.onClick.AddListener(TaskOnClickQuit);
        Button restart = restartMenu.GetComponent<Button>();
        restart.onClick.AddListener(TaskOnClickRestart);


    }

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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
        Time.timeScale = 1;
    }

}