using System.Diagnostics;
using System.IO.Pipes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject Manager;
    public float speed = 1f;
    private Vector3 direction = Vector3.left;
    [SerializeField] int altarOffset;

    [SerializeField] private float timer;
    [SerializeField] private int timerMax;

    //ObjectPooler
    [SerializeField] private GameObject AltarPrefab;
    [SerializeField] private List<GameObject> AltarList;
    [SerializeField] private int AltarPoolSize;

    void Start()
    {
        timer = timerMax;
        AddAltaresToPool(AltarPoolSize);
    }

    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;

        if (transform.position.x <= -6)
        {
            direction = Vector3.right;
        }
        else if (transform.position.x >= 6)
        {
            direction = Vector3.left;
        }

        timer -= 1 * Time.deltaTime;

        if(timer <= 0){
            GameObject altar = requestAltar();
            altar.transform.position = transform.position + Vector3.down * altarOffset;
            timer = timerMax;
            
        }
    }

    private void AddAltaresToPool(int amount){
        for (int i = 0; i< AltarPoolSize; i++){
            GameObject Altar = Instantiate(AltarPrefab);
            Altar.SetActive(false);
            AltarList.Add(Altar);
            Altar.transform.position = Manager.transform.position;
        }
    }

        public GameObject requestAltar(){
        for (int i = 0; i < AltarList.Count; i++){
            if (!AltarList[i].activeSelf){
                AltarList[i].SetActive(true);
                return AltarList[i];
            }
        }
        return null;
    }
}
