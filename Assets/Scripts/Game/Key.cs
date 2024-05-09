using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject textBox;
    public GameObject wall;
    public bool inReach;
    public bool checkDrawer = false;
    public AudioClip key;
    public AudioSource source;
    public GameObject keyFound;
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
            inReach = false;
            keyFound.SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inReach)
        {
            Debug.Log("Key found");
            source.PlayOneShot(key);
            checkDrawer = true;
            textBox.SetActive(false);
            keyFound.SetActive(true);
            Destroy(wall);
        }
    }
}
