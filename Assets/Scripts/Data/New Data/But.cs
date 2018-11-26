using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class But : MonoBehaviour {


    public Data data;

    void Update()
    {
        GetComponent<Button>().onClick.AddListener(Click);
    }

    void Click()
    {
        Debug.Log("Clicked");
        
    }
}
