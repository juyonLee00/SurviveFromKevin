using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class SceneChange : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
       
        //SceneManager.LoadScene("Scene_2F");
        SceneManager.LoadScene(2);
        //StartCoroutine(nameof(AppearIntro),background);
    }

    //public  IEnumerator AppearIntro(CanvasGroup o)
    //{
    //    // canvas
    //    //canvas.gameObject.SetActive(true);

    //    // background
    //    //while (o.alpha > 0.6)
    //    //{
    //    //    Debug.Log(o.alpha);
    //    //    o.alpha -= 0.02f * Time.deltaTime;
    //    //    yield return null;

    //    //}


    //    // background

    //    SceneManager.LoadScene(2);
    //}
}
