using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour{

    public GameObject[] cats = new GameObject[5];
    
    void Update(){
        if (Time.frameCount % 75 == 0 && Time.timeScale > 0){
            GameObject cat = Instantiate(cats[Random.Range(0,cats.Length)], transform);
            cat.transform.parent = null;
            cat.AddComponent<OneSleep>();
            cat.GetComponent<Rigidbody2D>().AddForce(new Vector2(80, 0));   
        }
    }
}
