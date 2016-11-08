﻿using UnityEngine;
using System.Collections;

public class ParticleCollisionCheck : MonoBehaviour 
{
	private ParticleSystem ps;
	private GameOver gameOver;
	void Start () 
	{
		ps=GetComponent<ParticleSystem>();
		gameOver = GameObject.FindObjectOfType<GameOver> ();
	}
	private void OnParticleCollision(GameObject other)
	{
		if (other.CompareTag ("Band"))
		{
			gameOver.StopInput ();
			Destroy (gameObject);
		}
		if (other.CompareTag ("Can"))
		{
			DeleteParticles ();
			//addScore();
		}
	}

	private void DeleteParticles()
	{
		ParticleSystem.Particle[] particles = new ParticleSystem.Particle[ps.particleCount];
		int num = ps.GetParticles (particles);
		for (int i = 0; i < num; i++)
		{
			particles [i].lifetime = 0;
		}
		ps.SetParticles (particles, num);
	}
}