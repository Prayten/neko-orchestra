using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSpawnController : MonoBehaviour {

    public GameObject globalvar;
    public GameObject simpleSpawn;
    public GameObject[] cats = new GameObject[5];

    private bool set = false;
	void Start () {
        GameObject cat = Instantiate(cats[Random.Range(0, cats.Length)], simpleSpawn.transform);
        cat.transform.parent = null;
        for (int i = 0; i < globalvar.GetComponent<global_var>().cats.Length; i++) {
            if (globalvar.GetComponent<global_var>().cats[i] == null && !set) {
                globalvar.GetComponent<global_var>().cats[i] = cat;
                set = true;
            }
        }
        cat.GetComponent<Rigidbody2D>().AddForce(new Vector2(80,0));
	}
	
}
