using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (GameManager.CompleteCACAO == true && GameManager.CompleteDEATH == true && GameManager.CompleteGODS == true){
            GameManager.Instance.GameCompleted();
        }
    }
}
