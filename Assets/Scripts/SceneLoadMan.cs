using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadMan : MonoBehaviour
{
    [SerializeField]
    int transitionTime = 1;
    Animator anim;
    void Start()
    {
        anim=GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            LoadNextScene();
        }
    }

    public void LoadNextScene()
    {
        int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        StartCoroutine(SceneLoad(nextScene));
    }

    public IEnumerator SceneLoad(int sceneIndex)
    {
        anim.SetTrigger("StartTransition");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(sceneIndex);
    }
}
