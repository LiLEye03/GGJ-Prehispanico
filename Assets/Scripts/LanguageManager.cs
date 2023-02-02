using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LanguageManager : MonoBehaviour
{
    public static string Language;
                                    //Lenguaje Botones
    [SerializeField] TextMeshProUGUI StartButton, CreditsButton;
    [SerializeField] bool Español;
                                    //Lenguaje Contenido Paneles Español
    [SerializeField] TextMeshProUGUI TitleES,CreditsES, ContentGODSEs, ChargingGODSEs, WinGODSEs, ContentDEATHEs, ChargingDEATHEs, WinDEATHEs, ContentCACAOEs, ChargingCACAOEs, WinCACAOes, WinGameES;
    [SerializeField] bool Inglés;
                                    //Lenguaje Contenido Paneles Inglés
    [SerializeField] TextMeshProUGUI TitleEN,CreditsEN, ContentGODSEn, ChargingGODSEn, WinGODSEn, ContentDEATHEn, ChargingDEATHEn, WinDEATHEn, ContentCACAOEn, ChargingCACAOEn, WinCACAOEn, WinGameEN;
                                    //Lenguaje Contenido Extras

    //DontDestroyOnLoad
    public static LanguageManager Instance;

    void Awake()
    {
        if (LanguageManager.Instance == null){
            LanguageManager.Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Switch que llama a cambiar el String "Language" haciendo que se activen los paneles del lenguaje seleccionado
        switch(Language){
            case "Spanish - ES":
            //Botones

            //Contenido Español

            //Contenido Inglés
            break;

            case "English - EN":
            //Botones

            //Contenido Español

            //Contenido Inglés
            break;
        }
    }
}
