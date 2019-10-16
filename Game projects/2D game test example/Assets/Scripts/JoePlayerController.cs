using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoePlayerController : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    bool grounded = true;
    public int health;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetKey("right"))
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            rb.velocity = new Vector2(6, rb.velocity.y);
        }
        else if (Input.GetKey("left"))
        {
            transform.eulerAngles = new Vector3(0, -180, 0);
            rb.velocity = new Vector2(-6, rb.velocity.y);
        }

        if (Input.GetKey("up") && grounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, 20);
            grounded = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
