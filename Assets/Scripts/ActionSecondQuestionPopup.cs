using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionSecondQuestionPopup : MonoBehaviour
{
    [SerializeField] GameObject questionWindow;
    public void CloseWindow()
    {
        questionWindow.SetActive(false);
    }

    public void RestartWindow()
    {
        Debug.Log("Restart");
    }
}
