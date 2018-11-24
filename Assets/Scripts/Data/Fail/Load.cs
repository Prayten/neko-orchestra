using UnityEngine;

public class Load {

    private int[] progress = new int[2];

    public int[] getProgressSave()
    {
        return progress;
    }

    public void loadLvls()
    {
        for(int i = 0; i < progress.Length; i++)
        {
            progress[i] = PlayerPrefs.GetInt("lvl" + (i+1));
        }
    }

    public int getProgress(int lvl)
    {
        return progress[lvl-1];
    }

}
