using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWinMenu : MonoBehaviour
{
    public bool gameIsWon = false;
    public GameObject gameWinUI;
    public GameObject gameSession;

    public void Restart(){
        gameWinUI.SetActive(false);
        gameIsWon = false;
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        Time.timeScale = 1f;
    }

    public void GameWin(){
        gameWinUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsWon = true;
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
