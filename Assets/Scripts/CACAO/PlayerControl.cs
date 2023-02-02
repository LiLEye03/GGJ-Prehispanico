using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 8; //Cambiar a private al terminar las pruebas
    float move;
    public int score;
    private int lives = 5;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(move * speed, rb.velocity.y);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("TrashCoin"))
        {
            lives--;
            if (lives <= 0)
            {
                Console.WriteLine("Has muerto");
            }
        }

        if (collision.gameObject.CompareTag("CoinCao"))
        {
            score++;
            Console.WriteLine("Has obtenido un punto");
        }
    }
}
