using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    [SerializeField]
    public float interactionDistance = 5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, interactionDistance))
            {
                if(hit.collider.CompareTag("Door"))
                {
                    hit.collider.transform.parent.GetComponent<Door2F>().ChangeDoorState();
                }
            }
        }
        
    }
}
