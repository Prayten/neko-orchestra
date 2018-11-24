using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSpawnController : MonoBehaviour {

<<<<<<< HEAD
    public GameObject globalvar;
  
    [HideInInspector]
=======
>>>>>>> nikif
    public GameObject[] cats = new GameObject[5];

	void Start () {
        GameObject cat = Instantiate(cats[Random.Range(0, cats.Length)], transform);
        cat.transform.parent = null;
<<<<<<< HEAD
        cat.GetComponent<controler>().globar_var = globalvar;
=======
        cat.AddComponent<MoreSleep>();
>>>>>>> nikif
        cat.GetComponent<Rigidbody2D>().AddForce(new Vector2(80,0));
	}
	
}
