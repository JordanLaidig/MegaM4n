using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JohnsonPlayerController : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    BoxCollider2D boxCollider2d;
<<<<<<< HEAD
    public Health health;
    JohnsonBar bar;
=======
    Health health;
    Transform direction;
>>>>>>> 34159bfb7e8550a57d1abc14f128447244932515

    bool grounded = true;
    bool onWall = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        health = GetComponent<Health>();
        direction = GetComponent<Transform>();

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetKey("h"))
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            rb.velocity = new Vector2(6, rb.velocity.y);
        }
        else if (Input.GetKey("f"))
        {
            transform.eulerAngles = new Vector3(0, -180, 0);
            rb.velocity = new Vector2(-6, rb.velocity.y);
        }

        if (Input.GetKey("t") && grounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, 20);
            grounded = false;
        }
<<<<<<< HEAD
        bar.game.JohnsonHP = health.getHealth();
=======
        else if (Input.GetKey("t") && onWall && direction.rotation.y == 0)
        {
            rb.velocity = new Vector2(-6, 20);
            onWall = false;
        }
        else if (Input.GetKey("t") && onWall && direction.rotation.y != 0)
        {
            rb.velocity = new Vector2(6, 20);
            onWall = false;
        }
>>>>>>> 34159bfb7e8550a57d1abc14f128447244932515
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = true;
            onWall = false;
        }
        else if (collision.gameObject.CompareTag("Wall"))
        {
            onWall = true;
            grounded = false;

        }
    }
}
