using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public int jump;
    public int speed;
    public Transform groundCheck;
    public LayerMask whatIsGround;
    public Text text;
    public int live = 3;

    private Rigidbody2D rb;
    private bool isGrounded = false;
    private float groundRadius = 0.2F;
    private Animator anim;
    private bool isFacingRight = true;
    private int count = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Cherry"))

        {
            count = count + 1;
            text.text = "Count: " + count.ToString();
            other.gameObject.SetActive(false);
        }
    }

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();

        rb = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        if (isGrounded && Input.GetKeyDown(KeyCode.W))
        {

            anim.SetBool("Ground", false);
            rb.AddForce(new Vector2(0, 300));
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        anim.SetBool("Ground", isGrounded);
        anim.SetFloat("vSpeed", rb.velocity.y);



        if (!isGrounded)
        {
            rb.velocity = new Vector2(moveHorizontal * speed, rb.velocity.y);
            if (moveHorizontal > 0 && !isFacingRight)
                Flip();
            else if (moveHorizontal < 0 && isFacingRight)
                Flip();
            return;
        }


        anim.SetFloat("speed", Mathf.Abs(moveHorizontal));

        rb.velocity = new Vector2(moveHorizontal * speed, rb.velocity.y);

        if (moveHorizontal > 0 && !isFacingRight)
            Flip();
        else if (moveHorizontal < 0 && isFacingRight)
            Flip();



    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }




}
