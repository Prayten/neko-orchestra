using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class SpawnController : MonoBehaviour
{
    public GameObject globalvar;
    
    [HideInInspector]
    public GameObject[] cats = new GameObject[5];

    private int cat_counter;
    private bool set;
    
    // Update is called once per frame
    void Update()
    {
            globalvar.GetComponent<globar_var>().cat_counter += cat_counter;
            if (Time.frameCount % 60 == 0){

            GameObject cat = Instantiate(cats[Random.Range(0,cats.Length)], transform);
            cat.GetComponent<controler>().globar_var = globalvar;
            cat.GetComponent<Rigidbody2D>().AddForce(new Vector2(80, 0));
            
        } else
        {
            set = false;
=======
public class SpawnController : MonoBehaviour{

    public GameObject[] cats = new GameObject[5];
    
    void Update(){
        if (Time.frameCount % 75 == 0 && Time.timeScale > 0){
            GameObject cat = Instantiate(cats[Random.Range(0,cats.Length)], transform);
            cat.transform.parent = null;
            cat.AddComponent<OneSleep>();
            cat.GetComponent<Rigidbody2D>().AddForce(new Vector2(80, 0));   
>>>>>>> nikif
        }
    }
}
