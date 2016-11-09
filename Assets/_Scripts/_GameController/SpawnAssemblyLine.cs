using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class SpawnAssemblyLine:MonoBehaviour 
{
	[SerializeField]private GameObject prefab;
	[SerializeField]private List<GameObject> tracks;
	[SerializeField]private Transform location;
	private bool stopSpawn; 
	private GameObject track;
	private RaycastHit hit;
    private bool isSpawning;
    public bool IsSpawning
    {
        get 
		{ 
			return isSpawning; 
		}
    }

	private void Start()
	{
		tracks = new List<GameObject> ();
		StartSpawn ();
    }
	public void StartSpawn()
	{
		isSpawning = true;
	}

    public void StopSpawn()
    {
		isSpawning = false;
    }

	private void Update()
	{
		if(isSpawning)
		{
			if (Physics.Raycast (location.localPosition, Vector3.forward, out hit,5f))
			{
				if (hit.collider.gameObject.CompareTag("Band"))
				{
					Debug.DrawRay (location.localPosition,Vector3.forward*hit.distance,Color.red);

					if (hit.distance > 3f)
					{
						Debug.Log (hit.distance);
						track = Instantiate(prefab, location.localPosition + new Vector3(0, 0, 1.5001f), Quaternion.identity) as GameObject;
						tracks.Add(track);
					}
				}
			}
		}
	}
}