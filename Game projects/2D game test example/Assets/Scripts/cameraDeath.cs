using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class cameraDeath : MonoBehaviour
{
    public CameraController cam;

    JorgePlayerController Jorge;
    JohnsonPlayerController Johnson;
    JoePlayerController Joe;
    CarsonPlayerController Carson;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        Jorge = collision.GetComponent<JorgePlayerController>();
        if (Jorge != null)
        {
            cam.targets.Remove(collision.transform);
            Jorge.TakeDamage(100);
            cam.movable = true;
            return;
        }
        Johnson = collision.GetComponent<JohnsonPlayerController>();
        if (Johnson != null)
        {
            cam.targets.Remove(collision.transform);
            Johnson.TakeDamage(100);
            cam.movable = true;
            return;
        }
        Joe = collision.GetComponent<JoePlayerController>();
        if (Joe != null)
        {
            cam.targets.Remove(collision.transform);
            Joe.TakeDamage(100);
            cam.movable = true;
            return;
        }
        Carson = collision.GetComponent<CarsonPlayerController>();
        if (Carson != null)
        {
            cam.targets.Remove(collision.transform);
            Carson.TakeDamage(100);
            cam.movable = true;
            return;
        }
    }
}
