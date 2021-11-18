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
    }

    private void Update() {
        livesText.text = currentLives.ToString();
        scoreText.text = currentScore.ToString();

        var balls = GameObject.FindGameObjectsWithTag("Ball");

        if(balls.Length <= 0){
            DecreaseLives();
            GameObject.FindGameObjectWithTag("Player").GetComponent<vaus>().ResetBall();
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

    }
}
