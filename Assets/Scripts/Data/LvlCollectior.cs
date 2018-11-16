using System;

[Serializable]
public class LvlCollectior{

    public LvlData[] lvlDatas;

    public string collectionName;

    public override string ToString()
    {
        string result = "Lvl Data\n";
        for (int i = 0; i < lvlDatas.Length; i++)
        {
            result += string.Format("{0} Progress: {1}", lvlDatas[i].lvlName, lvlDatas[i].progress);
        }
        return result;
    }
}
