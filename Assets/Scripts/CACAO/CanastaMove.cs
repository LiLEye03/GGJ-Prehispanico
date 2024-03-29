using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanastaMove : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 12; 
    
    float move;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        move = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(move * speed, rb.velocity.y);
    }
}
