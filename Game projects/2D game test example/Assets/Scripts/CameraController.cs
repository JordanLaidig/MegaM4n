using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public List<Transform> targets;
    public float smoothTime = .5f;
    public Vector3 offset;
    public bool movable = true;
    private Vector3 velocity;
    
    // Start is called before the first frame update

    // Update is called once per frame
    void LateUpdate()
    {
        if (targets.Count == 0)
            return;
        
        if(movable)
            Move();

       
    }

    void Move()
    {
        Vector3 centerPoint = GetCenterPoint();

        Vector3 newPosition = centerPoint + offset;

        transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref velocity, smoothTime);
    }

    Vector3 GetCenterPoint()
    {
        if(targets.Count == 1)
        {
            return targets[0].position;
        }

        var bounds = new Bounds(targets[0].position, Vector3.zero);

        foreach(Transform t in targets)
        {
            bounds.Encapsulate(t.position);
        }

        return bounds.center;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            GetComponent<BoxCollider2D>().isTrigger = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        GetComponent<BoxCollider2D>().isTrigger = true;
    }

}
