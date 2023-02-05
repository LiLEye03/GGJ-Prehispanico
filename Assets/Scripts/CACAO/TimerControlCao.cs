using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerControlCao : MonoBehaviour
{
    [SerializeField]int min, seg;
    [SerializeField]Text tiempo;
    private float rest;
    private bool mark;
    
    private void Awake()
    {
        rest = (min*60)+seg;
        mark = true;
    }

    void Update()
    {
        if (mark)
        {
            rest -=Time.deltaTime;
            if (rest<1)
            {
                mark = false;
                print ("Se acabo el tiempo");
            }
            int tempMin = Mathf.FloorToInt(rest/60);
            int tempSeg = Mathf.FloorToInt(rest%60);
            tiempo.text = string.Format("{00:00}:{01:00}",tempMin,tempSeg);
        }
    }
}
