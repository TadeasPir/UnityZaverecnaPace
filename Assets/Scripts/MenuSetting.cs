using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSetting : MonoBehaviour
{

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Quit()
    {
        Debug.LogWarning("Quit");
        Application.Quit();
    }
    public void Win()
    {
        SceneManager.LoadScene(4);
    }
    public void Dead()
    {
        SceneManager.LoadScene(5);
    }
    public void ToBegining()
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }


}