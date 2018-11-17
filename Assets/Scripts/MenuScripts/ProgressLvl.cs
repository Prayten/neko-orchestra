using UnityEngine;
using UnityEngine.UI;

public class ProgressLvl : MonoBehaviour {

    
    private LvlCollection lvlCollection;
    private LoadLvlData LLD;

    public GameObject[] BLoadLvl;
    
	// Use this for initialization
	private void Start () {
        LLD = new LoadLvlData();
        lvlCollection = LLD.getLoad();   //Получаем данные об уровнях
        for(int i = 1; i < lvlCollection.lvls.Length; i++)
        {
            // Проверяем, какие уровни пройдены, включаем нужные кнопки загрузки уровней
            if(lvlCollection.lvls[i].progress)
            {
                BLoadLvl[i].SetActive(true);
            }
        }
	}  
}
