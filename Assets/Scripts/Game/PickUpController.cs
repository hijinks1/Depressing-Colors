using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpController : MonoBehaviour
{
    public float pickUpRange = 2f;
    public KeyCode pickUpKey = KeyCode.Q;
    private GameObject currentPickUpObject = null;
    public Camera Eyes;
    
    void Update()
    {
        if (Input.GetKeyDown(pickUpKey))
        {
            if (currentPickUpObject != null && currentPickUpObject.GetComponent<PickUpObject>().isPickedUp)
            {
                DropObject();
            }
            else
            {
                TryPickUp();
            }
        }
    }

    public void TryPickUp()
    {
        RaycastHit hit;
        if (Physics.Raycast(Eyes.transform.position, Eyes.transform.forward, out hit, pickUpRange))
        {
            if (hit.collider.GetComponent<PickUpObject>() != null)
            {
                currentPickUpObject = hit.collider.gameObject;
                currentPickUpObject.GetComponent<PickUpObject>().isPickedUp = true;
                currentPickUpObject.transform.SetParent(transform);
                currentPickUpObject.transform.localPosition = new Vector3(0, 0, 2); // Position in front of the player
                Rigidbody rb = currentPickUpObject.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.isKinematic = true;
                }
            }
        }
    }

    public void DropObject()
    {
        if (currentPickUpObject != null)
        {
            currentPickUpObject.GetComponent<PickUpObject>().isPickedUp = false;
            Rigidbody rb = currentPickUpObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = false;
            }
            currentPickUpObject.transform.parent = null;
            currentPickUpObject = null;
        }
    }
}
