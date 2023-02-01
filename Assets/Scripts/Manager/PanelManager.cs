using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelManager : MonoBehaviour
{
    public static string Scene;
    [SerializeField] string EscenaActual;
    public static bool GameStarted, GamePaused;

    [SerializeField] GameObject MenuPanel, PausePanel, MinigamePanel, LvlCompletePanel;
    [SerializeField] GameObject ContentGODS, ContentDEATH, ContentCACAO;

    public static PanelManager Instance {get; private set;}

    void Awake()
    {
        if (Instance == null){
            Instance = this;
        } else {
            Debug.Log("Más de un PanelManager en escena!");
        }
    }

    void Start()
    {
        if (GameStarted == false){
            SceneManager.LoadScene("PLAZA");
            MenuPanel.SetActive(true);
            PausePanel.SetActive(false);
            MinigamePanel.SetActive(false);
            LvlCompletePanel.SetActive(false);
        } 
    }

    void Update()
    {
        switch(Scene){
            case "PLAZA":
            if (GameStarted == true){
                MenuPanel.SetActive(false);
            }
            LvlCompletePanel.SetActive(false);
            
            break;
        }

        //Control de Escenas
        EscenaActual = Scene;

    }

    //GODS
    public void OpenContentGODS(){
        MinigamePanel.SetActive(true);
        ContentGODS.SetActive(true);
        ContentDEATH.SetActive(false);
        ContentCACAO.SetActive(false);
    }

    public void OpenSceneGODS(){
        MinigamePanel.SetActive(false);
    }

    public void ReturnToMenuGODS(){
        LvlCompleteChecker.CompleteGODS = true;
    }
    //DEATH
    public void OpenContentDEATH(){
        MinigamePanel.SetActive(true);
        ContentGODS.SetActive(false);
        ContentDEATH.SetActive(true);
        ContentCACAO.SetActive(false);
    }

    public void OpenSceneDEATH(){
        MinigamePanel.SetActive(false);
    }

    public void ReturnToMenuDEATH(){
        LvlCompleteChecker.CompleteDEATH = true;
    }
    //CACAO
    public void OpenContentCACAO(){
        MinigamePanel.SetActive(true);
        ContentGODS.SetActive(false);
        ContentDEATH.SetActive(false);
        ContentCACAO.SetActive(true);
    }

    public void OpenSceneCACAO(){
        MinigamePanel.SetActive(false);
    }

    public void ReturnToMenuCACAO(){
        LvlCompleteChecker.CompleteCACAO = true;
    }
    //Close Panel
    public void ClosePanel(){
        MinigamePanel.SetActive(false);
    }
    //Game Stats
    public void StartGame(){
        GameStarted = true;
    }

    public void Pause(){
        if (GamePaused == true){
        MinigamePanel.SetActive(false);
        PausePanel.SetActive(true);
        Time.timeScale = 0;
        } else {
            PausePanel.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void ReturnToMenu(){
        SceneManager.LoadScene("MENU");
    }


}
