using UnityEngine;
using System.Collections;

public class movieScript : MonoBehaviour {

	private Renderer r;
	private AudioSource Sound;
	private MovieTexture movie;

	void Start()
	{
		r = GetComponent<Renderer>();
		Sound = GetComponent<AudioSource>();
		movie = (MovieTexture)r.material.mainTexture;
	}

	void Update()
	{
		Debug.Log(movie.isPlaying);
		if (Input.GetButtonDown("Jump"))
		{
			if (movie.isPlaying)
			{
				Sound.Pause();
				movie.Pause();
			}
			else
			{
				Sound.Play();
				movie.Play();
			}
		}
	}
}
