using System;

[Serializable]
public class LvlCollection{
    //Массив данных уровней
    public LvlData[] lvls;
    //Имя коллекции, к которой принадлежат уровни
    public string collectionName;
    //Переопределение стандартной функции
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
