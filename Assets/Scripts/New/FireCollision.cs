﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCollision : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Cherry")
        {
            
            Destroy(collision.gameObject);
        }
    }
}
