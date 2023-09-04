using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("levelSelection");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("iqra");
    }
}
