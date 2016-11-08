using UnityEngine;
using System.Collections;

public class GameOverAudio : MonoBehaviour 
{
	private AudioSource source;
	private SceneSwitcher sceneSwitcher;
	[SerializeField]private AudioClip clip;
	private void Start()
	{
		source = GetComponent<AudioSource> ();
		sceneSwitcher = GetComponent<SceneSwitcher> ();
	}
	public void PlayAudio()
	{
		StartCoroutine ("WaitForAudio");
		source.PlayOneShot (clip);
	}

	IEnumerator WaitForAudio()
	{
		yield return new WaitForSeconds (clip.length+0.5f);
		sceneSwitcher.ChangeScene (2);
	}
}
