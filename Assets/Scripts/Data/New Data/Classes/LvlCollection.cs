using System;

[Serializable]
public class LvlCollection{
    //Массив данных уровней
    public Lvl[] lvls;
    //Имя коллекции, к которой принадлежат уровни
    public string collectionName;
    //Переопределение стандартной функции
    public override string ToString()
    {
        string result = "Lvl Data\n";
        foreach(var lvl in lvls)
        { 
            result += string.Format("{0}\n Progress: {1}\n,Points: {2}\nStars: {3}\n", lvl.numLvl, lvl.progress, lvl.points, lvl.stars);
        }
        return result;
    }
}
