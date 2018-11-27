﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CatController : MonoBehaviour
{

    public global_var globalvar;
    public bool inTeam;
    public bool cat_sleep;
    public bool spawned;

    private float speed;
    private bool isFacingRight;

    private void Start()
    {
        speed = 80;
        cat_sleep = false;
        isFacingRight = true;
    }


    //check
    void OnMouseDown()
    {
        if (cat_sleep && Time.timeScale > 0)
        {
            GetComponent<Animator>().SetTrigger("poof");
            cat_sleep = false;
            globalvar.GetComponent<global_var>().cat_counter -= 1;
            globalvar.GetComponent<global_var>().score += 1;

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("dead"))
        {
            if (cat_sleep)
            {

                cat_sleep = false;


                globalvar.GetComponent<global_var>().cat_counter -= 1;
                globalvar.GetComponent<global_var>().score -= 1;

            }
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Fliper"))
        {
            if (isFacingRight)
            {
                Flip(-2);
            }
            else
            {
                Flip(2);
            }
        }
    }

    private void Flip(int f)
    {
        isFacingRight = !isFacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
        GetComponent<Rigidbody2D>().AddForce(new Vector2(speed * f, 0));
    }
}