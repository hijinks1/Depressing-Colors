using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;

public class Lookat : MonoBehaviour
{
    public bool Reverse;
    public GameObject Player;
    
    void Update()
    {
        transform.LookAt(Player.transform);
        Vector3 rot = transform.rotation.eulerAngles;
        if (Reverse == true)
        {
            transform.rotation = Quaternion.Euler(0,rot.y + 180,0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0,rot.y,0);
        }
    }
}
