using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlorDEATH : MonoBehaviour
{
    float speed = 15;
    public static Rigidbody2D rb;
    // float speed = 20;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        transform.position += Vector3.up*speed*Time.deltaTime;
    }

    void OnTriggerEnter2D()
    {
        gameObject.SetActive(false);
    }

    void OnCollisionEnter2D()
    {
        gameObject.SetActive(false);
    }
}
