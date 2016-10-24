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
				ps.emission.enabled = false;;
				break;
				case false:
				paint = true;
				ps.emission.enabled = true;
				break;
				default:paint = false; ps.emission.enabled=false;
				break;
			}
		}
	}
}
