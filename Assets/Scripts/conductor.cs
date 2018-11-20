using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conductor : MonoBehaviour {
    public Animator anim;
    
    private int counter;

    private void Update()
    {
        anim.SetInteger("cat", counter);
    }

}
