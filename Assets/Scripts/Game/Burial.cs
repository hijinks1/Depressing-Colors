using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Burial : MonoBehaviour
{
    public Sun ss;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Dog")
        {
            Debug.Log("burial commensed");
            ss.buried = true;
        }
    }
    
}
