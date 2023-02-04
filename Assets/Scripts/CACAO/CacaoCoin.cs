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

        else if (other.CompareTag("SueloCa"))
        {
            //other.gameObject.GetComponent<TakeCao>().TirarCacao();
            print ("Perio un punto");
            Destroy(gameObject);
        }
    }
}
