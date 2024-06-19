using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Counter : MonoBehaviour
{
   
     public int killed = 0;


   
    void Update()
    {
        if (killed == 10)
        {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(4);
        }
    }

    public void addKilled()
    {
        killed++;
    }
}
