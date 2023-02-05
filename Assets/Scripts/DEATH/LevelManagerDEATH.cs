using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelManagerDEATH : MonoBehaviour
{
    [SerializeField] float timer;
    public static int vidas, score;
    [SerializeField] TextMeshProUGUI ScoreText, VidasText;

    //Objetos Object Pooler
    //Flor
    [SerializeField] private GameObject FlorPrefab;
    [SerializeField] private List<GameObject> FlorList;
    [SerializeField] private int FlorPoolSize;

    // Start is called before the first frame update
    void Start()
    {
        vidas = 3;
        score = 0;

    //Object Pooler
    AddFloresToPool(FlorPoolSize);
    }
    // Update is called once per frame
    void Update()
    {
        if (vidas <= 0){
            LvlCompleteDEATH();
        }

        ScoreText.text = "x  " + score;
        VidasText.text = "x  " + vidas;
    }

    private void AddFloresToPool(int amount){
        for (int i = 0; i < FlorPoolSize; i++){
            GameObject Flor = Instantiate(FlorPrefab);
            Flor.SetActive(false);
            FlorList.Add(Flor);
            Flor.transform.parent = transform;
        }
    }

    public GameObject RequestFlor(){
        for (int i = 0; i < FlorList.Count; i++){
            if (!FlorList[i].activeSelf){
                FlorList[i].SetActive(true);
                return FlorList[i];
            }
        }
        return null;
    }

    public void LvlCompleteDEATH(){
        GameManager.Instance.LvlCompletedDEATH();
    }


    //Object Pooler 

    //Control Obstáculos
}
