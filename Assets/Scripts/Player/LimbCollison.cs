using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimbCollison : MonoBehaviour
{
    public PlayerController PlayerController;
    // Start is called before the first frame update
    void Start()
    {
        PlayerController = GameObject.FindObjectOfType<PlayerController>().GetComponent<PlayerController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        PlayerController.isGrounded = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
