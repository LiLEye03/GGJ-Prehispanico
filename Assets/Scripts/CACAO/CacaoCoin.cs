using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CacaoCoin : MonoBehaviour
{
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag=="PJ")
        {
            other.gameObject.GetComponent<TakeCao>().AgarrarCacao();
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("SueloCa"))
        {
            FindObjectOfType<LevelManagerCACAO>().LosseHealt();
            print ("Perio una vida");
            Destroy(gameObject);
        }
    }
}
