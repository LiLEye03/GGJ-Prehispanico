using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static string gameStat;
    public static string miniGameStat;
    [SerializeField] GameObject miniGamePanel, godsPanel, deathPanel, cacaoPanel, checkMarkGODS, checkMarkDEATH, checkMarkCACAO;
    // Start is called before the first frame update
    void Start()
    {
        miniGameStat = "DEFAULT";
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
                if (LevelBoolean.godsBool == true){
                    checkMarkGODS.SetActive(true);
                } else { 
                    checkMarkGODS.SetActive(false);
                }
                break;
            
            case "CACAO":
                miniGamePanel.SetActive(true);
                godsPanel.SetActive(false);
                cacaoPanel.SetActive(true);
                deathPanel.SetActive(false);
                if (LevelBoolean.cacaoBool == true){
                    checkMarkCACAO.SetActive(true);
                } else {
                    checkMarkCACAO.SetActive(false);
                }
                break;

            case "DEATH":
                miniGamePanel.SetActive(true);
                godsPanel.SetActive(false);
                cacaoPanel.SetActive(false);
                deathPanel.SetActive(true);
                if (LevelBoolean.deathBool == true){
                    checkMarkDEATH.SetActive(true);
                } else {
                    checkMarkDEATH.SetActive(false);
                }
                break;
            
            case "DEFAULT":
                miniGamePanel.SetActive(false);
                break;
        }

    }

    public void godsScene(){
        SceneManager.LoadScene("GODS");
    }

    public void deathScene(){
        SceneManager.LoadScene("DEATH");
    }

    public void cacaoScene(){
        SceneManager.LoadScene("CACAO");
    }

    public void closePanels(){
        miniGameStat = "DEFAULT";
    }

}
