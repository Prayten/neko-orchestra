using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSpawnController : MonoBehaviour {

    public GameObject simpleSpawn;
    public GameObject[] cats = new GameObject[5];
    
	void Start () {
        GameObject cat = Instantiate(cats[Random.Range(0, cats.Length)], simpleSpawn.transform);
        cat.transform.parent = null;
        cat.GetComponent<Controler>().curentspawn = "simple";
        cat.GetComponent<Rigidbody2D>().AddForce(new Vector2(80,0));
	}
	
}
