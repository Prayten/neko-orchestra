using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreSleep : MonoBehaviour {

	void Update () {
        if (Time.frameCount % 60 == 0 && !GetComponent<Controler>().cat_sleep){
            if (Random.Range(1, 11) == 1){
                GetComponent<Animator>().SetTrigger("sleep");
                GetComponent<Controler>().cat_sleep = true;
                GetComponent<Controler>().global_var.GetComponent<Global_var>().cat_counter += 1;
            }
        }
    }
}
