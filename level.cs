using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class level : MonoBehaviour
{

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadGamelevel1()
    {
        SceneManager.LoadScene(3);
    }
    public void LoadGameleve2()
    {
        SceneManager.LoadScene(4);
    }

}