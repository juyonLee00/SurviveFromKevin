using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NavKeypad;
using TMPro;
using UnityEngine.SceneManagement;

public class BossQuestionManager : MonoBehaviour
{
    [SerializeField] GameObject keypadObject;
    [SerializeField] GameObject secondQuestionManager;
    [SerializeField] TextMeshProUGUI currentQuestionText;
    [SerializeField] GameObject panel;

    private bool isSolvedKeyPadQuestion = false;
    private bool isSolvedSecondQuestion = false;
    private bool isKeyPadOnce = false;
    private bool isSecondOnce = false;
    private int count = 0;
    private int QuestionNum = 2;

    void GoToNextScene()
    {
        SceneManager.LoadScene("GameEnd");
    }

    void Update()
    {
        ShowCurrentQuestion();
        CheckKeyPadQuestion();
        CheckSecondQuestion();
    }

    void CheckKeyPadQuestion()
    {
        Keypad keypadScript = keypadObject.GetComponent<Keypad>();
        if(keypadScript.accessWasGranted)
        {
            isKeyPadOnce = true;
            if(!isSolvedKeyPadQuestion && isKeyPadOnce)
            {
                Debug.Log("plus1key");
                count += 1;
            }
            isSolvedKeyPadQuestion = true;
        }
    }

    void CheckSecondQuestion()
    {
        SecondQuestionGame secondQuestionGame = secondQuestionManager.GetComponent<SecondQuestionGame>();
        Debug.Log(secondQuestionGame.isSuccess + "isSuccess값");
        if(secondQuestionGame.isSuccess)
        {
            isSecondOnce = true;
            if(!isSolvedSecondQuestion && isSecondOnce)
            {
                Debug.Log("plus1second");
                count += 1;
            }
            isSolvedSecondQuestion = true;
        }
    }

    void ShowCurrentQuestion()
    {
        panel.SetActive(true);
        currentQuestionText.text = $"{count} / {QuestionNum}";

        if(count == QuestionNum)
        {
            GoToNextScene();
        }
    }
}
