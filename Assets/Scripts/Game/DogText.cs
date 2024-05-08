using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogText : MonoBehaviour
{
    public GameObject textBox;
    public Animator anim;
    public bool inReach;
    public GameObject wall;
    public AudioClip stone;
    public AudioSource source;
 
    void Start()
    {
        textBox.SetActive(false);
        anim = gameObject.GetComponent<Animator>();
    }

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
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inReach)
        {
            anim.Play("Stone");
            source.PlayOneShot(stone);
            Debug.Log("turn to stone");
            Destroy(wall);
        }
    }
}
