using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NavKeypad;
using TMPro;

public class BossQuestionManager : MonoBehaviour
{
    [SerializeField] GameObject keypadObject;
    [SerializeField] GameObject secondQuestionManager;
    [SerializeField] TextMeshProUGUI text;

    private bool isSolvedKeyPadQuestion = false;
    private bool isSolvedSecondQuestion = false;
    private int count = 0;

    void Start()
    {
        
    }

    void Update()
    {
        CheckKeyPadQuestion();
        CheckSecondQuestion();
    }

    void CheckKeyPadQuestion()
    {
        Keypad keypadScript = keypadObject.GetComponent<Keypad>();
        if(keypadScript.accessWasGranted)
        {
            if(!isSolvedKeyPadQuestion)
            {
                count += 1;
            }
            isSolvedKeyPadQuestion = true;
            ShowCurrentQuestion();
        }
    }

    void CheckSecondQuestion()
    {
        SecondQuestionGame secondQuestionGame = secondQuestionManager.GetComponent<SecondQuestionGame>();
        if(secondQuestionGame.isCorrect)
        {
            if(!isSolvedSecondQuestion)
            {
                count += 1;
            }
            isSolvedSecondQuestion = true;
            ShowCurrentQuestion();
        }
    }

    void ShowCurrentQuestion()
    {
        //textmeshpro값 가져와서 count / 2 string처리
    }
}
