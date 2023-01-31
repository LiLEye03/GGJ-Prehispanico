using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoolean : MonoBehaviour
{
    public static bool godsBool, deathBool, cacaoBool;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
