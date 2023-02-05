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
        if (vidas>=1)
        {
        vidas--;
        lives.text = vidas.ToString();
        }
        if (vidas<=0){
            print("HAS PERDIDO EL JUEGO");
        }
    }

    public void LvlCompleteCACAO(){
        GameManager.Instance.LvlCompletedCACAO();
    }
}
