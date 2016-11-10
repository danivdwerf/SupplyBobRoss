using UnityEngine;
using System.Collections;

public class ScoreLogic : MonoBehaviour
{
	private ScoreUI ui;
	private GameOver gameOver;
	private float score;
	public float GetScore
	{
		get 
		{ 
			return score;
		}
	}

	private void Start()
	{
		ui = GetComponent<ScoreUI> ();
		gameOver = GetComponent<GameOver> ();
		score = 2;
		ui.UpdateUI(score);
		StartCoroutine ("UsePaint");	
	}

	void Update()
	{
		if(score<0)
		{
			StopCoroutine ("UsePaint");
			gameOver.StopInput ();
		}
	}

	public void AddScore()
	{
		score+=0.1f;
		ui.UpdateUI(score);
	}

	IEnumerator UsePaint()
	{
		while (true)
		{
			score -= 0.5f;
			ui.UpdateUI(score);
			yield return new WaitForSeconds (8f);
		}	
	}
}
