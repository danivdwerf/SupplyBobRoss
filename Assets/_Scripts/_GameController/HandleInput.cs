using UnityEngine;
using System.Collections;

public class HandleInput : MonoBehaviour 
{
	private MachineAudio machineAudio;
	private ControllParticles ps;
	private void Start()
	{
		machineAudio = GetComponent<MachineAudio> ();
		ps = GameObject.FindObjectOfType<ControllParticles> ();
	}

	public void Down()
	{
		ps.SetBool = true;
		machineAudio.PlayAudio ();
	}
}
