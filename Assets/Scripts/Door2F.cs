using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2F : MonoBehaviour
{
    bool isDoorOpen = false;
    float doorOpenAngle = 45f;
    float doorCloseAngle = 0f;
    float smooth = 2f;


    public void ChangeDoorState()
    {
        isDoorOpen = !isDoorOpen;
    }

    void Update()
    {
        if(isDoorOpen)
        {
            DoorAction(doorOpenAngle);
        }

        else
        {
            DoorAction(doorCloseAngle);
        }
    }

    void DoorAction(float doorAngle)
    {
        Quaternion targetRotation = Quaternion.Euler(0, doorAngle, 0);
        transform.rotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
    }
}
