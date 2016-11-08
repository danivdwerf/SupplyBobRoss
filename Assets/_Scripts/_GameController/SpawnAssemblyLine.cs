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
	private float waitTime;
    private bool isSpawning;
    public bool IsSpawning
    {
        get { return isSpawning; }
    }

	private void Start()
	{
		tracks = new List<GameObject> ();
		waitTime = 1.3f;
		StartSpawn ();
    }
	public void StartSpawn()
	{
        StopCoroutine("Wait");
		StartCoroutine ("Wait");
        isSpawning = true;
	}

    public void StopSpawn()
    {
        StopCoroutine("Wait");
        isSpawning = false;
    }

	IEnumerator Wait()
	{
       while(true)
        {
            track = Instantiate(prefab, location.localPosition, Quaternion.identity) as GameObject;
            tracks.Add(track);
            yield return new WaitForSeconds(waitTime);
        }
    }
    public float SetTime
    {
        set
        {
           
            if (waitTime == 1.3f)
            {
                waitTime = 0f;
            }
            if (waitTime == 0f)
            {
                waitTime = 1.3f;
            }
        }
    }
}