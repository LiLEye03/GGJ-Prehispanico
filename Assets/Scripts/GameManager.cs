using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static string gameStat, miniGameStat, LvlComplete;

    //GameObjects miniGames
    [SerializeField] GameObject miniGamePanel, godsPanel, deathPanel, cacaoPanel, LvlCompletePanel, LvlCompleteGODS, LvlCompleteDEATH, LvlCompleteCACAO;
    //GameObjects miniGames EXTRAS
    [SerializeField] GameObject checkMarkGODS, checkMarkDEATH, checkMarkCACAO;
    //GameObjects GameStats
    [SerializeField] GameObject PausePanel, MenuPanel;

    public static bool godsBool, deathBool, cacaoBool, GameStarted;
    // Start is called before the first frame update
    void Start(){

        miniGameStat = "DEFAULT";

        if (GameStarted == false){
            gameStat = "MENU";
        }

        //Refeencias Jerarquía
        miniGamePanel = GameObject.Find("miniGamePanel");
        godsPanel = GameObject.Find("GODS Panel (Minigame)");
        deathPanel = GameObject.Find("DEATH Panel (Minigame)");
        cacaoPanel = GameObject.Find("CACAO Panel (Minigame)");
        LvlCompletePanel = GameObject.Find("Lvl Complete Panel");
        LvlCompleteGODS = GameObject.Find("Lvl Complete GODS");
        LvlCompleteDEATH = GameObject.Find("Lvl Complete DEATH");
        LvlCompleteCACAO = GameObject.Find("Lvl Complete CACAO");
        checkMarkGODS = GameObject.Find("Check Mark GODS");
        checkMarkDEATH = GameObject.Find("Check Mark DEATH");
        checkMarkCACAO = GameObject.Find("Check Mark CACAO");
        PausePanel = GameObject.Find("Pause Panel");
        MenuPanel = GameObject.Find("Menu Panel");
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
            LvlComplete = "DEFAULT";
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
            LvlCompleteGODS.SetActive(true);
            LvlCompleteCACAO.SetActive(false);
            LvlCompleteDEATH.SetActive(false);
            break;

            case "DEATH":
            LvlCompletePanel.SetActive(true);
            LvlCompleteGODS.SetActive(false);
            LvlCompleteCACAO.SetActive(false);
            LvlCompleteDEATH.SetActive(true);
            break;

            case "CACAO":
            LvlCompletePanel.SetActive(true);
            LvlCompleteGODS.SetActive(false);
            LvlCompleteCACAO.SetActive(true);
            LvlCompleteDEATH.SetActive(false);
            break;

            case "DEFAULT":
            LvlCompletePanel.SetActive(false);
            LvlCompleteGODS.SetActive(false);
            LvlCompleteCACAO.SetActive(false);
            LvlCompleteDEATH.SetActive(false);
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
        LvlComplete = "DEFAULT";
        SceneManager.LoadScene("PLAZA");
    }


    //MiniJuego DEATH

    public void deathScene(){
        SceneManager.LoadScene("DEATH");
    }
    public void GoToMenuDEATH(){
        GameManager.deathBool = true;
        LvlComplete = "DEFAULT";        
        SceneManager.LoadScene("PLAZA");
    }

    //MiniJuego CACAO

    public void cacaoScene(){
        SceneManager.LoadScene("CACAO");
    }    
    public void GoToMenuCACAO(){
        GameManager.cacaoBool = true;
        LvlComplete = "DEFAULT";        
        SceneManager.LoadScene("PLAZA");
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
