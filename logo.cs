using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class logo : MonoBehaviour
{
     void Start()
    {
        StartCoroutine(waitBeforeShow());
    }

    private IEnumerator waitBeforeShow()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
    
}
