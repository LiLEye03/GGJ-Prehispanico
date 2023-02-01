using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static string gameStat, miniGameStat, LvlComplete;

    //GameObjects miniGames
    [SerializeField] GameObject miniGamePanel, godsPanel, deathPanel, cacaoPanel, checkMarkGODS, checkMarkDEATH, checkMarkCACAO, LvlCompletePanel;
    //GameObjects GameStats
    [SerializeField] GameObject PausePanel, MenuPanel;

    public static bool godsBool, deathBool, cacaoBool, GameStarted;
    // Start is called before the first frame update
    void Start(){

        miniGameStat = "DEFAULT";

        if (GameStarted == false){
            gameStat = "MENU";
        }
    }

    // Update is called once per frame
    void Update(){

        //Estados de Juego
        switch(gameStat){
            case "ONPAUSE":
            PausePanel.SetActive(true);
            Time.timeScale = 0;
            break;

            case "STARTGAME":
            GameStarted = true;
            MenuPanel.SetActive(false);
            PausePanel.SetActive(false);
            //Las 3 siguientes lineas de codigo reinician los minijuegos 
            godsBool = false;
            deathBool = false;
            cacaoBool = false;
            break;

            case "RESUMEGAME":
            PausePanel.SetActive(false);
            break;

            case "MENU":
            PausePanel.SetActive(false);
            MenuPanel.SetActive(true);
            GameStarted = false;
            break;
        }
        
        //Paneles de MiniJuegos
        switch(miniGameStat){

            case "GODS":
                miniGamePanel.SetActive(true);
                godsPanel.SetActive(true);
                cacaoPanel.SetActive(false);
                deathPanel.SetActive(false);
                if (godsBool == true){
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
                if (cacaoBool == true){
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
                if (deathBool == true){
                    checkMarkDEATH.SetActive(true);
                } else {
                    checkMarkDEATH.SetActive(false);
                }
                break;
            
            case "DEFAULT":
                miniGamePanel.SetActive(false);
                break;
        }

        //Pantalla Nivel Completado

        switch(LvlComplete){
            case "GODS":
            LvlCompletePanel.SetActive(true);
            break;

            case "DEATH":
            LvlCompletePanel.SetActive(true);
            break;

            case "CACAO":
            LvlCompletePanel.SetActive(true);
            break;

            case "DEFAULT":
            LvlCompletePanel.SetActive(false);
            break;
        }

    }

    //MiniJuegos
    public void closePanels(){
        miniGameStat = "DEFAULT";
    }

    //MiniJuego GODS
    public void godsScene(){
        SceneManager.LoadScene("GODS");
    }
    public void GoToMenuGODS(){
        GameManager.godsBool = true;
        SceneManager.LoadScene("PLAZA");
        LvlComplete = "DEFAULT";
    }


    //MiniJuego DEATH

    public void deathScene(){
        SceneManager.LoadScene("DEATH");
    }
    public void GoToMenuDEATH(){
        GameManager.deathBool = true;
        SceneManager.LoadScene("PLAZA");
        LvlComplete = "DEFAULT";
    }

    //MiniJuego CACAO

    public void cacaoScene(){
        SceneManager.LoadScene("CACAO");
    }    
    public void GoToMenuCACAO(){
        GameManager.cacaoBool = true;
        SceneManager.LoadScene("PLAZA");
        LvlComplete = "DEFAULT";
    }


    //Estados de Juego


    //Menu de Pausa
    public void PauseGame(){
        if (gameStat == "PAUSEGAME"){
            gameStat = "RESUMEGAME";
        } else {
            gameStat = "PAUSEGAME";
        }
    }


    //Botones HUD OnGame
    public void GoToMenu(){
        SceneManager.LoadScene("PLAZA");
    }

    //Menu de Incio

    public void StartGame(){
        gameStat = "STARTGAME";
    }

}
