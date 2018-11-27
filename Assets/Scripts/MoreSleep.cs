using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreSleep : MonoBehaviour {

	void Update () {
        if (Time.frameCount % 60 == 0 && !GetComponent<CatController>().cat_sleep){
            if (Random.Range(1, 11) == 1){
                GetComponent<Animator>().SetTrigger("sleep");
                GetComponent<CatController>().cat_sleep = true;
                GetComponent<CatController>().globalvar.GetComponent<global_var>().cat_counter += 1;
            }
        }
    }
}
