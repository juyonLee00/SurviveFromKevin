using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSecondQuestion : MonoBehaviour
{
    [SerializeField] GameObject secondQuestionImage;

    [SerializeField] public Camera getCamera;

    private RaycastHit hit;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = getCamera.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit))
            {
                string objectName = hit.collider.gameObject.name;
                Debug.Log(objectName);
                secondQuestionImage.SetActive(true);
            }
        }
        

    }

}
