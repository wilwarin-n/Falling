using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private GameObject splashImg;
    [SerializeField] private float jumpForce;
    private GameManager gm;
    private Ring ring;

    public GameObject gameOverUI;
    public GameObject pauseUI;
    public AudioSource grassAudio;
    
    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
        //gameOverUI.SetActive(false);
    }

    private void OnCollisionEnter(Collision other) {
        rb.AddForce(Vector3.up * jumpForce);
        GameObject splash =  Instantiate(splashImg, transform.position - new Vector3(0, 0.22f, 0f), transform.rotation);
        splash.transform.SetParent(other.gameObject.transform);
        Destroy(splash, 1);

        grassAudio.Play();

        string metarialName = other.gameObject.GetComponent<MeshRenderer>().material.name;
        if(metarialName == "Unsafe Color (Instance)") {
            //gm.restartGame();
            gameOverUI.SetActive(true);
            pauseUI.SetActive(false);
            Time.timeScale = 0f;
        }
    }
}
