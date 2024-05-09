using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextCollider : MonoBehaviour
{
    public GameObject textBox;
    public GameObject wall;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Reach"))
        {
            textBox.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Reach"))
        {
            textBox.SetActive(false);
        }
    }
    
}
