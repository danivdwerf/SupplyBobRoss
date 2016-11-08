using UnityEngine;
using System.Collections;

public class MachineAudio : MonoBehaviour
{
	[SerializeField] private AudioClip workingMachine;
	private AudioSource source;
	private void Start()
	{
		source = GameObject.FindGameObjectWithTag ("Machine").GetComponent<AudioSource> ();
	}

	public void PlayAudio()
	{
		if (!source.isPlaying)
		{
			source.clip = workingMachine;
			source.loop = true;
			source.Play ();
			source.volume = 0.5f;
		}
		else
		{
			StopAudio ();
		}
	}

	public void StopAudio()
	{
		source.Stop ();
	}
}
