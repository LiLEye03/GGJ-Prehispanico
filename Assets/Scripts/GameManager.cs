using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static string gameStat;
    public static string miniGameStat;
    [SerializeField] GameObject miniGamePanel, godsPanel, deathPanel, cacaoPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(miniGameStat){

            case "GODS":
                miniGamePanel.SetActive(true);
                godsPanel.SetActive(true);
                cacaoPanel.SetActive(false);
                deathPanel.SetActive(false);
                break;
            
            case "CACAO":
                miniGamePanel.SetActive(true);
                godsPanel.SetActive(false);
                cacaoPanel.SetActive(true);
                deathPanel.SetActive(false);
                break;

            case "DEATH":
                miniGamePanel.SetActive(true);
                godsPanel.SetActive(false);
                cacaoPanel.SetActive(false);
                deathPanel.SetActive(true);
                break;
        }

    }
}
