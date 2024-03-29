using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.SceneManagement;



public class MenuPause : MonoBehaviour

{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame

    void Update()

    {

        if (Input.GetKeyDown(KeyCode.Escape))

        {

            if (GameIsPaused)

            {
                Resume();
            }

            else

            {
                Pause();
            }

        }

    }

    public void Resume()

    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

    public void Pause()

    {
        pauseMenuUI.SetActive(true);

        Time.timeScale = 0f;

        GameIsPaused = true;
    }



    public void LoadMenu()

    {
        Debug.Log("Load");

        Time.timeScale = 1f;

        SceneManager.LoadScene("menu");
    }



    public void QuitGame()

    {
        Debug.Log("Quit");

        Application.Quit();
    }

}
