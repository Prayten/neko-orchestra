using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneSleep : MonoBehaviour {

    void Start() {
        if (Random.Range(1, 6) == 1)
        {
            GetComponent<Animator>().SetTrigger("sleep");
            GetComponent<CatController>().cat_sleep = true;
            GetComponent<CatController>().globalvar.GetComponent<global_var>().cat_counter += 1;
        }
    }
}
