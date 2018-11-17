using UnityEngine;
using UnityEngine.UI;

public class ProgressLvl : MonoBehaviour {

    [SerializeField]
    private string lvlPath;

    private LoadLvlData LLD;
    public GameObject[] BLoadLvl;
    private LvlCollection lvlCollection;
	// Use this for initialization
	void Start () {
        LLD = new LoadLvlData();
        lvlCollection = LLD.getLoad(lvlPath);   //Получаем данные об уровнях
        for(int i = 1; i < lvlCollection.lvls.Length; i++)
        {
            // Проверяем, какие пройдены, включаем нужные кнопки загрузки уровней
            if(lvlCollection.lvls[i].progress)
            {
                BLoadLvl[i].SetActive(true);
            }
        }
	}

    


	
	
}
