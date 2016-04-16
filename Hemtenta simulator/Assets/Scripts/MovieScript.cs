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
	private MovieTexture PreviousMovie;

	void Start ()
    {
		r = GetComponent<Renderer>();
		m_texture = StartMovie;
		r.material.mainTexture = m_texture;
		a_source = gameObject.GetComponent<AudioSource>();

		NewClip();
    }
	
	void Update ()
    {
		//r.material.mainTexture = StartMovie;
		//a_source.clip = m_texture.audioClip;
		//a_source.Play();
		//StartMovie.Play();

		//if (StartMovie.isPlaying == false)
		//{
		//}
	}

	void NewClip()
	{
		m_texture = movies[Random.Range(0, movies.Count - 1)];
		Debug.Log(m_texture);
		Debug.Log(PreviousMovie);

		if (m_texture == PreviousMovie)
		{
			m_texture = movies[Random.Range(0, movies.Count - 1)];
			PreviousMovie = m_texture;
		}
		PreviousMovie = m_texture;
		r.material.mainTexture = m_texture;
		a_source.clip = m_texture.audioClip;
		m_texture.Stop();
		a_source.Play();
		m_texture.Play();
		StartCoroutine(TimeBetweenClips());
	}

	IEnumerator TimeBetweenClips()
	{
		Debug.Log("Waiting...");
		yield return new WaitForSeconds(m_texture.duration + 0.5F);
		Debug.Log("Going");
		NewClip();
	}
}
