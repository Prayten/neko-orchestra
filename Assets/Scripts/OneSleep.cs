using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneSleep : MonoBehaviour {

    void Start() {
        if (Random.Range(1, 11) == 1)
        {
            GetComponent<Animator>().SetTrigger("sleep");
            GetComponent<Controler>().cat_sleep = true;
            GetComponent<Controler>().globalvar.GetComponent<global_var>().cat_counter += 1;
        }
    }
}
