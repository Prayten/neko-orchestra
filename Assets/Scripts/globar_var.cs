using UnityEngine;
using UnityEngine.UI;


public class globar_var : MonoBehaviour
{
    [HideInInspector]
    public int score;
    [HideInInspector]
    public int cat_counter;

    public LvlSettings lvlSettings;
    public Text text;

    

    private void Update()
    {
        text.text = "Score: " + score.ToString();
        lvlSettings.GetComponent<LvlSettings>().setScore(score);
        Debug.Log("Cat Counter = " + cat_counter);
    }

}