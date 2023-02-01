using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMov : MonoBehaviour
{
    public float speed = 10.0f;

    private Rigidbody2D rb;

    void Start()
    {
        GameManager.Instance.CallGameObjects();
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
            PanelManager.Instance.OpenContentGODS();
        } else {
            PanelManager.Instance.ClosePanel();
        }
        
        if (other.gameObject.CompareTag("DEATH")){
            PanelManager.Instance.OpenContentDEATH();
        } else {
            PanelManager.Instance.ClosePanel();
        }

        if (other.gameObject.CompareTag("CACAO")){
            PanelManager.Instance.OpenContentCACAO();
        } else { 
            PanelManager.Instance.ClosePanel();
        }
    }
}
