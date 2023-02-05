using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerObjets : MonoBehaviour
{
    public GameObject cao;
    public GameObject tra;
    public float timeSpawn = 5; //Tiempo de aparicion
    public float repeatSpawn = 2.5f; //Tiempo para reaparecer
    public float timeSpawnTra = 9;
    public float repeatSpawnTra = 8;
    public Transform Xmax;
    public Transform Xmin;

    public TimerControlCao Apagar;
    private bool ApagarSpawner=true;


    void Start()
    {
        Apagar = FindObjectOfType<TimerControlCao>();
        if (ApagarSpawner)
        {
        InvokeRepeating("SpawnCacao", timeSpawn, repeatSpawn);
        InvokeRepeating("SpawnTrash", timeSpawnTra, repeatSpawnTra);
        }
    }

    void Update() {
        if (Apagar.mark==false)
        {
            ApagarSpawner=false;
        }
    }

    public void SpawnCacao()
    {
        Vector2 spawnPos = new Vector2(0, 0);
        spawnPos = new Vector2(Random.Range(Xmax.position.x, Xmin.position.x), 6);
        Instantiate(cao, spawnPos, Quaternion.identity);
    }

    public void SpawnTrash()
    {
        Vector2 spawnPosTra = new Vector2(0, 0);
        spawnPosTra = new Vector2(Random.Range(Xmax.position.x, Xmin.position.x), 6);
        Instantiate(tra, spawnPosTra, Quaternion.identity);
    }
}
