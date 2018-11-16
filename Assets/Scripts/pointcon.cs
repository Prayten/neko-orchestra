using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointcon : MonoBehaviour {

    public GameObject global_var;
    public Text text;
    public Slider slider_counter; 

    private void Update()
    {
        text.text = "Score: " + global_var.GetComponent<global_var>().score;
        slider_counter.value = global_var.GetComponent<global_var>().score;
    }

}
