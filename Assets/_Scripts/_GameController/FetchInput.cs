using UnityEngine;
using System.Collections;

public class FetchInput : MonoBehaviour 
{
	private SetTrackSpeed setTrackSpeed;
	private SpawnAssemblyLine spawner;
	private void Start()
	{
		setTrackSpeed = GetComponent<SetTrackSpeed> ();
	}

	private void Update()
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			setTrackSpeed.setSpeed=0;
		}
	}
}
