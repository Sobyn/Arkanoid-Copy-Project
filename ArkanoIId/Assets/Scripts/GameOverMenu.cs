using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public bool gameIsOver = false;
    public GameObject gameOverMenuUI;
    public GameObject gameSession;

    private void Update() {
        if(gameSession.GetComponent<GameSession>().currentLives <= 0){
            GameOver();
        }
    }

    public void Restart(){
        gameOverMenuUI.SetActive(false);
        gameIsOver = false;
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        Time.timeScale = 1f;
    }

    void GameOver(){
        gameOverMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsOver = true;
        gameSession.GetComponent<GameSession>().currentLives = 3;
    }

    public void LoadMenu(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void QuitGame(){
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
