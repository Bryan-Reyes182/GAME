using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoTeclado : MonoBehaviour
{
    public float RunSpeed = 2;
    public float jumpSpeed = 3;
    Rigidbody2D rb2D;
    public Animator animator;
    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            rb2D.velocity = new Vector2(RunSpeed, rb2D.velocity.y);
            animator.SetBool("Jump", false);
            spriteRenderer.flipX = false;
            animator.SetBool("Run", true);
        }
        else if (Input.GetKey("a"))
        {
            rb2D.velocity = new Vector2(-RunSpeed, rb2D.velocity.y);
            animator.SetBool("Jump", false);
            spriteRenderer.flipX = true;
            animator.SetBool("Run", true);
        }
        else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
            animator.SetBool("Run", false);
        }

    }
}
