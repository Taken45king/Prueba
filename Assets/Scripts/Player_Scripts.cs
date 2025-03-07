using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Scripts : MonoBehaviour
{
    public float runSpeed = 2f;
    public float movementSmoothing = 0.05f;
    public float jumpForce = 400f;
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;

    private Rigidbody2D rigidbody2D;
    private bool facingRight = true;
    private float horizontalMove = 0f;
    private Vector3 currentVelocity = Vector3.zero;
    private float velocityCompesation = 10f;
    private bool jumpPressed = false;
    private bool isGrounded = true;
    

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

    }
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal") * runSpeed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpPressed = true;
        }
    }
    private void FixedUpdate()
    {
        isGrounded = false;
        /*Collider2D[] groundColliders = Physics2D.OverlapCircleAll(groundCheck.position, groundCheckRadius.groundLayer);
        for (int i = 0; i < groundColliders.Length; i++)
        {
            if (groundColliders[i].gameObject  != this.gameObject)
            {
                isGrounded= true;
            }
        }*/

        Move(horizontalMove * Time.fixedDeltaTime);

        if (horizontalMove > 0f && !facingRight)
        {
            Flip();
        }
        else if (horizontalMove < 0f && facingRight)
        {
            Flip();
        }

    }
    
    private void Move(float _move)
    {
        Vector3 targetVelocity = new Vector2(_move * velocityCompesation, rigidbody2D.velocity.y);
        rigidbody2D.velocity = Vector3.SmoothDamp(rigidbody2D.velocity, targetVelocity, ref currentVelocity, movementSmoothing);

        if (jumpPressed && isGrounded)
        {
            rigidbody2D.AddForce(new Vector2(0f, jumpForce));
            jumpPressed = false;
            isGrounded = false;
        }
    }

    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 targetScale = transform.localScale;
        targetScale.x *= -1;
        transform.localScale = targetScale;
    }

}
