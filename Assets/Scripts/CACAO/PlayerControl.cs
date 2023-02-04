using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 12; //Cambiar a private al terminar las pruebas
    private Animator animatorPJ;
    float move;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animatorPJ = GetComponent<Animator>();
    }
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        if (move <0.0f) 
        {
            transform.localScale = new Vector3 (-0.8f,0.8f,0.8f);
        }
        else if (move>0.0f)
        {
            transform.localScale = new Vector3(0.8f,0.8f,0.8f);
        }
        animatorPJ.SetBool("CaoRunning", move!=0.0f);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(move * speed, rb.velocity.y);
    }
}
