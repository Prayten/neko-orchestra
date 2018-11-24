using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSpawnController : MonoBehaviour {

    public GameObject globalvar;
  
    [HideInInspector]
    public GameObject[] cats = new GameObject[5];

    private bool set = false;
	void Start () {
        GameObject cat = Instantiate(cats[Random.Range(0, cats.Length)], transform);
        cat.transform.parent = null;
        cat.GetComponent<controler>().globar_var = globalvar;
        cat.GetComponent<Rigidbody2D>().AddForce(new Vector2(80,0));
	}
	
}
