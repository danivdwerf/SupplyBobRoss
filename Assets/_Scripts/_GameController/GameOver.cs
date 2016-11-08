using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;

public class GameOver : MonoBehaviour 
{
	private FetchInput inputScript;
	private GameOverAudio goAudio;
	private MachineAudio machineAudio;
	private Grayscale gray;
	private void Start()
	{
		inputScript = GetComponent<FetchInput> ();
		goAudio = GetComponent<GameOverAudio> ();
		machineAudio = GetComponent<MachineAudio> ();
		gray = GameObject.FindObjectOfType<Grayscale> ();
		gray.enabled = false;
	}

	public void StopInput()
	{
		inputScript.enabled = false;
		goAudio.PlayAudio ();
		machineAudio.StopAudio ();
		gray.enabled = true;
	}
}
