﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class global_var : MonoBehaviour{
    public GameObject[] cats = new GameObject[64];
    public int cat_counter;
    public int score;

    private bool[] one_time = new bool[64];

    // Use this for initialization
    void Start () {
        cat_counter = 0;
        score = 0;
    }
	
	// Update is called once per frame
	void Update () {  
        for (int i = 0; i < cats.Length; i++){
            if (cats[i] != null){
                //checking lezy cat 
                if (cats[i].GetComponent<controler>().cat_sleep && !one_time[i]){
                    cat_counter += 1;
                    one_time[i] = true;
                }
                if (!cats[i].GetComponent<controler>().cat_sleep && one_time[i]){
                    cat_counter -= 1;
                    one_time[i] = false;
                }
                if (cats[i].GetComponent<controler>().addpoint)
                {
                    score += 1;
                }
                if (cats[i].GetComponent<controler>().losepoint)
                {
                    score -= 2;
                }
            }
        }
    }
}
