
using UnityEngine;

public class Save{

    private Load load;

    private int[] progress = new int[2];

    public void saveLvls()
    {
        progress = load.getProgressSave();
        for (int i = 0; i < progress.Length; i++)
        {
            PlayerPrefs.SetInt("lvl" + (i + 1), progress[i]);
        }
    }
        
    public void setProgressComplete(int lvl)
    {
        progress[lvl - 1] = 1;
    }

}
