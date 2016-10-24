using UnityEngine;
using System.Collections;

public class DeleteAssemblyLine : MonoBehaviour 
{
	private void Update()
	{
		if (transform.position.z >= 10)
		{
			Destroy (gameObject);
		}
	}
}
