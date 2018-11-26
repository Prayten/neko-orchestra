using UnityEngine;

public class ProgressData
{
    static public int lvlCount;
    public int money;
    public int[] lvlProgress = new int[lvlCount];
    

    public void LoadProgressData()
    {
        money = PlayerPrefs.GetInt("Money");
        for (int i = 0; i < lvlCount; i++)
        {
            lvlProgress[i] = PlayerPrefs.GetInt("Lvl" + (i+1));
        }
    }

    public void SaveProgressData()
    {
        PlayerPrefs.SetInt("Money",money);
        for (int i = 0; i < lvlCount; i++)
        {
            PlayerPrefs.SetInt("Lvl" + (i + 1), lvlProgress[i]);
        }
    }
}
