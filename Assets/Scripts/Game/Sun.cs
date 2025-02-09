using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sun : MonoBehaviour
{
    public GameObject textBox;
    public bool inReach;
    public bool buried;
    public GameObject winText;

    public void Start()
    {
        buried = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Reach") && !buried)
        {
            textBox.SetActive(true);
            inReach = true;
        }

        if (other.CompareTag("Reach") && buried)
        {
            winText.SetActive(true);
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
        if (Input.GetKeyDown(KeyCode.E)&& inReach && buried)
        {
            SceneManager.LoadScene("End");
            Debug.Log("Lights out");
        }
    }
}
