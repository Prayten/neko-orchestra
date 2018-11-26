using UnityEngine;

public class Data : MonoBehaviour {

    private ShopData shopD;
    private SettingsData settingsD;
    private ProgressData progressD;

    

    private void Start()
    {
        shopD = new ShopData();
        settingsD = new SettingsData();
        progressD = new ProgressData();
        Debug.Log("Data Start");
        
        
       
    }

    private void SaveData()
    {
        shopD.SaveShopData();
        settingsD.SaveSettingsData();
        progressD.SaveProgressData();
        PlayerPrefs.Save();
    }

    private void OnApplicationQuit()
    {
        SaveData();   
    }

    public float musicVolume
    {
        get { return settingsD.musicVolume; }
        set { settingsD.musicVolume = value; }
    }

    public void gameVolume(float value)
    {
        Debug.Log("GameVolume = " + settingsD.gameVolume);
        Debug.Log("Value = " + value);
        
        settingsD.gameVolume = value;
        Debug.Log("After= GameVolume = " + settingsD.gameVolume);
    }

    public float getVolume()
    {
        return settingsD.gameVolume;
    }

}
