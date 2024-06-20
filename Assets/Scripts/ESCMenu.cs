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
        }else
        if (isOpen == true && Input.GetKeyDown(KeyCode.Escape))
        {
            Resume();
        }
    }

    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
            menu.SetActive(false);
            isOpen = false;
            Time.timeScale = 1.0f;
           

    }
    public void Pause()
    {
        Cursor.lockState = CursorLockMode.None;

        menu.SetActive(true);
        isOpen = true;
        Time.timeScale = 0.0f;
       
    }
}
