using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndTime : MonoBehaviour
{
   
    public int minuti;
    public int secondi;

    public Text endedTime;
    // Start is called before the first frame update

    public void Start()
    {
     
        gameObject.GetComponent<Text>().text = endedTime.text;


        Load();
        if (endedTime.text.ToString().CompareTo("Time: " + minuti + ":" + secondi)<0){
            gameObject.GetComponent<Text>().text = endedTime.text + " New Highscore!!!";
            Save();

        }
    }
    public void Save()
    {
        PlayerPrefs.SetInt("minutes", minuti);
        PlayerPrefs.SetInt("seconds", secondi);

    }
    public void Load()
    {
        minuti = PlayerPrefs.GetInt("minutes",0);
        secondi = PlayerPrefs.GetInt("seconds",0);
    }

   

}
