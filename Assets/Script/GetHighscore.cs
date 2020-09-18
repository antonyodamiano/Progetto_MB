using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetHighscore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int minuti = PlayerPrefs.GetInt("minutes", 0);
        int secondi = PlayerPrefs.GetInt("seconds", 0);
        gameObject.GetComponent<Text>().text = "Highscore : " + minuti + ":" + secondi/1000 + "," + secondi%1000;
    }

    
}
