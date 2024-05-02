using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject backn;
    public void Start()
    {
        Time.timeScale = 1f;
    }

    public void Update()
    {
    }
    public void PlayGame()
    {
        int index = Random.Range(1, 4);
        SceneManager.LoadScene(index);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //.SetActive(false);

        
    }
    
    public void QuitGame()
    {
        Debug.Log("Quitting Game..");
        Application.Quit();
    }

    
}
