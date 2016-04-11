using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MovieScript : MonoBehaviour
{
    public List <MovieTexture> movies;
	public MovieTexture StartMovie;

	private MovieTexture m_texture;
	private Renderer r;

	void Start ()
    {
		m_texture = StartMovie;
		r = GetComponent<Renderer>();
		//r.material.SetTexture(m_texture.ToString(), m_texture);
	}
	
	void Update ()
    {
        //if (m_texture.isPlaying == false)
		//{
			m_texture = movies[Random.Range(0, movies.Count - 1)];
			r.material.SetTexture(m_texture.ToString(), m_texture);
			m_texture.Play();
		//}
    }
}
