using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    void godsComplete(){
        godsBool = true;
        SceneManager.LoadScene("SampleScene");
    }

    void deathComplete(){
        deathBool = true;
        SceneManager.LoadScene("SampleScene");
    }

    void cacaoComplete(){
        cacaoBool = true;
        SceneManager.LoadScene("SampleScene");
    }
}
