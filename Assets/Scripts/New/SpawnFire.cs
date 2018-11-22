using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFire : MonoBehaviour {

    public GameObject fire;
    public GameObject spawnFire;
	
	
	
	// Update is called once per frame
	void Update () {
		if(Time.frameCount % 60 == 0)
        {
            GameObject gfire = Instantiate(fire, spawnFire.transform);
            gfire.transform.parent = null;
            gfire.GetComponent<Rigidbody2D>().AddForce(new Vector2(150, 150));
        }
	}
}
