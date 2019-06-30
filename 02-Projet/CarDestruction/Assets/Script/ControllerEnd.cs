using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControllerEnd : MonoBehaviour
{



    void Start()
    {
        Cursor.visible = true;
    }
   
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

   
    public void Quit()
    {
        Application.Quit();
    }
}
