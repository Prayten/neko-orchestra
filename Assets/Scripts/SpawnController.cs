using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject Spawn;
    public GameObject[] cats = new GameObject[5];
    
    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount % 75 == 0 && Time.timeScale > 0){
            GameObject cat = Instantiate(cats[Random.Range(0,cats.Length)], Spawn.transform);
            cat.transform.parent = null;
            cat.GetComponent<Controler>().curentspawn = "more";
            cat.GetComponent<Rigidbody2D>().AddForce(new Vector2(80, 0));   
        }
    }
}
