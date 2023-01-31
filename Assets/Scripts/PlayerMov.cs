using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public float speed = 10.0f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontal, vertical);
        rb.velocity = movement * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("GODS")){
            GameManager.miniGameStat = "GODS";
        }
        
        if (other.gameObject.CompareTag("DEATH")){
            GameManager.miniGameStat = "DEATH";
        }

        if (other.gameObject.CompareTag("CACAO")){
            GameManager.miniGameStat = "CACAO";
        }
    }
}
