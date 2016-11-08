using UnityEngine;
using System.Collections;

public class RetrySong : MonoBehaviour 
{
	[SerializeField] private AudioClip clip;
	private AudioSource source;
	private void Start()
	{
		source = GetComponent<AudioSource> ();
		PlaySong ();
	}
	private void PlaySong()
	{
		source.clip = clip;
		source.loop = true;
		source.Play ();
	}
}
