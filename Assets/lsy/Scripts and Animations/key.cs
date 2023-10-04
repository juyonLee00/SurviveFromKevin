using SojaExiles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    public GameObject DoorKey;
    public Transform Player;
    public GameObject door;
    private Animator doorAnimator;

    void Start()
    {
        doorAnimator = door.GetComponent<Animator>();
    }

    void OnMouseOver()
    {

        if (Player)
        {
            float dist = Vector3.Distance(Player.position, transform.position);
            if (dist < 15)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    UnlockDoor();
                    Debug.Log("¿­¼è´ç");
                }
            }
        }
    }

    void UnlockDoor()
    {
        DoorKey.SetActive(false);
        doorAnimator.enabled = true;
    }
}