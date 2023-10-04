using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    [SerializeField] Canvas canvas = null;
    [SerializeField] CanvasGroup background = null;

    private void Start()
    {
        StartCoroutine(nameof(AppearIntro),background);
    }
    public IEnumerator AppearIntro(CanvasGroup o)
    {
        canvas.gameObject.SetActive(true);

        while (o.alpha > 0.2)
        {
            Debug.Log(o.alpha);
            o.alpha -= 0.5f * Time.deltaTime;
            yield return null;

        }
    }
}
