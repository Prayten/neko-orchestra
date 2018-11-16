using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Configure : MonoBehaviour {

    private Load load;
    private Save save;

	// Use this for initialization
	void Start () {
        load.loadLvls();
    }

    void OnApplicationQuit()
    {
        save.saveLvls();
    }
	
	
}
