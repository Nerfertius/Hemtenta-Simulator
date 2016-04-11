using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour
{
    private int frames;
    public static int timer;
    public int TimerMaxInSeconds;
    public static int TimerMax;
    public TextMesh timeText;
    private float countdownTimer;

    void Start ()
    {
        frames = 0;
        timer = 0;
        TimerMax = TimerMaxInSeconds;
    }
	
	void Update ()
    {
		if (GameScript.End == false) 
		{
			frames++;

			if (MousePosCheck.withinScreen == false) 
			{
				frames += 3;
				Clock.clockSpeed += 1;
			}

			if (!MousePosCheck.withinScreen == false) 
			{
				Clock.clockSpeed = 1.0F;
			}

			if (frames >= 60) 
			{
				timer++;
				frames = 0;
			}
        
			//Debug.Log(timer);
			//timer = frames * Time.deltaTime;
			countdownTimer = TimerMaxInSeconds - timer;
			timeText.text = countdownTimer.ToString ();
		}
    }
}
