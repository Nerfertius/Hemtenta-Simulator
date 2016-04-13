using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MovieScript : MonoBehaviour
{
    public List <MovieTexture> movies;
	public MovieTexture StartMovie;

	private MovieTexture m_texture;
	private Renderer r;
	private AudioSource a_source;
	private int randomHold;

	void Start ()
    {
		r = GetComponent<Renderer>();
		m_texture = StartMovie;
		r.material.mainTexture = m_texture;
		a_source = gameObject.GetComponent<AudioSource>();
	}
	
	void Update ()
    {
		//Limit the creation of random numbers
		//Make a function that only is called
		//only when a video ends


		randomHold = Random.Range(0, movies.Count - 1);
		//Debug.Log("Video: " + m_texture);
		Debug.Log("randomHold: " + randomHold);
		if (m_texture.isPlaying == false)
		{
			//r.material.mainTexture = StartMovie;
			//a_source.clip = m_texture.audioClip;
			//a_source.Play();
			//StartMovie.Play();

			//if (StartMovie.isPlaying == false)
			//{
				m_texture = movies[randomHold];
				r.material.mainTexture = m_texture;
				a_source.clip = m_texture.audioClip;
				a_source.Play();
				m_texture.Play();
			//}
		}
    }
}
