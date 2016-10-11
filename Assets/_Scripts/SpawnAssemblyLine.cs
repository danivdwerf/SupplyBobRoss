using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnAssemblyLine:MonoBehaviour 
{
	[SerializeField]private GameObject prefab;
	[SerializeField]private List<GameObject> tracks;
	[SerializeField]private Transform location;
	private GameObject track;
	private float waitTime;

	private void Start()
	{
		waitTime = 3.0f;
		tracks = new List<GameObject> ();
		Spawn ();
	}
	private void Spawn()
	{
		track = Instantiate (prefab,location.localPosition,Quaternion.identity) as GameObject;
		tracks.Add (track);
		StartCoroutine (Wait());
	}
	void Update()
	{
		//Debug.Log (tracks.Count);
	}

	IEnumerator Wait()
	{
		yield return new WaitForSeconds (waitTime);
		Spawn ();
	}
}