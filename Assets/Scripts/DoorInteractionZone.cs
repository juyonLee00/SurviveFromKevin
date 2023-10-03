using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteractionZone : MonoBehaviour
{
    Door2F door2FScript;

    public void ActiveInteractionZone()
    {
        door2FScript.ChangeDoorState();
    }
}
