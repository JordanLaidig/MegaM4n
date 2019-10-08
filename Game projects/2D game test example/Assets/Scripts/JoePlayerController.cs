using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoePlayerController : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;

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
            rb.velocity = new Vector2(2, rb.velocity.y);
        }
        else if (Input.GetKey("left"))
        {
            rb.velocity = new Vector2(-2, rb.velocity.y);
        }

        if (Input.GetKey("up"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 5);
        }
    }
}
