using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFire : MonoBehaviour {

    public GameObject fire;

    private int minspeedX = 50;
    private int maxspeedX = 50;
    private int minspeedY = 300;
    private int maxspeedY = 300;

    // Update is called once per frame
    void Update () {
		if(Time.frameCount % 60 == 0 && Random.Range(0, 3) == 1 && Time.timeScale > 0)
        {
            GameObject gfire = Instantiate(fire, gameObject.transform);
            gfire.transform.parent = null;
            if (gameObject.transform.position.x < 0)
            {
                gfire.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(minspeedX, maxspeedX), Random.Range(minspeedY, maxspeedY)));
            }
            else
                gfire.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-minspeedX, -maxspeedX), Random.Range(minspeedY, maxspeedY)));
        }   
	}
}
