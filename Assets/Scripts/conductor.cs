using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conductor : MonoBehaviour {

    public globar_var cat_counter;
    private int counter;
    private void Update()
    {
        counter = cat_counter.GetComponent<globar_var>().cat_counter;
        this.GetComponent<Animator>().SetInteger("cat", counter);
    }

}
