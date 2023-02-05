using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMov : MonoBehaviour
{
    //Animaciones
    [SerializeField] string animState;
    private Animator animator;

    //lo demas XD
    SpriteRenderer playerSprite;
    public float speed = 10.0f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        playerSprite = GetComponent<SpriteRenderer>();
        animState = "Down";
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (Input.GetAxis("Horizontal") < 0){
            playerSprite.flipX = true;
            animState = "Horizontal";
        } else if (Input.GetAxis("Horizontal") > 0){
            playerSprite.flipX = false;
            animState = "Horizontal";
        }

        if (Input.GetAxis("Vertical") > 0){
            animState = "Up";
        } else if (Input.GetAxis("Vertical") < 0){
            animState = "Down";
        }

        Vector2 movement = new Vector2(horizontal, vertical);
        rb.velocity = movement * speed;

        switch (animState){
            case "Horizontal":
            if (Input.GetAxis("Horizontal") == 0){
                DisableAllAnim();
                animator.SetBool("idleHorizontal", true);
            } else if (Input.GetAxis("Horizontal") != 0){
                DisableAllAnim();
                animator.SetBool("walkingHorizontal", true);
            }
            break;

            case "Up":
            if (Input.GetAxis("Vertical") == 0){
                DisableAllAnim();
                animator.SetBool("idleUp", true);
            } else if (Input.GetAxis("Vertical") != 0){
                DisableAllAnim();
                animator.SetBool("walkingUp",true);
            }
            break;

            case "Down":
            if (Input.GetAxis("Vertical") == 0){
                DisableAllAnim();
                animator.SetBool("idleDown", true);
            } else if (Input.GetAxis("Vertical") != 0){
                DisableAllAnim();
                animator.SetBool("walkingDown", true);
            }
            break;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("GODS")){
            GameManager.Instance.GODS();
        } else if (other.gameObject.CompareTag("DEATH")){
            GameManager.Instance.DEATH();
        } else if (other.gameObject.CompareTag("CACAO")){
            GameManager.Instance.CACAO();
        }

        if (other.CompareTag("Rayo"))
        {
            Destroy(gameObject);
            GameManager.Instance.GameOverGODS();
        }
    }

        void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("GODS")){
            GameManager.Instance.ClosePanel();
        } else if (other.gameObject.CompareTag("DEATH")){
            GameManager.Instance.ClosePanel();
        } else if (other.gameObject.CompareTag("CACAO")){
            GameManager.Instance.ClosePanel();
        } 
    }

    private void DisableAllAnim(){
        animator.SetBool("idleHorizontal", false);
        animator.SetBool("walkingHorizontal", false);
        animator.SetBool("idleUp", false);
        animator.SetBool("walkingUp", false);
        animator.SetBool("idleDown", false);
        animator.SetBool("walkingDown", false);
    }
}
