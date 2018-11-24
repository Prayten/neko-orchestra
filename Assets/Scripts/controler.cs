using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controler : MonoBehaviour{

    public GameObject globar_var;
    
    public bool cat_sleep;
    
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

    void Update(){
        if (Time.frameCount % 60 == 0 && !cat_sleep && !random){
            if (Random.Range(1, 2) == 1) {
                GetComponent<Animator>().SetTrigger("sleep");
                cat_sleep = true;

                globar_var.GetComponent<globar_var>().cat_counter += 1;
            }
        }
    }

    //check
    void OnMouseDown(){
        if (cat_sleep){
            GetComponent<Animator>().SetTrigger("poof");
            GetComponent<Animator>().SetTrigger("timer");
            cat_sleep = false;
            globar_var.GetComponent<globar_var>().score += 1;
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