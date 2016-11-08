using UnityEngine;
using System.Collections;

public class Particles : MonoBehaviour 
{
	private ParticleSystem ps;
	void Start () 
	{
		ps=GetComponent<ParticleSystem>();
	}
	void OnParticleCollision(GameObject other)
	{
		if (other.CompareTag ("Player"))
		{
			ParticleSystem.Particle[] particles = new ParticleSystem.Particle[ps.particleCount];
			int num = ps.GetParticles (particles);
			for (int i = 0; i < num; i++)
			{
				particles [i].lifetime = 0;
			}
			ps.SetParticles (particles, num);
		}
		if (other.CompareTag ("Band"))
		{
			Debug.Log ("SPILL!");
		}
	}
}