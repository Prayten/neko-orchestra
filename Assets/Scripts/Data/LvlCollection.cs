using System;

[Serializable]
public class LvlCollection{

    public LvlData[] lvls;

    public string collectionName;

    public override string ToString()
    {
        string result = "Lvl Data\n";
        foreach(var lvl in lvls)
        { 
            result += string.Format("{0} Progress: {1}", lvl.numLvl, lvl.progress);
        }
        return result;
    }
}
