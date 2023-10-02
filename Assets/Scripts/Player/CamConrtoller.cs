using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamConrtoller : MonoBehaviour
{
    public float rotationSpeed = 1;
    public Transform root;

    float mouseX, mouseY;

    public float stomachoffset;

    public ConfigurableJoint hipjoint, stomachjoint;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void FixedUpdate()
    {
        CamControl();
    }
    void CamControl()
    {
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed;
        mouseY = Mathf.Clamp(mouseY, -35, 60);

        Quaternion rootRotation = Quaternion.Euler(mouseY, mouseX, 0);

        root.rotation = rootRotation;

        hipjoint.targetRotation = Quaternion.Euler(0, -mouseX, 0);
        stomachjoint.targetRotation = Quaternion.Euler(-mouseY + stomachoffset, 0, 0);
    }    
    // Update is called once per frame
    void Update()
    {
        
    }
}
