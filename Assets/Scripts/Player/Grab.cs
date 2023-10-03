using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    public Animator animator;
    GameObject grabbedobj;
    public Rigidbody rb;
    public int isLeftorRight;
    public bool alreadyGrabbing = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(isLeftorRight))
        {
            if (isLeftorRight==0)
            {
                animator.SetBool("isLeftArm", true);
            }
            else if(isLeftorRight==1)
            {
                animator.SetBool("isRightArm", true);
            }
            if (grabbedobj != null)
            {
                FixedJoint fj = grabbedobj.AddComponent<FixedJoint>();
                fj.connectedBody = rb;
                fj.breakForce = 9001;
            }

            //FixedJoint fj = grabbedobj.AddComponent<FixedJoint>();
            //fj.connectedBody = rb;
            //fj.breakForce = 9001;
        }
        else if(Input.GetMouseButtonUp(isLeftorRight))
        {
            if (isLeftorRight == 0)
            {
                animator.SetBool("isLeftArm", false);
            }
            else if (isLeftorRight == 1)
            {
                animator.SetBool("isRightArm", false);
            }

            if (grabbedobj != null)
            {
                Destroy(grabbedobj.GetComponent<FixedJoint>());
            }

            grabbedobj = null;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            grabbedobj = other.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        grabbedobj = null;
    }
}
