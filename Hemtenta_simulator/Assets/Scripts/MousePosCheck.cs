using UnityEngine;
using System.Collections;

public class MousePosCheck : MonoBehaviour
{
    //private Vector3 MousePos;

    public TextMesh wordsText;
    public static int words;
    public static int Max_words;
    public static bool withinScreen;
    private bool motivation;
    private int randVal;
    public GazeAwareComponent tenta;
    public GazeAwareComponent underhållning;

    private double screenWidth = Screen.width;
    private double screenHeight = Screen.height;

    //the screen size
    private double X_MAX;
    private double Y_MAX;
    private double X_MIN;
    private double Y_MIN;

	//private EyeXHost eyeGaze;
	//public Camera camera;



    [AddComponentMenu("Tobii EyeX/Gaze Aware")]
    void Start ()
    {
        //Setting the frame for the tentaskärm
        X_MAX = screenWidth / 2.8;
        Y_MAX = screenHeight / 1.285;
        X_MIN = screenWidth / 95.95;
        Y_MIN = screenHeight / 2.72;

        words = 0;
        Max_words = 2000;
        withinScreen = false;
        motivation = true;
        randVal = 0;
    }
	
	void Update ()
    {
        //MousePos = Input.mousePosition;
		if (GameScript.End == false) 
		{
			getMotivation ();                                //bestäm om ord ska skrivas eller inte
			//eyeGaze = camera.ScreenToWorldPoint();

			//if(eyeGaze.x < X_MAX && eyeGaze.y < Y_MAX && eyeGaze.x > X_MIN && eyeGaze.y > Y_MIN){}
        


			if (tenta.HasGaze == true) {
				Debug.Log ("Gazeeeee");
				withinScreen = true;
				wordLoop (motivation);
			}
                                                            //Är blicken inom skärmen eller inte
        else {
				withinScreen = false;
			}

			//Debug.Log(words);
			//Debug.Log(withinScreen);
			//Debug.Log(timer);
			//Debug.Log(MousePos);
			//Debug.Log(motivation);
		}
    }

    void getMotivation()
    {
            randVal = Random.Range(1, 11);
            if (randVal >= 8)
            {
                motivation = true;                          //spelaren kan skriva
            }
            else
            {
                motivation = false;
            }
    }

    void wordLoop(bool argument)
    {
        if (argument == true)
        {
            words++;
            wordsText.text = words.ToString();
        }
    }
}