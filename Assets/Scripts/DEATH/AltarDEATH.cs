using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltarDEATH : MonoBehaviour
{
    [SerializeField] GameObject altaractive;
    [SerializeField] bool Activated;
    private Vector3 direction  = Vector3.down;
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        altaractive.SetActive(false);
        Activated = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("colliderAltar")){
            LevelManagerDEATH.vidas --;
            gameObject.SetActive(false);
        }
        else if (other.gameObject.CompareTag("Flor")){
            LevelManagerDEATH.score ++;
            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("colliderAltar") && Activated == true){
            altaractive.SetActive(false);
            Activated = false;
            gameObject.SetActive(false);
        } else if (other.gameObject.CompareTag("colliderAltar") && Activated == false){
            LevelManagerDEATH.vidas --;
            Activated = false;
            gameObject.SetActive(false);

        }
        else if (other.gameObject.CompareTag("Flor")){
            if (Activated == false){
            LevelManagerDEATH.score ++;
            }
            altaractive.SetActive(true);
            Activated = true;
        }
    }
}
