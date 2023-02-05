using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelManagerCACAO : MonoBehaviour
{
    public TextMeshProUGUI lives;
    public int vidas=3;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LosseHealt()
    {
        vidas--;
        lives.text = vidas.ToString();
        if (vidas<=0){
            GameManager.Instance.LvlCompletedCACAO();
        }
    }

    public void LvlCompleteCACAO(){
        GameManager.Instance.LvlCompletedCACAO();
    }
}
