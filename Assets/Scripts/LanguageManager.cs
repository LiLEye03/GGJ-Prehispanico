using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LanguageManager : MonoBehaviour
{
    public static string Language;
    [Header ("Menu panel")]
    [SerializeField] string LanguageMenuPanel;
    [SerializeField] TextMeshProUGUI StartBtnEN, CreditsBtnEN, LanguageBtnEN, StartBtnES, CredtisBtnES, LanguageBtnES;
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
