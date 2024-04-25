using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorchange : MonoBehaviour
{

    public Camera Eyes;
    public Material Gray;
    
   
    void Start()
    {
        
    }
    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(Eyes.transform.position, Eyes.transform.forward,
                    out RaycastHit hit, 5))
            {
                MeshRenderer[] meshes = hit.collider.GetComponentsInChildren<MeshRenderer>();
                
                foreach (MeshRenderer m in meshes)
                {
                    m.material = Gray;
                }
                
            }
        }
    }
    
}
