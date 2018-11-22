using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepPoint : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
        collision.GetComponent<Animator>().SetTrigger("Point");

    }
}
