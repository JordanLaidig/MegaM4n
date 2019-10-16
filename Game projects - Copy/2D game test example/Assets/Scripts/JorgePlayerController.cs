using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JorgePlayerController : MonoBehaviour
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
        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector2(2, rb.velocity.y);
        }
        else if (Input.GetKey("a"))
        {
            rb.velocity = new Vector2(-2, rb.velocity.y);
        }

        if(Input.GetKey("w"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 5);
        }
    }
}
