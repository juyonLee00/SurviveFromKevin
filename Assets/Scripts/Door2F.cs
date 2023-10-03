using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2F : MonoBehaviour
{
    bool isDoorOpen = false;
    float doorOpenAngle = 60f;
    float doorCloseAngle = 0f;
    float smooth = 2f;


    public void ChangeDoorState()
    {
        isDoorOpen = !isDoorOpen;
    }

    void Update()
    {
        Quaternion targetRotation = Quaternion.Euler(0, doorOpenAngle, 0);
        transform.rotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);

        if (isDoorOpen)
        {
            Debug.Log("doorOpen");
            DoorAction(doorOpenAngle);
        }

        else
        {
            Debug.Log("doorClose");
            DoorAction(doorCloseAngle);
        }
    }

    void DoorAction(float doorAngle)
    {
        Quaternion targetRotation = Quaternion.Euler(0, doorAngle, 0);
        transform.rotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
    }
}
