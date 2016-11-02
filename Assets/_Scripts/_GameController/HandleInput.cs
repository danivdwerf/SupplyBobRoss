using UnityEngine;
using System.Collections;

public class HandleInput : MonoBehaviour 
{
    private SpawnAssemblyLine spawnAssemblyLine;
	private SetTrackSpeed setTrackSpeed;
	private ControllParticles ps;
	private void Start()
	{
        spawnAssemblyLine = GetComponent<SpawnAssemblyLine>();
		setTrackSpeed = GetComponent<SetTrackSpeed> ();
		ps = GameObject.FindObjectOfType<ControllParticles> ();
	}
	public void Space()
	{
        spawnAssemblyLine.SetTime = 0f;
		setTrackSpeed.setSpeed=0;

        if (spawnAssemblyLine.IsSpawning)
            spawnAssemblyLine.StopSpawn();
        else
            spawnAssemblyLine.StartSpawn();
	}

	public void Down()
	{
		ps.SetBool = true;
	}
}
