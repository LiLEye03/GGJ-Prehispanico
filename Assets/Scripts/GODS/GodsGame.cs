using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GodsGame : MonoBehaviour
{
    Collider2D areaLight;
    [SerializeField]
    GameObject lightning;
    

    void Start()
    {
        areaLight = GetComponent<Collider2D>();
        StartCoroutine(Lightning());
        
    }

    IEnumerator Lightning()
    {
        while(true)
        {
            Vector2 spawnPos = new Vector2(Random.Range(areaLight.bounds.min.x, areaLight.bounds.max.x), Random.Range(areaLight.bounds.min.y, areaLight.bounds.max.y));
            GameObject miRayo = Instantiate(lightning, spawnPos, Quaternion.identity);
            Destroy(miRayo,1.5f);
            yield return new WaitForSeconds(1.5f);
        }
    }

    
}
