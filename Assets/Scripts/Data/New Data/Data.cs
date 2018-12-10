using UnityEngine;

public class Data : MonoBehaviour {

    private ItemCollection itemCollection;
    private LvlCollection lvlCollection;
    private FoodCollection foodCollection;

    private FoodData foodD;
    private ShopData shopD;
    private SettingsData settingsD;
    private ProgressData progressD;
    private LvlData lvlD;
    private int numLvl;

    

    private void Start()
    {
        foodD = new FoodData();
        lvlD = new LvlData();
        shopD = new ShopData();
        settingsD = new SettingsData();
        progressD = new ProgressData();
        LoadLvl();
        LoadShop();
        LoadFood();
        Debug.Log("Data Start");
    }

    private void LoadFood()
    {
        foodCollection = foodD.LoadfoodData();
        Debug.Log(foodCollection.ToString());
    }

    private void LoadLvl()
    {
        lvlCollection = lvlD.LoadLvlData();
        Debug.Log(lvlCollection.ToString());
    }
  

    private void LoadShop()
    {
        itemCollection = shopD.LoadShopData();
        Debug.Log(itemCollection.ToString());
    }

    private void SaveData()
    {
        foodD.SavefoodData(foodCollection);
        lvlD.SaveLvlData(lvlCollection);
        shopD.SaveShopData(itemCollection);
        settingsD.SaveSettingsData();
        progressD.SaveProgressData();
        PlayerPrefs.Save();
    }

    private void OnApplicationQuit()
    {
        SaveData();   
    }
    #region ДатьВзять
    public float musicVolume
    {
        get { return settingsD.musicVolume; }
        set { settingsD.musicVolume = value; }
    }

    public float gameVolume
    {
        get { return settingsD.gameVolume; }
        set { settingsD.gameVolume = value; }
    }

    public void setLvlProgress(int num)
    {
        progressD.lvlProgress[num] = 1;
    }

    public int getLvlProgress(int num)
    {
        return progressD.lvlProgress[num];
    }

    public int Money
    {
        get { return progressD.money; }
        set { progressD.money = value; }
    }

    public int Rage
    {
        get { return progressD.rage; }
        set { progressD.rage = value; }
    }

    public Item getItem(int num)
    {
        return itemCollection.items[num];
    }

    public ItemCollection GetItemCollection()
    {
        return itemCollection;
    }

    public void setItemSaled(int num)
    {
        itemCollection.items[num].saled = true;
    }

    public Lvl getLvlData()
    {
        return lvlCollection.lvls[numLvl];
    }

    public void setLvlData(int numLvl, int points, int stars, bool progress)
    {
        lvlCollection.lvls[numLvl-1].points = points;
        lvlCollection.lvls[numLvl-1].stars = stars;
        lvlCollection.lvls[numLvl-1].progress = progress;
    }

    public void setNumLvl(int numLvl)
    {
        this.numLvl = numLvl;
    }

    public int getNumLvl()
    {
        return numLvl;
    }

    public LvlCollection getLvlCollection()
    {
        return lvlCollection;
    }

    #endregion
}
