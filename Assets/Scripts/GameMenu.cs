using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    bool currentPlay = false;
    bool gameQuitBtn = false;
    bool gameSaveCheck = false;
    bool gameQuitAgree = false;

    // TODO
    // 해당 게임 씬 연결하기
    public void PlayGame()
    {
        // Play 중인 게임이 없을 경우 StartScene 이동
        if (currentPlay == false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        // Play 중인 게임으로 이동
        else
        {
            
        }
    }

    // TODO
    // 게임 종료 확인 팝업
    // 현재 Play중인 게임이 있을 경우 저장 확인 팝업
    public void QuitGame()
    {
        if (gameQuitBtn == true)
        {
            if (gameSaveCheck && gameQuitAgree)
            {
                Application.Quit();
            }
        }
        else
        {
            Debug.Log("Quit");
        }
        
    }
}
