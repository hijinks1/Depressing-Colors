using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Searchforkey : MonoBehaviour
{
    public GameObject textBox;
    public bool inReach;
    public bool checkDrawer = false;
    public AudioClip nope;
    public AudioSource source;
    public GameObject noKey;
    public void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Reach"))
        {
            if (checkDrawer == false)
            {
                textBox.SetActive(true);
                inReach = true;
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Reach"))
        {
            textBox.SetActive(false);
            noKey.SetActive(false);
            inReach = false;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inReach)
        {
            Debug.Log("Key NOT found");
            source.PlayOneShot(nope);
            textBox.SetActive(false);
            noKey.SetActive(true);
            checkDrawer = true;
        }
    }
}
