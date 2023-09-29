using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameIntroManager : MonoBehaviour
{
    [SerializeField] Canvas canvas = null;
    [SerializeField] Image background = null;
    [SerializeField] TextMeshProUGUI txtSurvive = null;
    [SerializeField] TextMeshProUGUI txtFrom = null;
    [SerializeField] TextMeshProUGUI txtCavin = null;
    [SerializeField] TextMeshProUGUI txtECMMark_1 = null;
    [SerializeField] TextMeshProUGUI txtECMMark_2 = null;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AppearIntro(1.5f, txtSurvive, txtFrom, txtCavin, txtECMMark_1, txtECMMark_2, background, canvas));
    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator AppearIntro(float t, TextMeshProUGUI i, TextMeshProUGUI j, TextMeshProUGUI k, TextMeshProUGUI l, TextMeshProUGUI m, Image o, Canvas p)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        j.color = new Color(j.color.r, j.color.g, j.color.b, 0);
        k.color = new Color(k.color.r, k.color.g, k.color.b, 0);
        l.color = new Color(l.color.r, l.color.g, l.color.b, 0);
        m.color = new Color(m.color.r, m.color.g, m.color.b, 0);
        o.color = new Color(o.color.r, o.color.g, o.color.b, 1);


        // appear
        // txtSurvive
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }

        // txtFrom
        while (j.color.a < 1.0f)
        {
            j.color = new Color(j.color.r, j.color.g, j.color.b, j.color.a + (Time.deltaTime / t));
            yield return null;
        }

        // txtCavin
        while (k.color.a < 1.0f)
        {
            k.color = new Color(k.color.r, k.color.g, k.color.b, k.color.a + (Time.deltaTime / t));
            yield return null;
        }

        // txtECMMark_1
        while (l.color.a < 1.0f)
        {
            l.color = new Color(l.color.r, l.color.g, l.color.b, l.color.a + (Time.deltaTime / t));
            yield return null;
        }

        // txtECMMark_2
        while (m.color.a < 1.0f)
        {
            m.color = new Color(m.color.r, m.color.g, m.color.b, m.color.a + (Time.deltaTime / t));
            yield return null;
        }

        // disappear
        // txtSurvive
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }

        // txtFrom
        while (j.color.a > 0.0f)
        {
            j.color = new Color(j.color.r, j.color.g, j.color.b, j.color.a - (Time.deltaTime / t));
            yield return null;
        }

        // txtCavin
        while (k.color.a > 0.0f)
        {
            k.color = new Color(k.color.r, k.color.g, k.color.b, k.color.a - (Time.deltaTime / t));
            yield return null;
        }

        // txtECMMark_1
        while (l.color.a > 0.0f)
        {
            l.color = new Color(l.color.r, l.color.g, l.color.b, l.color.a - (Time.deltaTime / t));
            yield return null;
        }

        // txtECMMark_2
        while (m.color.a > 0.0f)
        {
            m.color = new Color(m.color.r, m.color.g, m.color.b, m.color.a - (Time.deltaTime / t));
            yield return null;
        }

        // background
        while (o.color.a > 0.0f)
        {
            o.color = new Color(o.color.r, o.color.g, o.color.b, o.color.a - (Time.deltaTime / t));
            yield return null;
        }

        // canvas
        canvas.gameObject.SetActive(false);
    }
}
