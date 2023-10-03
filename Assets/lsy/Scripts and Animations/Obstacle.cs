using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            RestartGame();
        }
    }

    private void RestartGame()
    {
        // 게임 재시작을 위해 현재 씬을 다시 로드합니다.
        //Scene currentScene = SceneManager.GetActiveScene();
        //SceneManager.LoadScene(currentScene.buildIndex);
        Debug.Log("ggggg");
    }
}
