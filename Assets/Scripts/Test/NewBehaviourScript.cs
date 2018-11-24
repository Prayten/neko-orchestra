using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    private GetSet GS;
	void Start () {
        GS = new GetSet();
        Get();
        Set();
	}
	
	void Get()
    {
        Debug.Log("Свойство Get: " + GS.count);
    }

    void Set()
    {
        GS.count = 100;
        Debug.Log("Свойство Set: " + GS.count);
    }
}
