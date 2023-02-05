using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    GameObject Player;
    void Start()
    {
        Instantiate(Player);
    }

    
}
