using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static bool CompleteGODS, CompleteDEATH, CompleteCACAO, GameStarted, GamePaused;
    [SerializeField] GameObject PausePanel, MinigamePanel, LvlCompletePanel, PanelPantallaCarga, SureExitPanel, CreditsPanel, MenuPanel;
    [SerializeField] GameObject ContentGODS, ContentDEATH, ContentCACAO, CargaGODS, CargaDEATH, CargaCACAO;
    public static string GameStat;
    [SerializeField] string EstadoDeJuego = GameStat;

    //Estados de Juego
    private void DisableAllPanels(){
        PausePanel.SetActive(false);
        MinigamePanel.SetActive(false);
        ContentGODS.SetActive(false);
        ContentDEATH.SetActive(false);
        ContentCACAO.SetActive(false);
        CargaGODS.SetActive(false);
        CargaDEATH.SetActive(false);
        CargaCACAO.SetActive(false);
        LvlCompletePanel.SetActive(false);
        PanelPantallaCarga.SetActive(false);
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

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            Pause();
        }
    }

    //Estados de Juego
    public void Menu(){
        GameStat = "Menu";
        DisableAllPanels();
        MenuPanel.SetActive(true);
    }

    public void StartGame(){
        GameStat = "Game";
        DisableAllPanels();
        SceneManager.LoadScene("PLAZA");
    }

    public void Pause(){
        if (GamePaused == true){
            DisableAllPanels();
            PausePanel.SetActive(true);
        } else {
            DisableAllPanels();
            PausePanel.SetActive(false);
        }
    }
    public void ClosePanel(){
        if (GameStat == "Menu"){
            DisableAllPanels();
            MenuPanel.SetActive(true);
        } else {
        DisableAllPanels();
        }
    }
    public void Creditos(){
        DisableAllPanels();
        CreditsPanel.SetActive(true);
    }
    public void SureExit(){
        DisableAllPanels();
        SureExitPanel.SetActive(true);
    }
    public void GODS(){
        DisableAllPanels();
        MinigamePanel.SetActive(true);
        ContentGODS.SetActive(true);
    }
    public void SceneGODS(){
        SceneManager.LoadScene("GODS");
    }
    public void DEATH(){
        DisableAllPanels();
        MinigamePanel.SetActive(true);
        ContentDEATH.SetActive(true);
    }
    public void SceneDEATH(){
        SceneManager.LoadScene("DEATH");
    }
    public void CACAO(){
        DisableAllPanels();
        MinigamePanel.SetActive(true);
        ContentCACAO.SetActive(true);
    }
    public void SceneCACAO(){
        SceneManager.LoadScene("CACAO");
    }
    public void GODSwin(){
        DisableAllPanels();
        LvlCompletePanel.SetActive(true);
        CargaGODS.SetActive(true);
        CompleteGODS = true;
        SceneManager.LoadScene("PLAZA");
    }
    public void DEATHwin(){
        DisableAllPanels();
        LvlCompletePanel.SetActive(true);
        CargaDEATH.SetActive(true);
        CompleteDEATH = true;
        SceneManager.LoadScene("PLAZA");
    }
    public void CACAOwin(){
        DisableAllPanels();
        LvlCompletePanel.SetActive(true);
        CargaCACAO.SetActive(true);
        CompleteCACAO = true;
        SceneManager.LoadScene("PLAZA");
    }

    //Niveles completos

    //GODS
    public void CompleteLvlGODS(){
        CompleteGODS = true;
        print("Haz completado el nivel 'GODS'");
    }

    public void ClearLvlGODS(){
        CompleteGODS = false;
        print("Se ha reiniciado el nivel 'GODS'");
    }

    //DEATH
    public void CompleteLvlDEATH(){
        CompleteDEATH = true;
        print("Haz completado el nivel 'DEATH'");
    }

    public void ClearLvlDEATH(){
        CompleteDEATH = false;
        print("Se ha reiniciado el nivel 'DEATH'");
    }

    //CACAO
    public void CompleteLvlCACAO(){
        CompleteCACAO = true;
        print("Haz completado el nivel 'CACAO'");
    }

    public void ClearLvlCACAO(){
        CompleteCACAO = false;
        print("Se ha reiniciado el nivel 'CACAO'");
    }

    public void ClearAllLvls(){
        ClearLvlGODS();
        ClearLvlDEATH();
        ClearLvlCACAO();
    }

    //Pantallas de carga

    public void PantallaCargaGODS(){

    }

    public void PantallaCargaDEATH(){

    }

    public void PantallaCargaCACAO(){

    }

}
