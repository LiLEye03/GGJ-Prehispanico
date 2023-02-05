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
    [SerializeField] bool CompleteGODS, CompleteDEATH, CompleteCACAO, GameStarted;
    //                          Paneles Generales
    [SerializeField] GameObject MenuPanel, CreditsPanel, PausePanel, MinigamePanel, LvlCompletePanel, PanelPantallaCarga, SureExitPanel, GameOverPanel;
    //                        Contenido Paneles: Contenido Panel Minigame | contenido LvlCompletado | Contenido Pantalla de Carga
    [SerializeField] GameObject ContentGODS, ContentGODSCarga,  ContentDEATH, ContentDEATHCarga, ContentCACAO, ContentCACAOCarga, checkmark;
    [SerializeField] string GameStat, SceneLoaded;

    //Estados de Juego
    private void DisableAllPanels(){
        PausePanel.SetActive(false);
        MinigamePanel.SetActive(false);
        ContentGODS.SetActive(false);
        ContentDEATH.SetActive(false);
        ContentCACAO.SetActive(false);
        LvlCompletePanel.SetActive(false);
        PanelPantallaCarga.SetActive(false);
        ContentGODSCarga.SetActive(false);
        ContentDEATHCarga.SetActive(false);
        ContentCACAOCarga.SetActive(false);
        SureExitPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        MenuPanel.SetActive(false);
        checkmark.SetActive(false);
        GameOverPanel.SetActive(false);
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
        MenuPanel.SetActive(true);
    }
    //debug  patas  Atte: Randy
    void Update()
    {
        //Controlador Boton Pausa
        if (Input.GetKeyDown(KeyCode.Escape) && GameStat == "InGame")
        {
            GameStat = "InPause";
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && GameStat == "InPause")
        {
            GameStat = "InGame";
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && GameStat == "InMenu")
        {
            GameStat = "InMenu";
        }

        //Control de Estados de Juego (Tener mayor control de las escenas)

        if (SceneLoaded == "PLAZA"){
            LvlCompletePanel.SetActive(false);
            Time.timeScale = 1;
        }

        switch(GameStat){
            case "InGame":
            PausePanel.SetActive(false);
            SureExitPanel.SetActive(false);
            GameOverPanel.SetActive(false);
            Time.timeScale = 1;
            break;

            case "InPause":
            PausePanel.SetActive(true);
            Time.timeScale = 0;
            break;

            case "InMenu":
            DisableAllPanels();
            MenuPanel.SetActive(true);
            Time.timeScale = 1;
            break;

            case "InCredits":
            CreditsPanel.SetActive(true);
            MenuPanel.SetActive(false);
            break;

            case "InLoadingPanel":
            Time.timeScale = 0;
            break;
        }
    }

    //Estados de Juego
    public void Menu(){
        GameStat = "InMenu";
        DisableAllPanels();
        SceneManager.LoadScene("MENU");
        MenuPanel.SetActive(true);
    }

    public void StartGame(){
        GameStat = "InGame";
        DisableAllPanels();
        SceneManager.LoadScene("PLAZA");
    }

    public void Pause(){
        if (GameStat == "InPause"){
            GameStat = "InGame";
        } else if (GameStat == "InGame"){
            GameStat = "InPause";
        }
    }

    //Cierra los paneles en general
    public void ClosePanel(){
        if (GameStat == "InCredits"){
            GameStat = "InMenu";
        } else {
        DisableAllPanels();
        }
    }
    //Abre el panel de creditos en el menu
    public void Creditos(){
        GameStat = "InCredits";
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
        if (CompleteGODS == true){
            checkmark.SetActive(true);
        }
    }
    //Te envía a la escena
    public void SceneGODS(){
        DisableAllPanels();
        SceneManager.LoadScene("GODS");
        GameOverPanel.SetActive(false);
        GameStat = "InLoadingPanel";
        PanelPantallaCarga.SetActive(true);
        ContentGODSCarga.SetActive(true);
    }
    //Se ejecuta cuando el nivel ha sido completado
    public void LvlCompletedGODS(){
        DisableAllPanels();
        Time.timeScale = 0;
        LvlCompletePanel.SetActive(true);
        CompleteGODS = true;
        print("Haz completado el nivel 'GODS'");
    }
    //Elimina los datos de juego
    public void ClearLvlGODS(){
        CompleteGODS = false;
        print("Se ha reiniciado el nivel 'GODS'");
    }
    public void GameOverGODS(){
        DisableAllPanels();
        GameOverPanel.SetActive(true);
    }

    //DEATH
    //Muestra en el panel la sinopsis del minijuego
    public void DEATH(){
        DisableAllPanels();
        MinigamePanel.SetActive(true);
        ContentDEATH.SetActive(true);
        if (CompleteDEATH == true){
            checkmark.SetActive(true);
        }
    }
    //Te envía a la escena
    public void SceneDEATH(){
        DisableAllPanels();
        SceneManager.LoadScene("DEATH");
        GameStat = "InLoadingPanel";
        PanelPantallaCarga.SetActive(true);
        ContentDEATHCarga.SetActive(true);
    }
    //Se ejecuta cuando el nivel ha sido completado
    public void LvlCompletedDEATH(){
        DisableAllPanels();
        Time.timeScale = 0;
        LvlCompletePanel.SetActive(true);
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
        if (CompleteCACAO == true){
            checkmark.SetActive(true);
        }
    }
    //Te envía a la escena
    public void SceneCACAO(){
        DisableAllPanels();
        SceneManager.LoadScene("CACAO");
        GameStat = "InLoadingPanel";
        PanelPantallaCarga.SetActive(true);
        ContentCACAOCarga.SetActive(true);
    }
    //Desactiva la pantalla de carga e inicia el nivel
    public void StartMinigame(){
        DisableAllPanels();
        GameStat = "InGame";
    }
    //Se ejecuta cuando el nivel ha sido completado
    public void LvlCompletedCACAO(){
        CompleteCACAO = true;
        DisableAllPanels();
        Time.timeScale = 0;
        LvlCompletePanel.SetActive(true);
        print("Haz completado el nivel 'CACAO'");
    }
    //Después de completar el nivel te envía de regreso a la plaza
    public void ReturnToPlaza(){
        SceneLoaded = "PLAZA";
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

    // //Sistema de Lenguage

    // public void ChangeLanguage(){
    //     if (LanguageManager.Language == "Spanish - ES"){
    //         LanguageManager.Language = "English - EN";
    //     } else if (LanguageManager.Language == "English - EN"){
    //         LanguageManager.Language = "Spanish - ES";
    //     }
    // }

}