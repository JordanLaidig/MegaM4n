using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public Transform bar;
    void Start()
    {
        bar = transform.Find("HealthBar");
    }

    public void SetSize(float n)
    {
        bar = transform.Find("HealthBar");
        bar.localScale = new Vector3(n, 1);
    }
    public void FixedUpdate()
    {
        SetSize(GameManager.JorgeHP * .01f);
    }
}
