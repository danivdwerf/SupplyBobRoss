using UnityEngine;
using System.Collections;

public class BucketGravity : MonoBehaviour 
{
	private float gravity;
	private Rigidbody rigidBody;
	private void Start()
	{
		rigidBody = GetComponent<Rigidbody> ();
		gravity = -10f;
	}

	private void FixedUpdate()
	{
		rigidBody.AddForce (0f, gravity, 0f);
	}
}
