using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasDDOL : MonoBehaviour
{
    public static CanvasDDOL instance = null;

    private void Awake()
    {
        if (CanvasDDOL.instance == null)
        {
            CanvasDDOL.instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }
    }
}
