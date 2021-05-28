using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMove : MonoBehaviour
{
    float horizontalMove = 0;
    public float runSpeedHorizontal = 3;
    public float runSpeed = 0;
    public float jumpForce = 2;
    public Joystick joystick;
    public new Rigidbody2D rigidbody2D;
    public SpriteRenderer spriteRenderer;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        if (joystick.Vertical >= 0.5f && IsGrounded.isGrounded)
        {
            Jump();
        }

               if (IsGrounded.isGrounded == false)
                {
                    animator.SetBool("Jump", true);
                    animator.SetBool("Run", false);

                }
                if (IsGrounded.isGrounded == true)
                {
                    animator.SetBool("Jump", false);
                }
        horizontalMove = joystick.Horizontal * runSpeedHorizontal;
             if (joystick.Horizontal >= 0.1 && IsGrounded.isGrounded == true)
               {
                   spriteRenderer.flipX = false;
                   animator.SetBool("Run", true);
               }
              else if (joystick.Horizontal <= -0.1 && IsGrounded.isGrounded == true)
               {
                   spriteRenderer.flipX = true;
                   animator.SetBool("Run", true);
               }
              else
               {
                   animator.SetBool("Run", false);
               }
        transform.position += new Vector3(horizontalMove, 0, 0) * Time.deltaTime * runSpeed;
    }
    public void Jump()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
    }
}
