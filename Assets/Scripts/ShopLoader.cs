using UnityEngine.UI;
using UnityEngine;

public class ShopLoader : MonoBehaviour {

    private ItemCollection itemCollection;
    private FoodCollection foodCollection;

    public GameObject Items;
    public Data data;
	// Use this for initialization
	void Start () {
        itemCollection = data.GetItemCollection();
        SetItems();
        Debug.Log(itemCollection.ToString());
	}
	
	void SetItems()
    {
        for (int i = 0; i < Items.transform.childCount - 1; i++)
        {
            Items.transform.GetChild(i).transform.GetChild(0).GetComponent<Text>().text = itemCollection.items[i].name;
            Items.transform.GetChild(i).transform.GetChild(3).GetChild(0).GetComponent<Text>().text = itemCollection.items[i].cost.ToString();
        }
    }

}
