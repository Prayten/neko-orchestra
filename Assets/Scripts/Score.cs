using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public GameObject global_var;
	// Use this for initialization
	void Start () {
        global_var.GetComponent<Global_var>().score = 0;

    }
	
	// Update is called once per frame
	void Update () {
        GetComponent<Text>().text = "score " + global_var.GetComponent<Global_var>().score;
    }
}
