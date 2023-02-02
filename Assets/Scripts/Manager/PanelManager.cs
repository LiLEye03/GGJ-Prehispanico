using System.Dynamic;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelManager : MonoBehaviour
{
    public static bool GameStarted, GamePaused;

    [SerializeField] GameObject PausePanel, MinigamePanel, LvlCompletePanel, PanelPantallaCarga, SureExitPanel, CreditsPanel, MenuPanel;
    [SerializeField] GameObject ContentGODS, ContentDEATH, ContentCACAO, CargaGODS, CargaDEATH, CargaCACAO;

    public static PanelManager instance;

    void Awake()
    {
        if (PanelManager.instance == null){
            PanelManager.instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
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
        SceneManager.LoadScene("GODS");
    }

    public void ReturnToPlazaGODS(){
        Stats.CompleteGODS = true;
        SceneManager.LoadScene("PLAZA");
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
        SceneManager.LoadScene("DEATH");
    }

    public void ReturnToPlazaDEATH(){
        Stats.CompleteDEATH = true;
        SceneManager.LoadScene("PLAZA");
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
        SceneManager.LoadScene("CACAO");
    }

    public void ReturnToPlazaCACAO(){
        Stats.CompleteCACAO = true;
        SceneManager.LoadScene("PLAZA");
    }
    //Close Panel
    public void ClosePanel(){
        MinigamePanel.SetActive(false);
    }
    //Game Stats
    public void StartGame(){
        SceneManager.LoadScene("PLAZA");
        MenuPanel.SetActive(false);
    }

    public void Pause(){
        if (GamePaused == true){
        MinigamePanel.SetActive(false);
        PausePanel.SetActive(true);
        Time.timeScale = 0;
        } else if (GamePaused == false){
            PausePanel.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void SureExit(){
        SureExitPanel.SetActive(true);
    }

    public void closeSureExit(){
        SureExitPanel.SetActive(false);
    }

    public void ReturnToMenu(){
        SceneManager.LoadScene("MENU");
    }

    public void Credits(){
        CreditsPanel.SetActive(true);
    }

    public void CloseCredits(){
        CreditsPanel.SetActive(false);
    }

    //Pantallas de carga

    public void PantallaCargaGODS(){

    }

    public void PantallaCargaDEATH(){

    }

    public void PantallaCargaCACAO(){

    }


}
