using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHP : MonoBehaviour
{
    public static int JorgeTextHP = 100;
    Text JorgeTextH;
    // Start is called before the first frame update
    void Start()
    {
        JorgeTextH = GetComponent<Text>();
    }
   
    // Update is called once per frame
    void Update()
    {
        JorgeTextH.text = GameManager.JorgeHP.ToString();
    }
}
