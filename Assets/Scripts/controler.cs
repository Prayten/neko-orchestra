using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controler : MonoBehaviour{
    public GameObject diri;
    public Animator animator;

    private float speed;
    private bool isFacingRight = true;
    private bool acses = false;


    private void Start()
    {
        speed = 80;
    }
    //updete per frame
    void Update(){
        if (Time.frameCount % 60 == 0 && !acses){
            if (Random.Range(1, 11) == 1) {
                animator.SetTrigger("sleep");
                diri.GetComponent<dirihore>().cat_counter += 1;
                acses = true;
            }
        }
    }

    //check
    void OnMouseDown(){
        if (acses){
            animator.SetTrigger("poof");
            animator.SetTrigger("timer");
            diri.GetComponent<dirihore>().cat_counter -= 1;
            acses = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
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
        this.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed * f, 0));
    }
}