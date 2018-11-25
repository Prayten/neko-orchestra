using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conductor : MonoBehaviour {

    public global_var cat_counter;
    private int counter;
    private void Update()
    {
        //counter = cat_counter.GetComponent<global_var>().cat_counter;
        GetComponent<Animator>().SetInteger("cat", counter);
    }

}
