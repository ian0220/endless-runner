using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // pause menu tutorial gevolgd https://www.youtube.com/watch?v=JivuXdrIHK0&ab_channel=Brackeys
    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;

    private void Start()
    {
        GameIsPaused = false;
        Time.timeScale = 1;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Paused();
            }
        }
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        GameIsPaused = false;
    }

    public void Paused()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        GameIsPaused = true;
    }

    //loads the menu


    // starts the game
    public void StartGame()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Load Next Scene");
    }
    // quits game
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit game");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Load Menu");
    }
}
