using UnityEngine;
using System.Collections;

public class ControllParticles : MonoBehaviour 
{
	private bool paint;
	private ParticleSystem ps;
	private void Start()
	{
		ps = GetComponent<ParticleSystem> ();
		paint = false;
	}

	private void Update()
	{
		
	}
	public bool SetBool
	{
		set
		{ 
			switch (paint)
			{
				case true:
				paint = false;
				ps.Stop();
				break;
				case false:
				paint = true;
<<<<<<< HEAD
				ps.Play();
=======
				ps.Play ();
>>>>>>> 6d4da81a829afc65783e1cd9b349291fff2ffc8f
				break;
				default:paint = false; ps.Stop();
				break;
			}
		}
	}
}
