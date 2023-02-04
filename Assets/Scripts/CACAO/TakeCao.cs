using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TakeCao : MonoBehaviour
{
    public TextMeshProUGUI score;
    public int caoCoin;

    void Start()
    {
        //score = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        score.text = caoCoin.ToString();
    }

    public void AgarrarCacao()
    {
        caoCoin+=10;
    }

    public void TirarCacao()
    {
        if (caoCoin>=10)
        {
            caoCoin=caoCoin-10;
        }
    }
}
