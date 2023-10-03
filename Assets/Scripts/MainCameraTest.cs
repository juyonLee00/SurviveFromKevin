using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraTest : MonoBehaviour
{
    public Transform PlayerCamera;
    [Header("MaxDistance you can open or close the door.")]
    public float MaxDistance = 5;

    private bool opened = false;
    private Animator anim;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Pressed();
            Debug.Log("You Press E");
        }
    }

    void Pressed()
    {
        //This will name the Raycasthit and came information of which object the raycast hit.
        RaycastHit doorhit;
        Debug.Log("Pressed");
        if (Physics.Raycast(PlayerCamera.transform.position + new Vector3(0,0,50), PlayerCamera.transform.forward, out doorhit, MaxDistance))
        {
            Debug.Log("ray");
            // if raycast hits, then it checks if it hit an object with the tag Door.
            if (doorhit.transform.tag == "Door")
            {
                Debug.Log("Doorhit");
                //This line will get the Animator from  Parent of the door that was hit by the raycast.
                /*anim = doorhit.transform.GetComponentInParent<Animator>();

                //This will set the bool the opposite of what it is.
                opened = !opened;

                //This line will set the bool true so it will play the animation.
                anim.SetBool("Opened", !opened);*/
            }
        }
    }
}
