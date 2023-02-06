using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelManagerDEATH : MonoBehaviour
{
    [SerializeField] int timer;
    float decrementSpeed;
    public static int vidas, score;
    [SerializeField] TextMeshProUGUI ScoreText, VidasText, TimerText;

    //Objetos Object Pooler
    //Flor
    [SerializeField] private GameObject FlorPrefab;
    [SerializeField] private List<GameObject> FlorList;
    [SerializeField] private int FlorPoolSize;

    // Start is called before the first frame update
    void Start()
    {
        timer = 30;
        vidas = 3;
        score = 0;
        InvokeRepeating("DecrementSeconds", 1f, 1f);

    //Object Pooler
    AddFloresToPool(FlorPoolSize);
    }
    // Update is called once per frame
    void Update()
    {
        if (vidas <= 0 || timer <= 0){
            GameManager.Instance.LvlCompletedDEATH();
        }

        ScoreText.text = "x  " + score;
        VidasText.text = "x  " + vidas;
        TimerText.text = "00:" + timer;
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

        void DecrementSeconds()
    {
        timer --;
        if (timer <= 0)
        {
            CancelInvoke("DecrementSeconds");
        }
    }


    //Object Pooler 

    //Control Obstáculos
}
