using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FlashScript : MonoBehaviour
{
	private Image img;
	private float lerp;

	public Color startColor;
	public Color changeColor;
	public float duration = 2.0F;

	void Start ()
	{
		img = GetComponent<Image>();
		img.material.color = startColor;
    }
	
	void Update ()
	{
		lerp += Time.time;
		Debug.Log(lerp);
		img.color = Color.Lerp(startColor, changeColor, lerp);
	}

	void Flash()
	{
		//flash the alpha color
		
		//img.color = endColor;
	}
}
