using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI displayScore;




    public void gameScore(int ringScore) {
        score += ringScore;
        scoreText.text = score.ToString();
        displayScore.text = score.ToString();
    }
    
    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    

    
}
