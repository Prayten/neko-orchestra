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

    // Use this for initialization
    void Start()
    {
        Button unpause = unpauseMenu.GetComponent<Button>();
        unpause.onClick.AddListener(TaskOnClickUnpause);
        Button pause = pauseMenu.GetComponent<Button>();
        pause.onClick.AddListener(TaskOnClickPause);
        Button quit = quitMenu.GetComponent<Button>();
        quit.onClick.AddListener(TaskOnClickQuit);


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
        SceneManager.LoadScene("Menu");
    }

}