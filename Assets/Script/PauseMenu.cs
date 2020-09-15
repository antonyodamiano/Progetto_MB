using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
  
   public void Resume()
    {
        Time.timeScale = 1f;
    }
   public void Pause()
    {
        Time.timeScale =0f;
    }

    public void Quit()
    {
        Application.Quit();
    }
}

