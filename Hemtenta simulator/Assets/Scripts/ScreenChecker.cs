using UnityEngine;
using System.Collections;

public class ScreenChecker : MonoBehaviour
{
	private int frames;
	private float counter;
    private float countdownTimer;
	
    public static int timer = 0;
    public static int TimerMax = 3;
	
	void Update ()
    {
		if (GameScript.End == false) 
		{
			frames++;

			if (!MousePosCheck.withinScreen) 
			{
				counter += 1 * Time.deltaTime;
				if (counter > 3)
				{

				}
			}

			else
			{

			}

			//if (frames >= 60) 
			//{
			//	timer++;
			//	frames = 0;
			//}
			
            timer = Mathf.FloorToInt(frames * Time.deltaTime);
		}
    }
}
