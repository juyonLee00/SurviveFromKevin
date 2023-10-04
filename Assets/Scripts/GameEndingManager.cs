using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameEndingManager : MonoBehaviour
{
    [SerializeField] Image thief_1 = null;
    [SerializeField] Image thief_2 = null;
    [SerializeField] Image thief_3 = null;
    [SerializeField] Image thief_4 = null;
    [SerializeField] TextMeshProUGUI endingStory_1 = null;
    [SerializeField] TextMeshProUGUI delay_1 = null;
    [SerializeField] TextMeshProUGUI endingStory_2 = null;
    [SerializeField] TextMeshProUGUI endingStory_3 = null;
    [SerializeField] TextMeshProUGUI endingStory_4 = null;
    [SerializeField] TextMeshProUGUI delay_2 = null;
    [SerializeField] TextMeshProUGUI txtIntroduce_1 = null;
    [SerializeField] TextMeshProUGUI jongsuPark = null;
    [SerializeField] TextMeshProUGUI jooyeonLee = null;
    [SerializeField] TextMeshProUGUI seungyeonLee = null;
    [SerializeField] TextMeshProUGUI yuseopSong = null;
    [SerializeField] TextMeshProUGUI hanaChoi = null;
    [SerializeField] TextMeshProUGUI delay_3 = null;
    [SerializeField] TextMeshProUGUI developmentPeriod = null;
    [SerializeField] TextMeshProUGUI period = null;
    [SerializeField] TextMeshProUGUI delay_4 = null;
    [SerializeField] TextMeshProUGUI developmentTools = null;
    [SerializeField] TextMeshProUGUI tools = null;
    [SerializeField] TextMeshProUGUI delay_5 = null;
    [SerializeField] TextMeshProUGUI gameProductionTeam = null;
    [SerializeField] TextMeshProUGUI team = null;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EndingStory(1.5f, thief_1, thief_2, thief_3, thief_4, endingStory_1, delay_1, endingStory_2, endingStory_3, endingStory_4, delay_2, txtIntroduce_1, jongsuPark, jooyeonLee, seungyeonLee, yuseopSong, hanaChoi, delay_3, developmentPeriod, period, delay_4, developmentTools, tools, delay_5, gameProductionTeam, team));
    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator EndingStory(float t, Image i, Image j, Image k, Image l, TextMeshProUGUI m, TextMeshProUGUI d_1, TextMeshProUGUI o, TextMeshProUGUI p, TextMeshProUGUI q, TextMeshProUGUI d_2, TextMeshProUGUI r, TextMeshProUGUI s, TextMeshProUGUI u, TextMeshProUGUI v, TextMeshProUGUI w, TextMeshProUGUI x, TextMeshProUGUI d_3, TextMeshProUGUI y, TextMeshProUGUI z, TextMeshProUGUI d_4, TextMeshProUGUI a, TextMeshProUGUI b, TextMeshProUGUI d_5, TextMeshProUGUI c, TextMeshProUGUI d)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        j.color = new Color(j.color.r, j.color.g, j.color.b, 0);
        k.color = new Color(k.color.r, k.color.g, k.color.b, 0);
        l.color = new Color(l.color.r, l.color.g, l.color.b, 0);
        m.color = new Color(m.color.r, m.color.g, m.color.b, 0);
        d_1.color = new Color(d_1.color.r, d_1.color.g, d_1.color.b, 0);
        o.color = new Color(o.color.r, o.color.g, o.color.b, 0);
        p.color = new Color(p.color.r, p.color.g, p.color.b, 0);
        q.color = new Color(q.color.r, q.color.g, q.color.b, 0);
        d_2.color = new Color(d_2.color.r, d_2.color.g, d_2.color.b, 0);
        r.color = new Color(r.color.r, r.color.g, r.color.b, 0);
        s.color = new Color(s.color.r, s.color.g, s.color.b, 0);
        u.color = new Color(u.color.r, u.color.g, u.color.b, 0);
        v.color = new Color(v.color.r, v.color.g, v.color.b, 0);
        w.color = new Color(w.color.r, w.color.g, w.color.b, 0);
        x.color = new Color(x.color.r, x.color.g, x.color.b, 0);
        d_3.color = new Color(d_3.color.r, d_3.color.g, d_3.color.b, 0);
        y.color = new Color(y.color.r, y.color.g, y.color.b, 0);
        z.color = new Color(z.color.r, z.color.g, z.color.b, 0);
        d_4.color = new Color(d_4.color.r, d_4.color.g, d_4.color.b, 0);
        a.color = new Color(a.color.r, a.color.g, a.color.b, 0);
        b.color = new Color(b.color.r, b.color.g, b.color.b, 0);
        d_5.color = new Color(d_5.color.r, d_5.color.g, d_5.color.b, 0);
        c.color = new Color(c.color.r, c.color.g, c.color.b, 0);
        d.color = new Color(d.color.r, d.color.g, d.color.b, 0);


        // appear
        // txtEndingStory_1
        while (m.color.a < 1.0f)
        {
            m.color = new Color(m.color.r, m.color.g, m.color.b, m.color.a + (Time.deltaTime / 2.7f));
            yield return null;
        }

        // disappear 
        // txtEndingStory_1
        while (m.color.a > 0.0f)
        {
            m.color = new Color(m.color.r, m.color.g, m.color.b, m.color.a - (Time.deltaTime / 1.3f));
            yield return null;
        }


        // 중간에 딜레이 필요한 시간만큼 보이지 않는 폰트로 시간을 끄는 것으로 변경
        // 이유 : 해당 사항을 적용할 코드를 아직 만들지 못했음
       
        // appear
        // delay_1
        while (d_1.color.a < 1.0f)
        {
            d_1.color = new Color(d_1.color.r, d_1.color.g, d_1.color.b, d_1.color.a + (Time.deltaTime / 5f));
            yield return null;
        }

        // disappear 
        // delay_1
        while (d_1.color.a > 0.0f)
        {
            d_1.color = new Color(d_1.color.r, d_1.color.g, d_1.color.b, d_1.color.a - (Time.deltaTime / t));
            yield return null;
        }

        // appear
        // txtEndingStory_2
        while (o.color.a < 1.0f)
        {
            o.color = new Color(o.color.r, o.color.g, o.color.b, o.color.a + (Time.deltaTime / t));
            yield return null;
        }

        // disappear 
        // txtEndingStory_2
        while (o.color.a > 0.0f)
        {
            o.color = new Color(o.color.r, o.color.g, o.color.b, o.color.a - (Time.deltaTime / t));
            yield return null;
        }

        // appear
        // txtEndingStory_3
        while (p.color.a < 1.0f)
        {
            p.color = new Color(p.color.r, p.color.g, p.color.b, p.color.a + (Time.deltaTime / t));
            yield return null;
        }

        // disappear 
        // txtEndingStory_3
        while (p.color.a > 0.0f)
        {
            p.color = new Color(p.color.r, p.color.g, p.color.b, p.color.a - (Time.deltaTime / t));
            yield return null;
        }

        // 이미지 1~4까지 보여지고 사라지기 i, j, k, l
        // 1이 보여지고 사라지면서 2가 보이기 연속적으로 4까지 계속 보여지기 

        // appear
        // thief_1
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }

        // disappear 
        //thief_1
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }

        // appear
        // thief_1
        while (j.color.a < 1.0f)
        {
            j.color = new Color(j.color.r, j.color.g, j.color.b, j.color.a + (Time.deltaTime / t));
            yield return null;
        }

        // disappear 
        //thief_2
        while (j.color.a > 0.0f)
        {
            j.color = new Color(j.color.r, j.color.g, j.color.b, j.color.a - (Time.deltaTime / t));
            yield return null;
        }

        // appear
        // thief_3
        while (k.color.a < 1.0f)
        {
            k.color = new Color(k.color.r, k.color.g, k.color.b, k.color.a + (Time.deltaTime / t));
            yield return null;
        }

        // disappear 
        //thief_3
        while (k.color.a > 0.0f)
        {
            k.color = new Color(k.color.r, k.color.g, k.color.b, k.color.a - (Time.deltaTime / t));
            yield return null;
        }

        // appear
        // thief_4
        while (l.color.a < 1.0f)
        {
            l.color = new Color(l.color.r, l.color.g, l.color.b, l.color.a + (Time.deltaTime / t));
            yield return null;
        }

        // disappear 
        //thief_4
        while (l.color.a > 0.0f)
        {
            l.color = new Color(l.color.r, l.color.g, l.color.b, l.color.a - (Time.deltaTime / t));
            yield return null;
        }

        // appear
        // txtEndingStory_4
        while (q.color.a < 1.0f)
        {
            q.color = new Color(q.color.r, q.color.g, q.color.b, q.color.a + (Time.deltaTime / t));
            yield return null;
        }

        // disappear 
        // txtEndingStory_4
        while (q.color.a > 0.0f)
        {
            q.color = new Color(q.color.r, q.color.g, q.color.b, q.color.a - (Time.deltaTime / t));
            yield return null;
        }

        // appear
        // delay_2
        while (d_2.color.a < 1.0f)
        {
            d_2.color = new Color(d_2.color.r, d_2.color.g, d_2.color.b, d_2.color.a + (Time.deltaTime / 9f));
            yield return null;
        }

        // disappear 
        // delay_2
        while (d_2.color.a > 0.0f)
        {
            d_2.color = new Color(d_2.color.r, d_2.color.g, d_2.color.b, d_2.color.a - (Time.deltaTime / t));
            yield return null;
        }

        // Introduce
        // appear
        // txtIntroduce_1
        while (r.color.a < 1.0f)
        {
            r.color = new Color(r.color.r, r.color.g, r.color.b, r.color.a + (Time.deltaTime / t));
            yield return null;
        }

        //jongsuPark
        while (s.color.a < 1.0f)
        {
            s.color = new Color(s.color.r, s.color.g, s.color.b, s.color.a + (Time.deltaTime / t));
            yield return null;
        }

        //jooyeonLee
        while (u.color.a < 1.0f)
        {
            u.color = new Color(u.color.r, u.color.g, u.color.b, u.color.a + (Time.deltaTime / t));
            yield return null;
        }

        //seungyeonLee
        while (v.color.a < 1.0f)
        {
            v.color = new Color(v.color.r, v.color.g, v.color.b, v.color.a + (Time.deltaTime / t));
            yield return null;
        }

        //yuseopSong
        while (w.color.a < 1.0f)
        {
            w.color = new Color(w.color.r, w.color.g, w.color.b, w.color.a + (Time.deltaTime / t));
            yield return null;
        }

        //hanaChoi
        while (x.color.a < 1.0f)
        {
            x.color = new Color(x.color.r, x.color.g, x.color.b, x.color.a + (Time.deltaTime / t));
            yield return null;
        }

        // Introduce
        // disappear
        // txtIntroduce_1
        while (r.color.a > 0.0f)
        {
            r.color = new Color(r.color.r, r.color.g, r.color.b, r.color.a - (Time.deltaTime / t));
            yield return null;
        }

        //jongsuPark
        while (s.color.a > 0.0f)
        {
            s.color = new Color(s.color.r, s.color.g, s.color.b, s.color.a - (Time.deltaTime / t));
            yield return null;
        }

        //jooyeonLee
        while (u.color.a > 0.0f)
        {
            u.color = new Color(u.color.r, u.color.g, u.color.b, u.color.a - (Time.deltaTime / t));
            yield return null;
        }

        //seungyeonLee
        while (v.color.a > 0.0f)
        {
            v.color = new Color(v.color.r, v.color.g, v.color.b, v.color.a - (Time.deltaTime / t));
            yield return null;
        }

        //yuseopSong
        while (w.color.a > 0.0f)
        {
            w.color = new Color(w.color.r, w.color.g, w.color.b, w.color.a - (Time.deltaTime / t));
            yield return null;
        }

        //hanaChoi
        while (x.color.a > 0.0f)
        {
            x.color = new Color(x.color.r, x.color.g, x.color.b, x.color.a - (Time.deltaTime / t));
            yield return null;
        }

        // appear
        // developmentPeriod
        while (y.color.a < 1.0f)
        {
            y.color = new Color(y.color.r, y.color.g, y.color.b, y.color.a + (Time.deltaTime / t));
            yield return null;
        }

        // period
        while (z.color.a < 1.0f)
        {
            z.color = new Color(z.color.r, z.color.g, z.color.b, z.color.a + (Time.deltaTime / t));
            yield return null;
        }

        // appear
        // delay_3
        while (d_3.color.a < 1.0f)
        {
            d_3.color = new Color(d_3.color.r, d_3.color.g, d_3.color.b, d_3.color.a + (Time.deltaTime / 2f));
            yield return null;
        }

        // disappear 
        // delay_3
        while (d_3.color.a > 0.0f)
        {
            d_3.color = new Color(d_3.color.r, d_3.color.g, d_3.color.b, d_3.color.a - (Time.deltaTime / t));
            yield return null;
        }

        // disappear
        // developmentPeriod
        while (y.color.a > 0.0f)
        {
            y.color = new Color(y.color.r, y.color.g, y.color.b, y.color.a - (Time.deltaTime / t));
            yield return null;
        }

        // period
        while (z.color.a > 0.0f)
        {
            z.color = new Color(z.color.r, z.color.g, z.color.b, z.color.a - (Time.deltaTime / t));
            yield return null;
        }

        // appear
        // developmentTools
        while (a.color.a < 1.0f)
        {
            a.color = new Color(a.color.r, a.color.g, a.color.b, a.color.a + (Time.deltaTime / t));
            yield return null;
        }

        // tools
        while (b.color.a < 1.0f)
        {
            b.color = new Color(b.color.r, b.color.g, b.color.b, b.color.a + (Time.deltaTime / t));
            yield return null;
        }

        // appear
        // delay_4
        while (d_4.color.a < 1.0f)
        {
            d_4.color = new Color(d_4.color.r, d_4.color.g, d_4.color.b, d_4.color.a + (Time.deltaTime / 2f));
            yield return null;
        }

        // disappear 
        // delay_4
        while (d_4.color.a > 0.0f)
        {
            d_4.color = new Color(d_4.color.r, d_4.color.g, d_4.color.b, d_4.color.a - (Time.deltaTime / t));
            yield return null;
        }

        // disappear
        // developmentTools
        while (a.color.a > 0.0f)
        {
            a.color = new Color(a.color.r, a.color.g, a.color.b, a.color.a - (Time.deltaTime / t));
            yield return null;
        }

        // tools
        while (b.color.a > 0.0f)
        {
            b.color = new Color(b.color.r, b.color.g, b.color.b, b.color.a - (Time.deltaTime / t));
            yield return null;
        }

        // appear
        // gameProductionTeam
        while (c.color.a < 1.0f)
        {
            c.color = new Color(c.color.r, c.color.g, c.color.b, c.color.a + (Time.deltaTime / 3f));
            yield return null;
        }

        // team
        while (d.color.a < 1.0f)
        {
            d.color = new Color(d.color.r, d.color.g, d.color.b, d.color.a + (Time.deltaTime / 3f));
            yield return null;
        }

        // appear
        // delay_5
        while (d_5.color.a < 1.0f)
        {
            d_5.color = new Color(d_5.color.r, d_5.color.g, d_5.color.b, d_5.color.a + (Time.deltaTime / 2f));
            yield return null;
        }

        // disappear 
        // delay_5
        while (d_5.color.a > 0.0f)
        {
            d_5.color = new Color(d_5.color.r, d_5.color.g, d_5.color.b, d_5.color.a - (Time.deltaTime / 3f));
            yield return null;
        }

        // disappear
        // developmentTools
        while (c.color.a > 0.0f)
        {
            c.color = new Color(c.color.r, c.color.g, c.color.b, c.color.a - (Time.deltaTime / 3f));
            yield return null;
        }

        // Tools
        while (d.color.a > 0.0f)
        {
            d.color = new Color(d.color.r, d.color.g, d.color.b, d.color.a - (Time.deltaTime / t));
            yield return null;
        }
    }
}

