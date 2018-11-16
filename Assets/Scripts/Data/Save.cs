
using UnityEngine;

public class Save{

    private int[] progress = new int[2];

    public void saveLvls()
    {
        for (int i = 0; i < progress.Length; i++)
        {
            PlayerPrefs.GetInt("lvl" + (i + 1), progress[i]);
        }
    }
}
