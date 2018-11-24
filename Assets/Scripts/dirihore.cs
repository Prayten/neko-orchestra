using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dirihore : MonoBehaviour {
    public GameObject o_globalvar;
    private void Update()
    {
        gameObject.GetComponent<Animator>().SetInteger("cat", o_globalvar.GetComponent<Global_var>().cat_counter);
}

}
