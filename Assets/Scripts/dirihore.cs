using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dirihore : MonoBehaviour {
    public GameObject o_globalvar;
    public Animator anim;

    private void Update()
    {
        anim.SetInteger("cat", o_globalvar.GetComponent<global_var>().cat_counter);
}

}
