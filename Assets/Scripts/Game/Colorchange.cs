using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorchange : MonoBehaviour
{

    public Camera Eyes;
    public Material Gray;
    public Movement other;
    
    void Update()
    {
        ClickColor();

    }
    
    public void ClickColor()
    {
        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(Eyes.transform.position, Eyes.transform.forward,
                    out RaycastHit hit, 5))
            {
                //counts through all the mesh renderers and saves into "meshes"
                MeshRenderer[] meshes = hit.collider.GetComponentsInChildren<MeshRenderer>();
                
                foreach (MeshRenderer m in meshes)
                {
                    //turn into this material
                    m.material = Gray;
                }
                
                // this is the same as ^
                // for (int i = 0; i < meshes.Length; i++)
                //  {
                //      meshes[i].material = Gray;
                //  }
            }
        }
    }
    
    
}
