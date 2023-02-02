using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerObjets : MonoBehaviour
{
    public GameObject cao;
    public GameObject tra;
    public float timeSpawn = 5;
    public float repeatSpawn = 2.15f;
    public float timeSpawnTra = 9;
    public float repeatSpawnTra = 1.89f;
    public Transform Xmax;
    public Transform Xmin;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCacao", timeSpawn, repeatSpawn);
        InvokeRepeating("SpawnTrash", timeSpawnTra, repeatSpawnTra);
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
