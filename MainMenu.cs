using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject pausemenu;
    public void Resume()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1;
        // pausemenuui.SetActive(false);
        // Time.timeScale = 1f;
        //GameIsPaused = false;
    }
    public  void Pause()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0;
        // pausemenuui.SetActive(true);
        // Time.timeScale = 0f; //freeze time
        //GameIsPaused = true;

    }
    public void home()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
    public void LoadGame()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadGamelevel1()
    {
        SceneManager.LoadScene(3);
    }
    public void LoadGameleve2()
    {
        SceneManager.LoadScene(4);
    }
    public void Quit()
    {
        Application.Quit();
    }
    
}
