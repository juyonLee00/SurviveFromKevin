using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public bool open = false;
    public float doorOpenAngle = 14.25f;
    public float smoot = 2f;
    // Start is called before the first frame update

    public void OpenDoor()
    {
        open = true;
        if (open)
        {
            Quaternion targetRotation = Quaternion.Euler(0, doorOpenAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smoot * Time.deltaTime);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
