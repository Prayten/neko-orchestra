using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointcon : MonoBehaviour {

    public Text text;
    public int score = 0;
	// Use this for initialization
	void Start () {
        print("Pointcon");
	}

    private void Update()
    {
        text.text = "Score: " + score;
    }

}
