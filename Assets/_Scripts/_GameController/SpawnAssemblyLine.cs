using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class SpawnAssemblyLine:MonoBehaviour 
{
	[SerializeField]private GameObject prefab;
	[SerializeField]private List<GameObject> tracks;
	[SerializeField]private Transform location;
	private GameObject track;
	private RaycastHit hit;

	private void Start()
	{
		tracks = new List<GameObject> ();
    }

	private void Update()
	{
		if (Physics.Raycast (location.localPosition, Vector3.forward, out hit,5f))
		{
			if (hit.collider.gameObject.CompareTag("Band"))
			{
				if (hit.distance > 3f)
				{
					track = Instantiate(prefab, location.localPosition + new Vector3(0, 0, 1.5001f), Quaternion.identity) as GameObject;
					tracks.Add(track);
				}
			}
		}
	}
}