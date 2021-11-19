using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameSession : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI livesText;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI highScoreText;
    [SerializeField] int startLives = 3;

    public GameObject canvas;

    public int currentLives;
    int currentScore;
    int currentHighScore;

/*    private void Awake() {
        int instanceCount = FindObjectsOfType<GameSession>().Length;
        if(instanceCount > 1){
            Destroy(gameObject);
        }
        else{
            DontDestroyOnLoad(gameObject);
        }
    }*/

    private void Start() {
        currentLives = startLives;
        Time.timeScale = 1f;
    }

    private void Update() {
        livesText.text = currentLives.ToString();
        scoreText.text = currentScore.ToString();

        var balls = GameObject.FindGameObjectsWithTag("Ball");
        if(balls.Length == 0){
            DecreaseLives();
            GameObject.FindGameObjectWithTag("Player").GetComponent<vaus>().ResetBall();
        }

        var blocks = GameObject.FindGameObjectsWithTag("Block");
        if(blocks.Length == 0){
            GameWin();
        }
    }

    public void IncreaseScore(int value){
        currentScore += value;
    }

    public void DecreaseLives(){
        currentLives--;
        if(currentLives <= 0){
            GameOver();
        }
    }

    private void GameOver(){
        canvas.GetComponent<GameOverMenu>().GameOver();
    }

    private void GameWin(){
        canvas.GetComponent<GameWinMenu>().GameWin();
    }
}
