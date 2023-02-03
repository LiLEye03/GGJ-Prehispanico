using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDEATH : MonoBehaviour
{
    //ObjectPooler
    [SerializeField] LevelManagerDEATH ObjectPooler;
    //Player
    float FlorOffset = 2f;
    float PlayerSpeed = 5;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontal, vertical);
        rb.velocity = movement * PlayerSpeed;
        if (Input.GetKeyDown(KeyCode.Space)){
            GameObject flor = ObjectPooler.RequestFlor();
            flor.transform.position = transform.position + Vector3.up * FlorOffset;
        }
    }
}