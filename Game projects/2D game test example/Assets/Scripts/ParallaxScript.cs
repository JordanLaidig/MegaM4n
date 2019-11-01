using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void OnEnable()
    {
        CameraController.ParallaxUpdate += UpdateParallax;
    }

    void OnDisable()
    {
        CameraController.ParallaxUpdate -= UpdateParallax;
    }

    void UpdateParallax(Vector3 vector)
    {
        Vector3 tempVector = transform.position;
        tempVector.x = vector.x*(-transform.position.z);
        transform.position = tempVector;//Change x position of object based on z position of object
        Debug.Log(transform.position);
    }
}