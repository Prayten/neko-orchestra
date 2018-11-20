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

    private void Start()
    {
        score = 0;
        cat_counter = 0;
    }

    private void Update()
    {
        text.text = "Score: " + score.ToString();
        lvlSettings.GetComponent<LvlSettings>().setScore(score);
    }

}