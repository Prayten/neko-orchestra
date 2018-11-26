using UnityEngine;

//Скрипт для главного меню, чтобы отображать кнопки загрузки доступных уровней

public class ProgressLvl : MonoBehaviour {

    
    public GameObject[] BLoadLvl;
    public Data data;

    private LvlCollection lvlCollection;
	// Use this for initialization
	private void Start () {

        lvlCollection = data.getLvlCollection();
        for(int i = 1; i <= lvlCollection.lvls.Length - 1; i++)
        {
            // Проверяем, какие уровни пройдены, включаем нужные кнопки загрузки уровней
            if(lvlCollection.lvls[i].progress)
            {
                BLoadLvl[i].SetActive(true);
            }
        }
	}  
}
