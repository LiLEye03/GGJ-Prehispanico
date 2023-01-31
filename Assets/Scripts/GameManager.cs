using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static string gameStat;
    public static string miniGameStat;
    //GameObjects miniGames
    [SerializeField] GameObject miniGamePanel, godsPanel, deathPanel, cacaoPanel, checkMarkGODS, checkMarkDEATH, checkMarkCACAO;
    //GameObjects GameStats
    [SerializeField] GameObject PausePanel, MenuPanel, GamePanel;
    // Start is called before the first frame update
    void Start(){

        miniGameStat = "DEFAULT";
    }

    // Update is called once per frame
    void Update(){

        //Estados de Juego
        switch(gameStat){
            case "PAUSEGAME":
            PausePanel.SetActive(true);
            GamePanel.SetActive(false);
            Time.timeScale = 0;
            break;

            case "STARTGAME":
            SaveBoolean.godsBool = false;
            SaveBoolean.deathBool = false;
            SaveBoolean.cacaoBool = false;
            break;

            case "RESUMEGAME":
            PausePanel.SetActive(false);
            GamePanel.SetActive(true);
            break;
        }
        
        //Paneles de miniJuegos
        switch(miniGameStat){

            case "GODS":
                miniGamePanel.SetActive(true);
                godsPanel.SetActive(true);
                cacaoPanel.SetActive(false);
                deathPanel.SetActive(false);
                if (SaveBoolean.godsBool == true){
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
                if (SaveBoolean.cacaoBool == true){
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
                if (SaveBoolean.deathBool == true){
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

    //MiniJuegos
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


    //Estados de Juego

    public void PauseGame(){
        if (gameStat == "PAUSEGAME"){
            gameStat = "RESUMEGAME";
        } else {
            gameStat = "PAUSEGAME";
        }
    }

    public void GoToMenu(){
        SceneManager.LoadScene("Menu");
    }

}
