using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class LevelManagerDEATH : MonoBehaviour
{
    [SerializeField] float timer;

    //Objetos Object Pooler
    //Altar
    [SerializeField] private GameObject AltarPrefab;
    [SerializeField] private List<GameObject> AltarList;
    [SerializeField] private int AltarPoolSize;
    //Flor
    [SerializeField] private GameObject FlorPrefab;
    [SerializeField] private List<GameObject> FlorList;
    [SerializeField] private int FlorPoolSize;

    // Start is called before the first frame update
    void Start()
    {

    //Object Pooler
    AddAltaresToPool(AltarPoolSize);
    AddFloresToPool(FlorPoolSize);
    }

    private void AddAltaresToPool(int amount){
        for (int i = 0; i< AltarPoolSize; i++){
            GameObject Altar = Instantiate(AltarPrefab);
            Altar.SetActive(false);
            AltarList.Add(Altar);
            Altar.transform.parent = transform;
        }
    }

    private void AddFloresToPool(int amount){
        for (int i = 0; i < FlorPoolSize; i++){
            GameObject Flor = Instantiate(FlorPrefab);
            Flor.SetActive(false);
            FlorList.Add(Flor);
            Flor.transform.parent = transform;
        }
    }


    public GameObject RequestAltar(){
        for (int i = 0; i < AltarList.Count; i++){
            if (!AltarList[i].activeSelf){
                AltarList[i].SetActive(true);
                return AltarList[i];
            }
        }
        return null;
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


    // Update is called once per frame
    void Update()
    {
        timer -= 1 * Time.deltaTime;

        if (timer <= 0){
            LvlCompleteDEATH();
            timer = 0;
        }

        print(timer);
    }
    public void LvlCompleteDEATH(){
        GameManager.Instance.LvlCompletedDEATH();
    }


    //Object Pooler 

    //Control Obstáculos
}
