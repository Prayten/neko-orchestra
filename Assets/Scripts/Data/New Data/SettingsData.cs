using UnityEngine;

public class SettingsData
{

    public float musicVolume;
    public float gameVolume;

    public SettingsData()
    {
        Debug.Log("Constructor SettingsData");
        musicVolume = PlayerPrefs.GetFloat("MusicVolume");
        
        gameVolume = PlayerPrefs.GetFloat("GameVolume");
        Debug.Log("GameVolume = " + gameVolume);
    }

    public void SaveSettingsData()
    {
        PlayerPrefs.SetFloat("MusicVolume", musicVolume);
        PlayerPrefs.SetFloat("GameVolume", gameVolume);
    }

}
