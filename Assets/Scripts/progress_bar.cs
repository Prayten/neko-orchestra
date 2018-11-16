using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class progress_bar : MonoBehaviour {
    public GameObject global_var;
    public Slider proggress;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (global_var.GetComponent<global_var>().cat_counter == 0)
        {
            if (Time.frameCount % 30 == 0)
            {
                proggress.value += 1;
            }
        }
        if (global_var.GetComponent<global_var>().cat_counter == 1)
        {
            if (Time.frameCount % 60 == 0)
            {
                proggress.value += 1;
            }
        }
        if (global_var.GetComponent<global_var>().cat_counter == 2)
        {
            if (Time.frameCount % 90 == 0)
            {
                proggress.value += 1;
            }
        }
    }
}
