using UnityEngine;

public class Load {

    private int[] progress = new int[2];

    public void loadLvls()
    {
        for(int i = 0; i < progress.Length; i++)
        {
            PlayerPrefs.GetInt("lvl" + (i+1), progress[i]);
        }
    }
	
}
