﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controler : MonoBehaviour{
    public Animator animator;
    public bool cat_sleep;
    public bool losepoint;
    public bool addpoint;
    public bool inTeam;

    private float speed;
    private bool isFacingRight;
    private bool active;
    private bool random;

    private void Start()
    {
        speed = 80;
        cat_sleep = false;
        isFacingRight = true;
    }
    //updete per frame
    void Update(){
        addpoint = false;
        losepoint = false;
        if (Time.frameCount % 60 == 0 && !cat_sleep && !random){
            if (Random.Range(1, 11) == 1) {
                animator.SetTrigger("sleep");
                cat_sleep = true;
            }
        }
        if (active)
        {
            cat_sleep = false;
            Destroy(gameObject);
        }
    }

    //check
    void OnMouseDown(){
        if (cat_sleep){
            animator.SetTrigger("poof");
            animator.SetTrigger("timer");
            cat_sleep = false;
            addpoint = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("ran"))
        {
            random = true;
        }

        if (collision.gameObject.CompareTag("dead"))
        {
            if (cat_sleep)
            {
                cat_sleep = false;
                losepoint = true;
            }
            active = true;
        }

        if (collision.gameObject.CompareTag("Fliper")){ 
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
        this.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed * f, 0));
    }
}