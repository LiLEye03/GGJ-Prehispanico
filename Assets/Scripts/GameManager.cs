using System.Dynamic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    //  Booleanos:     Revisa si los Minijuegos fueron completados || Revisa si el Juego fue Iniciado
    [SerializeField] bool CompleteGODS, CompleteDEATH, CompleteCACAO, GameStarted, GamePaused;
    //                          Paneles Generales
    [SerializeField] GameObject MenuPanel, CreditsPanel, PausePanel, MinigamePanel, LvlCompletePanel, PanelPantallaCarga, SureExitPanel;
    //                        Contenido Paneles: Contenido Panel Minigame | contenido LvlCompletado | Contenido Pantalla de Carga
    [SerializeField] GameObject ContentGODS, WinGODS, ContentGODSCarga,  ContentDEATH, WinDEATH, ContentDEATHCarga, ContentCACAO, WinCACAO, ContentCACAOCarga;
    [SerializeField] string GameStat;

    //Estados de Juego
    private void DisableAllPanels(){
        PausePanel.SetActive(false);
        MinigamePanel.SetActive(false);
        ContentGODS.SetActive(false);
        ContentDEATH.SetActive(false);
        ContentCACAO.SetActive(false);
        WinGODS.SetActive(false);
        WinDEATH.SetActive(false);
        WinCACAO.SetActive(false);
        LvlCompletePanel.SetActive(false);
        PanelPantallaCarga.SetActive(false);
        ContentGODSCarga.SetActive(false);
        ContentDEATHCarga.SetActive(false);
        ContentCACAOCarga.SetActive(false);
        SureExitPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        MenuPanel.SetActive(false);
    }


    void Awake()
    {
        if (GameManager.Instance == null){
            GameManager.Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        Menu();
    }
    //debug  patas  Atte: Randy
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            Pause();
        }

        //Control de Estados de Juego (Tener mayor control de las escenas)

        if (GameStat == "OnPLAZA"){
            LvlCompletePanel.SetActive(false);
            Time.timeScale = 1;
        } 
    }

    //Estados de Juego
    public void Menu(){
        GameStat = "Menu";
        DisableAllPanels();
        SceneManager.LoadScene("MENU");
        MenuPanel.SetActive(true);
    }

    public void StartGame(){
        GameStat = "Game";
        DisableAllPanels();
        SceneManager.LoadScene("PLAZA");
    }

    public void Pause(){
        if (GamePaused == false){
            DisableAllPanels();
            PausePanel.SetActive(true);
            Time.timeScale = 0;
        } else {
            DisableAllPanels();
            PausePanel.SetActive(false);
            Time.timeScale = 1;
        }
    }
    //Cierra los paneles en general
    public void ClosePanel(){
        if (GameStat == "Menu"){
            DisableAllPanels();
            MenuPanel.SetActive(true);
        } else {
        DisableAllPanels();
        }
    }
    //Abre el panel de creditos en el menu
    public void Creditos(){
        DisableAllPanels();
        CreditsPanel.SetActive(true);
    }
    //Pegunta si quieres salir del minijuego para ir al menu
    public void SureExit(){
        DisableAllPanels();
        SureExitPanel.SetActive(true);
    }

    //Paneles y Estados
    //GODS
    //Muestra en el panel la sinopsis del minijuego
    public void GODS(){
        DisableAllPanels();
        MinigamePanel.SetActive(true);
        ContentGODS.SetActive(true);
    }
    //Te envía a la escena
    public void SceneGODS(){
        DisableAllPanels();
        SceneManager.LoadScene("GODS");
        PanelPantallaCarga.SetActive(true);
        ContentGODSCarga.SetActive(true);
        Time.timeScale = 0;
    }
    //Se ejecuta cuando el nivel ha sido completado
    public void LvlCompletedGODS(){
        DisableAllPanels();
        Time.timeScale = 0;
        LvlCompletePanel.SetActive(true);
        WinGODS.SetActive(true);
        CompleteGODS = true;
        print("Haz completado el nivel 'GODS'");
    }
    //Elimina los datos de juego
    public void ClearLvlGODS(){
        CompleteGODS = false;
        print("Se ha reiniciado el nivel 'GODS'");
    }

    //DEATH
    //Muestra en el panel la sinopsis del minijuego
    public void DEATH(){
        DisableAllPanels();
        MinigamePanel.SetActive(true);
        ContentDEATH.SetActive(true);
    }
    //Te envía a la escena
    public void SceneDEATH(){
        DisableAllPanels();
        SceneManager.LoadScene("DEATH");
        PanelPantallaCarga.SetActive(true);
        ContentDEATHCarga.SetActive(true);
        Time.timeScale = 0;
    }
    //Se ejecuta cuando el nivel ha sido completado
    public void LvlCompletedDEATH(){
        DisableAllPanels();
        Time.timeScale = 0;
        LvlCompletePanel.SetActive(true);
        WinDEATH.SetActive(true);
        CompleteDEATH = true;
        print("Haz completado el nivel 'DEATH'");
    }
    //Elimina los datos de juego
    public void ClearLvlDEATH(){
        CompleteDEATH = false;
        print("Se ha reiniciado el nivel 'DEATH'");
    }

    //CACAO
    //Muestra en el panel la sinopsis del minijuego
    public void CACAO(){
        DisableAllPanels();
        MinigamePanel.SetActive(true);
        ContentCACAO.SetActive(true);
    }
    //Te envía a la escena
    public void SceneCACAO(){
        DisableAllPanels();
        SceneManager.LoadScene("CACAO");
        PanelPantallaCarga.SetActive(true);
        ContentCACAOCarga.SetActive(true);
        Time.timeScale = 0;
    }
    //Desactiva la pantalla de carga e inicia el nivel
    public void StartMinigame(){
        DisableAllPanels();
        Time.timeScale = 1;
    }
    //Se ejecuta cuando el nivel ha sido completado
    public void LvlCompletedCACAO(){
        CompleteCACAO = true;
        DisableAllPanels();
        Time.timeScale = 0;
        LvlCompletePanel.SetActive(true);
        WinCACAO.SetActive(true);
        print("Haz completado el nivel 'CACAO'");
    }
    //Después de completar el nivel te envía de regreso a la plaza
    public void ReturnToPlaza(){
        GameStat = "OnPLAZA";
        SceneManager.LoadScene("PLAZA");
    }
    //Elimina los datos de juego
    public void ClearLvlCACAO(){
        CompleteCACAO = false;
        print("Se ha reiniciado el nivel 'CACAO'");
    }
    //Elimina los datos de juego en general - Recomendable ejecutar en el Start del Script o al presionar el botón de START
    public void ClearAllLvls(){
        ClearLvlGODS();
        ClearLvlDEATH();
        ClearLvlCACAO();
    }

    //Sistema de Lenguage

    public void ChangeLanguage(){
        if (LanguageManager.Language == "Spanish - ES"){
            LanguageManager.Language = "English - EN";
        } else if (LanguageManager.Language == "English - EN"){
            LanguageManager.Language = "Spanish - ES";
        }
    }

}