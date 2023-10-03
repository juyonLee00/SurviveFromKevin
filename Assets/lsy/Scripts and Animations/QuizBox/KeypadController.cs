using NavKeypad;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadController : MonoBehaviour
{
    public GameObject keypad;
    public Camera playerCamera;
    public GameObject keypadCam;
    public GameObject playerCam;
    private bool isKeypadActive = false;
    private Camera cam;
    public Transform Player;
    private void Awake() => cam = Camera.main;

    void Start()
    {
    }

    void OnMouseOver()
    {
        if (Player)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject == keypad)
                    {
                        isKeypadActive = true;
                        Debug.Log("»Æ¿Œ");
                    }
                    else
                    {
                        isKeypadActive = false;
                    }
                }
            }

            if (isKeypadActive)
            {
                keypadCam.SetActive(true);
                playerCam.SetActive(false);
                var ray = cam.ScreenPointToRay(Input.mousePosition);

                if (Input.GetMouseButtonDown(0))
                {
                    if (Physics.Raycast(ray, out var hit))
                    {
                        if (hit.collider.TryGetComponent(out KeypadButton keypadButton))
                        {
                            keypadButton.PressButton();
                        }
                    }
                }
            }
            else
            {
                keypadCam.SetActive(false);
                playerCam.SetActive(true);
            }
        }
    }
}