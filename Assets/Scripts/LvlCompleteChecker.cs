using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlCompleteChecker : MonoBehaviour
{
    public static LvlCompleteChecker Instance {get; private set;}
    void Awake()
    {
        if (Instance == null){
            Instance = this;
        } else {
            Debug.Log("Más de un LvlCompleteChecker en escena!");
        }
    }
    public static bool CompleteGODS, CompleteDEATH, CompleteCACAO;
}
