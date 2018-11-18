using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controler : MonoBehaviour{

    public GameObject global_var;
    public Animator animator;
    public bool inTeam;
    public string curentspawn;

    private bool cat_sleep;
    private float speed;
    private bool isFacingRight;
    private bool one_time;

    private void Start()
    {
        speed = 80;
        cat_sleep = false;
        isFacingRight = true;
    }
    //updete per frame
    void Update(){
        if (curentspawn == "simple")
        {
            if (Time.frameCount % 60 == 0 && !cat_sleep)
            {
                if (Random.Range(1, 11) == 1)
                {
                    animator.SetTrigger("sleep");
                    cat_sleep = true;
                    global_var.GetComponent<global_var>().cat_counter += 1;
                }
            }
        }
        if (curentspawn == "more")
        {
            if (!one_time)
            {
                if (Random.Range(1, 11) == 1)
                {
                    animator.SetTrigger("sleep");
                    cat_sleep = true;
                    global_var.GetComponent<global_var>().cat_counter += 1;
                }
                one_time = true;
            }
        }
    }

    //check
    void OnMouseDown(){
        if (cat_sleep){
            animator.SetTrigger("poof");
            animator.SetTrigger("timer");
            cat_sleep = false;
            global_var.GetComponent<global_var>().cat_counter -= 1;
            global_var.GetComponent<global_var>().score += 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("dead"))
        {
            if (cat_sleep)
            {
                global_var.GetComponent<global_var>().cat_counter -= 1;
                global_var.GetComponent<global_var>().score -= 1;
            }
            Destroy(gameObject);
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