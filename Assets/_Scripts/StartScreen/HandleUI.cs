using UnityEngine;
using System.Collections;

public class HandleUI : MonoBehaviour 
{
	[SerializeField] private GameObject instructionPanel;

	private void Start()
	{
		instructionPanel.SetActive (false);
	}

	public void ShowInstructions(bool state)
	{
		instructionPanel.SetActive (state);
	}
}
