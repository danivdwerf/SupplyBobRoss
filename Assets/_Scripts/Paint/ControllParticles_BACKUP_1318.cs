using UnityEngine;
using System.Collections;

public class ControllParticles : MonoBehaviour 
{
	private bool paint;
	private ParticleSystem ps;
	private Indicator indicator;
	private void Start()
	{
		indicator = GameObject.FindGameObjectWithTag("GameController").GetComponent<Indicator> ();
		ps = GetComponent<ParticleSystem> ();
		paint = false;
	}
	public bool SetBool
	{
		set
		{ 
			switch (paint)
			{
				case true:
				paint = false;
				ps.Stop ();
				indicator.Change("red");
				break;
<<<<<<< HEAD
				case false:paint = true;ps.Play();indicator.Change ("green");
=======
				case false:
				paint = true;
				ps.Play();
				ps.Play ();
>>>>>>> bf0250a74f78076d75546b4e4db36cf0a5e48370
				break;
				default:paint = false; ps.Stop();indicator.Change("red");
				break;
			}
		}
	}
}
