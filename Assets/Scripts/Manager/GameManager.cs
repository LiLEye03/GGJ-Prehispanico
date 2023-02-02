using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static bool CompleteGODS, CompleteDEATH, CompleteCACAO;

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
        PanelManager.GamePaused = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            PanelManager.instance.Pause();
        }
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

}
