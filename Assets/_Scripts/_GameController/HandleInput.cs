using UnityEngine;
using System.Collections;

public class HandleInput : MonoBehaviour 
{
	private SetTrackSpeed setTrackSpeed;
	private MachineAudio machineAudio;
	private ControllParticles ps;
	private void Start()
	{
		machineAudio = GetComponent<MachineAudio> ();
		setTrackSpeed = GetComponent<SetTrackSpeed> ();
		ps = GameObject.FindObjectOfType<ControllParticles> ();
	}
	public void Space()
	{
		setTrackSpeed.setSpeed=0;
	}

	public void Down()
	{
		ps.SetBool = true;
		machineAudio.PlayAudio ();
	}
}
