using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject gameOverUI;

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(gameIsPaused){
                Resume();
            }

            else {
                Pause();
            }
        }
    }

    public void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    void Pause(){
        if(gameOverUI.GetComponent<GameOverMenu>().gameIsOver == false){
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            gameIsPaused = true;            
        }
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
