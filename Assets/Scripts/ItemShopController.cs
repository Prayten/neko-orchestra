using UnityEngine.UI;
using UnityEngine;
using System.IO;

public class ItemShopController : MonoBehaviour {

    public Data data;
    [SerializeField]
    private Button BShopController;
	// Use this for initialization
	void Start () {
        BShopController.onClick.AddListener(TaskOnClickBuy1);
        BShopController.onClick.AddListener(TaskOnClickBuy2);
        BShopController.onClick.AddListener(TaskOnClickBuy3);
        BShopController.onClick.AddListener(TaskOnClickBuy4);
        BShopController.onClick.AddListener(TaskOnClickBuy5);
        BShopController.onClick.AddListener(TaskOnClickBuy6);
        BShopController.onClick.AddListener(TaskOnClickBuy7);

    }

    void TaskOnClickBuy1()
    {
        
    }

    void TaskOnClickBuy2()
    {

    }
    void TaskOnClickBuy3()
    {

    }

    void TaskOnClickBuy4()
    {

    }

    void TaskOnClickBuy5()
    {

    }

    void TaskOnClickBuy6()
    {

    }

    void TaskOnClickBuy7()
    {

    }
}
