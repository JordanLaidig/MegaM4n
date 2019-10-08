using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public float speed = 20;
    public Rigidbody2D rb;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        JousterAi enemy = collision.GetComponent<JousterAi>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);

        Tirtul turtle = collision.GetComponent<Tirtul>();
        if (turtle != null)
        {
            turtle.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
