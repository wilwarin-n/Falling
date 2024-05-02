using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    //public static bool GameisPaused = false;
    public GameObject pauseMenuUI;
    public AudioSource pauseSound;

    public GameObject music;
    public SoundManager sm;
    
    // Start is called before the first frame update
    void Start()
    {
        pauseMenuUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        //pauseSound.Play();
        
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        //pauseSound.Pause();
        
        
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        //music.SetActive(false);

    }

    public void restart()
    {
        int index = Random.Range(1, 4);
        SceneManager.LoadScene(index);
        
        Time.timeScale = 1f;
    }


}
