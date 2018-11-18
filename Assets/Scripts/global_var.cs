using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class global_var : MonoBehaviour {

    public int cat_counter;
    public Slider slider_counter;
    public Text scoretext;
    public int score;

    // Use this for initialization
    void Start () {
        cat_counter = 0;
        score = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (score < 0)
        {
            score = 0;
        }
        scoretext.text = "Score " + score;
        slider_counter.value = score;
    }
}
