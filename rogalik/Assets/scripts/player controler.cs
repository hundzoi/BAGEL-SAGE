using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroler : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animation;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animation = GetComponent<Animator>();

    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * 5, rb.velocity.y);
        if (Input.GetAxis("Horizontal") != 0)
            animation.SetInteger("Animation", 1);
        if (Input.GetKeyDown(KeyCode.S))
            Crouch();
        if (Input.GetKey(KeyCode.W))
            jump();
    }
    void Crouch()
    {
        animation.SetInteger("Animation", 4);
        GetComponent<BoxCollider2D>().size = new Vector2(0.29f, 0.2f);
        GetComponent<BoxCollider2D>().offset = new Vector2(0.01f, -0.15f);
    }
    void jump()
    {
        animation.SetInteger("Animation", 2);
        rb.AddForce(transform.up * 5, ForceMode2D.Impulse);
    }
}
