using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BossIntroTalkingData : MonoBehaviour
{
    Dictionary<int, string[]> talkData;

    private void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        GenerateData();
    }

    void GenerateData()
    {
        talkData.Add(0, new string[]
            {
                "용케 여기까지 왔구나?",
                "네 노력은 인정해.",
                "물론 그것과 네 도둑질은 별개지.",
                "음..",
            });
    }

    public string GetTalk(int id, int talkIndex)
    {
        if (talkIndex == talkData[id].Length)
        {
            return null;
        }

        else
        {
            return talkData[id][talkIndex];
        }
    }
}

/*
public TextMeshProUGUI panelText;
    public GameObject panelObject;

    private void Update()
    {
        ShowData(panelObject);
    }

    public void ShowData(GameObject panelObj)
    {
        panelObject = panelObj;
        panelText.text = "안녕";
    }
 */
