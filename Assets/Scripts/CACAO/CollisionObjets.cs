using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionObjets : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PJ"))
        {
            Destroy(gameObject);
        }

        if (collision.CompareTag("SueloCa"))
        {
            Destroy(gameObject);
        }
    }
}
