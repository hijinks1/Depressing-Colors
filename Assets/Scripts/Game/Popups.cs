using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popups : MonoBehaviour
{
    public GameObject pickUpText;
    public bool inReach;
    public Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        pickUpText.SetActive(false);
        inReach = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            Debug.Log("In reach");
            inReach = true;
            pickUpText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            Debug.Log("out of reach");
            inReach = false;
            pickUpText.SetActive(false);
        }
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inReach)
        {
            anim.Play("Stone");
            Debug.Log("turn to stone");
            pickUpText.SetActive(false);
        }
    }
        
    
}
