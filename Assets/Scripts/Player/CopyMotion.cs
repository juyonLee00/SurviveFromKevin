//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class CopyMotion : MonoBehaviour
//{
//    public Transform targetLimb;
//    public bool mirror;
//    ConfigurableJoint cj;
//    // Start is called before the first frame update
//    void Start()
//    {
//        cj = GetComponent<ConfigurableJoint>();

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if(!mirror)
//        {
//            cj.targetRotation = targetLimb.rotation;
//        }
//        else
//        {
//            cj.targetRotation = Quaternion.Inverse(targetLimb.rotation);
//        }
//    }
//}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyMotion : MonoBehaviour
{
    [SerializeField] private Transform targetLimb;
    [SerializeField] private ConfigurableJoint m_ConfigurableJoint;


    Quaternion targetInitialRotation;
    // Start is called before the first frame update
    void Start()
    {
        this.m_ConfigurableJoint = this.GetComponent<ConfigurableJoint>();
        this.targetInitialRotation = this.targetLimb.transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        this.m_ConfigurableJoint.targetRotation = copyRotation();
    }

    private Quaternion copyRotation()
    {
        return Quaternion.Inverse(this.targetLimb.localRotation) * this.targetInitialRotation;
    }
}
