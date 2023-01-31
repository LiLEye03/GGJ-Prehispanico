using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class ControllerDayCicle : MonoBehaviour
{
    [SerializeField]
    Light2D globalLight;

    [SerializeField]
    DayCicle[] cicleDay;

    [SerializeField]
    float timePerCicle;

    float actualTime = 0;
    float percentCicle;

    int actualCicle;
    int nextCicle;
    void Start()
    {
        globalLight.color = cicleDay[0].colorCicle;
    }

    // Update is called once per frame
    void Update()
    {
        actualTime += Time.deltaTime;
        percentCicle = actualTime / timePerCicle;

        if(actualTime >= timePerCicle)
        {
            actualTime = 0;

            actualCicle = nextCicle;

            if(nextCicle + 1 > cicleDay.Length - 1)
            {
                nextCicle = 0;
            }
            else
            {
                nextCicle += 1;
            }
        }

        changeColor(cicleDay[actualCicle].colorCicle, cicleDay[nextCicle].colorCicle);
    }

    private void changeColor(Color actual, Color nextColor)
    {
        globalLight.color = Color.Lerp(actual, nextColor, percentCicle);
    }
}
