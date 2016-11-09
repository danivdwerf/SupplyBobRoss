 using UnityEngine;
using System.Collections;

public class TrackMovement : MonoBehaviour 
{
	private float speed;
	private Rigidbody rigid;
	private SetTrackSpeed getSpeed;
	void Start()
	{
		rigid = GetComponent<Rigidbody> ();
		getSpeed = GameObject.FindGameObjectWithTag("GameController").GetComponent<SetTrackSpeed> ();
	}
	private void FixedUpdate()
	{
		speed = getSpeed.getTheSpeed;
		rigid.MovePosition(rigid.transform.position + transform.forward.normalized*speed*Time.deltaTime);
	}
}