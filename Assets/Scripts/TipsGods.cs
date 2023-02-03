using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TipsGods : MonoBehaviour
{
    public TextMeshProUGUI text;
    public string[] tips;
    int tipsCount;
    void Start()
    {
        GenerateTips();
    }

    public void GenerateTips()
    {
        tipsCount = Random.Range(0, tips.Length);

        text.text = "¿Sabias que? " + tips[tipsCount].ToString();
    }
}
