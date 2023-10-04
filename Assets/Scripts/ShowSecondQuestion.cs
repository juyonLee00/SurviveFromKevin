using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSecondQuestion : MonoBehaviour
{
    [SerializeField] public Camera getCamera;
    [SerializeField] GameObject secondQuestionManager;
    [SerializeField] GameObject gameBoard;
    private string interactableTag = "Monitor";

    private RaycastHit hit;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = getCamera.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit))
            {
                string objectName = hit.collider.gameObject.name;
                
                if (hit.collider.CompareTag(interactableTag))
                {
                    SecondQuestionGame secondQuestionGame = secondQuestionManager.GetComponent<SecondQuestionGame>();
                    secondQuestionManager.SetActive(true);
                }
            }
        }
        

    }

}
