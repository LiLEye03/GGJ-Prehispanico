using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerCACAO : MonoBehaviour
{
    GameManager Manager;
    // Start is called before the first frame update
    void Start()
    {
        Manager.CallGameObjects();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LvlCompleteCACAO(){
        GameManager.LvlComplete = "CACAO";
    }
}
