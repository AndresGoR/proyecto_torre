using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject antimenu;

    public GameObject pauseMenuUI;
    // Update is called once per frame
    void Update()
    {


        /* if (Input.GetKeyDown(KeyCode.Escape))
         {
             if (GameIsPaused)
             {
                 Resume();
             }
             else
             {
                 Pause();
             }
         }*/

        if (!Input.GetKeyDown(KeyCode.Escape)) return;

        if (GameIsPaused) Resume();
        else Pause();

    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }



}
