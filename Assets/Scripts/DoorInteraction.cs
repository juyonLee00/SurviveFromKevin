using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorInteraction : MonoBehaviour
{
    [SerializeField] private int interactionDistance = 5;

    private const string interactableTag = "Door";


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("e");

            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, interactionDistance))
            {
                Debug.Log("ray");
                if(hit.collider.CompareTag(interactableTag))
                {
                    Debug.Log("collider");
                    //hit.collider.transform.parent.GetComponent<Door2F>().ChangeDoorState();
                }
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.forward);

    }
}
