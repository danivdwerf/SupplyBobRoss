using UnityEngine;
using System.Collections;

public class SetTrackSpeed : MonoBehaviour 
{
	private float speed;
	public float getTheSpeed
	{
		get
		{ 
			return speed;
		}
	}
	private void Awake()
	{
		speed = 1f;
		StartCoroutine ("IncreaseSpeed");
	}

	IEnumerator IncreaseSpeed()
	{
		while (speed < 5f)
		{
			speed += 0.0005f;
			Debug.Log (speed);
			yield return null;
		}	
	}
}
