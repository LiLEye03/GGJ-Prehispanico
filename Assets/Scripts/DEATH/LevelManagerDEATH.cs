using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerDEATH : MonoBehaviour
{
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 5;
        GameManager.Instance.CallGameObjects();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1 * Time.deltaTime;

        if (timer <= 0){
            LvlCompleteDEATH();
            timer = 0;
        }

        print(timer);
    }
    public void LvlCompleteDEATH(){
        LvlCompleteChecker.CompleteGODS = true;
        PanelManager.Instance.ReturnToMenuDEATH();
    }
}