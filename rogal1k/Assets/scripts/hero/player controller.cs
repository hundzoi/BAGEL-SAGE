using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpForce;
    public Transform groundCheck;
    public LayerMask whatIsGround;
    public float radiusGroundCheck;
    private bool isGrounded;
   private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   
   private void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal"), rb.velocity.y);

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, radiusGroundCheck, whatIsGround);

        if (Input.GetKeyDown(KeyCode.W) && isGrounded)

            Jump();
    }
    void Jump()
    {
        rb.AddForce(transform.up * 115, ForceMode2D.Impulse);
    }
}
