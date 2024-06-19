using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESCMenu : MonoBehaviour
{

    public GameObject menu;
    public bool isOpen = false;



    
    void Update()
    {
        if (isOpen == false && Input.GetKeyDown(KeyCode.Escape)) 
        {
            menu.SetActive(true);
            isOpen = true;
            Time.timeScale = 0f;
        }
        if (isOpen == true && Input.GetKeyDown(KeyCode.Escape))
        {
            menu.SetActive(false);
            isOpen = false;
            Time.timeScale = 1.0f;
        }
    }

    public void Resume()
    {
            menu.SetActive(false);
            isOpen = false;
            Time.timeScale = 1.0f;
        
    }
}
