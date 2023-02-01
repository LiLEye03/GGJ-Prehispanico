using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    public static DontDestroy instance = null;

    private void Awake()
    {
        if (DontDestroy.instance == null)
        {
            DontDestroy.instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }
    }
}
