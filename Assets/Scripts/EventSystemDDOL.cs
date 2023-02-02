using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystemDDOL : MonoBehaviour
{
    public static EventSystemDDOL instance = null;

    private void Awake()
    {
        if (EventSystemDDOL.instance == null)
        {
            EventSystemDDOL.instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }
    }
}
