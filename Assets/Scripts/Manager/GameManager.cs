using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}
    [SerializeField] public static string gameStat, miniGameStat, LvlComplete;

    //GameObjects miniGames
    public static GameObject miniGamePanel, godsPanel, deathPanel, cacaoPanel, LvlCompletePanel, LvlCompleteGODS, LvlCompleteDEATH, LvlCompleteCACAO;
    //GameObjects miniGames EXTRAS
    public static GameObject checkMarkGODS, checkMarkDEATH, checkMarkCACAO;
    //GameObjects GameStats
    public static GameObject PausePanel, MenuPanel;

    public static bool godsBool, deathBool, cacaoBool, GameStarted;

    void Awake()
    {
        if (Instance == null){
            Instance = this;
        } else {
            Debug.Log("Más de un GameManager en escena!");
        }
    }
   

    public void CallGameObjects(){
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

}
