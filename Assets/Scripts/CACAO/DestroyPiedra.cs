using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPiedra : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.CompareTag("SueloCa"))
        {
            Destroy(gameObject);
        }
    }
}
