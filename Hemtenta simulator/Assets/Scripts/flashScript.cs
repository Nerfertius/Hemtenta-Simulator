using UnityEngine;
using System.Collections;

public class flashScript : MonoBehaviour
{
	private Renderer rend;

	void Start ()
	{
		rend = gameObject.GetComponent<Renderer>();
	}
	
	void Update ()
	{
		
	}

	void Flash()
	{
		//flash the alpha color
		rend.material.SetColor()
	}
}
