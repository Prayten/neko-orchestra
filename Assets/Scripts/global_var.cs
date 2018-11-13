using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class global_var : MonoBehaviour{
    public GameObject[] cats = new GameObject[3];
    public int cat_counter;

    private bool[] one_time = new bool[3];

    // Use this for initialization
    void Start () {
        cat_counter = 0;
    }
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < cats.Length; i++){
            if (cats[i].GetComponent<controler>().cat_sleep && !one_time[i]){
                cat_counter += 1;
                one_time[i] = true; 
            }
            if (!cats[i].GetComponent<controler>().cat_sleep && one_time[i])
            {
                cat_counter -= 1;
                one_time[i] = false;
            }
        }
    }
}
