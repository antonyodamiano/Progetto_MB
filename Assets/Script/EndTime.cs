using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndTime : MonoBehaviour
{
   
    public Text highscoreText;

    public Text endedTime;
    // Start is called before the first frame update

    public void Start()
    {
     
        gameObject.GetComponent<Text>().text = endedTime.text;


        Load();
        if (endedTime.text.CompareTo(highscoreText.text)<0){

            Save();

        }
    }
    public void Save()
    {
      
        PlayerPrefs.SetString("highscore", endedTime.text);
    }
    public void Load()
    {
        if (PlayerPrefs.GetString("highscore") != null)
        {
            highscoreText.text = PlayerPrefs.GetString("highscore");

        }

        else
            highscoreText.text = "Time: 0";
    }

   

}
