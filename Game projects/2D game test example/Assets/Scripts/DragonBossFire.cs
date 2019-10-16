using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonBossFire : MonoBehaviour
{
    public float speed = 3;
    public Rigidbody2D rb;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        JorgePlayerController player = collision.GetComponent<JorgePlayerController>();
        if (player != null)
        {
            player.TakeDamage(damage);
            Destroy(gameObject);

        }
        CarsonPlayerController player2 = collision.GetComponent<CarsonPlayerController>();
        if (player2 != null)
        {
            player2.TakeDamage(damage);
            Destroy(gameObject);

        }
        JoePlayerController player3 = collision.GetComponent<JoePlayerController>();
        if (player3 != null)
        {
            player3.TakeDamage(damage);
            Destroy(gameObject);

        }
        JohnsonPlayerController player4 = collision.GetComponent<JohnsonPlayerController>();
        if (player4 != null)
        {
            player4.TakeDamage(damage);
            Destroy(gameObject);

        }
    }

}
