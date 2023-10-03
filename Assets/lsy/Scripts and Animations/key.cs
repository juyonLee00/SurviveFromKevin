//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class key : MonoBehaviour
//{
//    public bool take;
//    public GameObject doorkey;
//    public Transform Player; 

//    void Start()
//    {
//        take = false;
//    }

//    void OnMouseOver()
//    {

//        if (Player)
//        {
//            float dist = Vector3.Distance(Player.position, transform.position);
//            if (dist < 10)
//            {
//                if (take == false)
//                {

//                }
//                else
//                {
//                    if (take == true)
//                    {
//                        if (Input.GetMouseButtonDown(0))
//                        {
//                            taken();
//                        }
//                    }

//                }

//            }
//        }



//    }

//    private void taken()
//    {
//        Debug.Log("¿­¼è È¹µæ");
//    }

//}