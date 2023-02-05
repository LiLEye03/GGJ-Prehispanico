using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoMovimiento : MonoBehaviour
{
    [SerializeField] private Vector2 velocidadMovimiento;
    private Vector2 Offset;
    private Material material;

    void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        Offset = velocidadMovimiento * Time.deltaTime;   
        material.mainTextureOffset += Offset;
    }
}
