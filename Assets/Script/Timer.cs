using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;

    public float startTime;

    public int minuti;
    public int secondi;

    private bool finish = false;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (finish)
        {
            PlayerPrefs.SetInt("minutes", minuti);
            PlayerPrefs.SetInt("seconds", secondi);
            return;
        }
        float t = Time.time - startTime;
        minuti = (int)t / 60;
        float seconditmp = t % 60 * 1000;
        secondi = (int)seconditmp;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f3");

        timerText.text ="Time: "+ minutes + ":" + seconds;
    }

    public void Finish()
    {
        finish = true;
    }
}
