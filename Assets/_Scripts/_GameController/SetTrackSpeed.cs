using UnityEngine;
using System.Collections;

public class SetTrackSpeed : MonoBehaviour 
{
	private int speed;
	private bool spawning;
	private void Start()
	{
		speed = 2;
	}

	public int setSpeed
	{
		get
		{ 
			return speed;
		}
		set
		{ 
			switch (speed) 
			{
				case 0: speed=2;
				break;

				case 2:speed=0;
				break;
			}
		}
	}
}
