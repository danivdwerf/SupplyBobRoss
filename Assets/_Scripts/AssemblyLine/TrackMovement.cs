using UnityEngine;
using System.Collections;

public class TrackMovement : MonoBehaviour 
{
	private int speed;
	private SetTrackSpeed setTrackSpeed;
	void Start()
	{
		setTrackSpeed = GameObject.FindObjectOfType<SetTrackSpeed> ();
	}
	void Update()
	{
		speed = setTrackSpeed.setSpeed;
	}
	private void FixedUpdate()
	{
		transform.Translate(Vector3.forward *speed*Time.deltaTime);
	}
}