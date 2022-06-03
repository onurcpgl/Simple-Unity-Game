using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text ScoreText;
    
    void Start()
    {
        score = 0;
        ScoreText.text = score.ToString();
    }

   
    void Update()
    {
        
    }
    public void UpdateScore()
    {
        score = score + 1;
        ScoreText.text = score.ToString();
    }
    public void RestarGame()
    {
        SceneManager.LoadScene(0);
    }
}
