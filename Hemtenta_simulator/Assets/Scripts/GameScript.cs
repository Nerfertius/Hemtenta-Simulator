using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour
{
    public GameObject VictoryObject;
    public GameObject DefeatObject;
    public GameObject canvas;
	public static bool End;

    void Start ()
    {
        VictoryObject.SetActive(false);
        DefeatObject.SetActive(false);
        canvas.SetActive(false);
		End = false;
    }
	
	void Update()
    {
        if (MousePosCheck.words >= MousePosCheck.Max_words)
        {
            Time.timeScale = 0;                 //pause game
            AudioListener.pause = true;         //pause audio
            canvas.SetActive(true);
            VictoryObject.SetActive(true);
			End = true;
        }
        else if (ScreenChecker.timer >= ScreenChecker.TimerMax)
        {
            Time.timeScale = 0;                 //pause game
            AudioListener.pause = true;         //pause audio
            canvas.SetActive(true);
            DefeatObject.SetActive(true);
			End = true;
        }
    }
}
