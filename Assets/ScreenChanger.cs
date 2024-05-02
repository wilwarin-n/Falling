using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScreenChanger : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator animator;

    private int levelToLoad;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FadetoScreen(int screenIndex)
    {
        levelToLoad = screenIndex;
        animator.SetTrigger("FadeOut");
    }

    public void onFadeComplete()
    {
        FadetoScreen(1);

        SceneManager.LoadScene(levelToLoad);
    }
}
