using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakeCao : MonoBehaviour
{
    public Text score;
    public int caoCoin;

    void Start()
    {
        
    }

    void Update()
    {
        score.text = caoCoin.ToString();

    }

    public void AgarrarCacao()
    {
        caoCoin+=1;
    }
}
