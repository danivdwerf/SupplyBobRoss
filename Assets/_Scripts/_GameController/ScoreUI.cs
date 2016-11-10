using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour 
{
	[SerializeField] private Text score;
	public void UpdateUI(float curScore)
	{
		score.text = "Bob's paint: " + curScore.ToString("F1") + "L";
	}
}
