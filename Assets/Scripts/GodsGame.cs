using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodsGame : MonoBehaviour
{
    Collider2D areaLight;
    [SerializeField]
    GameObject lightning;

    void Start()
    {
        areaLight=GetComponent<Collider2D>();
        StartCoroutine(Lightning());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Lightning()
    {
        while(true)
        {
            Vector2 spawnPos = new Vector2(Random.Range(areaLight.bounds.min.x, areaLight.bounds.max.x), Random.Range(areaLight.bounds.min.y, areaLight.bounds.max.y));
            GameObject miRayo = Instantiate(lightning, spawnPos, Quaternion.identity);
            Destroy(miRayo,1);
            yield return new WaitForSeconds(3);
        }
    }
}
