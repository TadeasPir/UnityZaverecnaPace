using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESCMenu : MonoBehaviour
{

    public GameObject menu;
    public bool isOpen = false;



    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isOpen == false )
        {
            Pause();
        }
        if (isOpen == true && Input.GetKeyDown(KeyCode.Escape))
        {
            Resume();
        }
    }

    public void Resume()
    {
            menu.SetActive(false);
            isOpen = false;
            Time.timeScale = 1.0f;
            Cursor.lockState = CursorLockMode.Locked;

    }
    public void Pause() 
    {


        menu.SetActive(true);
        isOpen = true;
        Time.timeScale = 0.0f;
        Cursor.lockState = CursorLockMode.None;
    }
}
