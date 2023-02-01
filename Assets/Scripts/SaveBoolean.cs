using UnityEngine;

public class SaveBoolean : MonoBehaviour
{
    public static bool godsBool, deathBool, cacaoBool;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
