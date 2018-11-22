using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCollision : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision Detected");
        if(collision.gameObject.tag == "Cherry")
        {
            Debug.Log("Cherry Detected");
            Destroy(collision.gameObject);
        }
    }
}
