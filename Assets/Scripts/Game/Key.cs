using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject textBox;
    public GameObject wall;
    public bool inReach;
    public AudioClip key;
    public AudioSource source;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Reach"))
        {
            textBox.SetActive(true);
            inReach = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Reach"))
        {
            textBox.SetActive(false);
            inReach = false;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inReach)
        {
            Debug.Log("Key found");
            source.PlayOneShot(key);
            textBox.SetActive(false);
            Destroy(wall);
        }
    }
}
