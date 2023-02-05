using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerGods : MonoBehaviour
{
    LevelManagerGODS Manager;
    [SerializeField]
    float timer = 0;

    [SerializeField]
    TextMeshProUGUI textTimer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - 1 * Time.deltaTime;

        textTimer.text = timer.ToString("f1");

        if(timer <= 0)
        {
            timer = 0;
            GameManager.Instance.LvlCompletedGODS();
        }
    }
}
