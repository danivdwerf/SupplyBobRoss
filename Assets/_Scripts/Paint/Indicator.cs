using UnityEngine;
using System.Collections;

public class Indicator : MonoBehaviour 
{
	[SerializeField] private Light spot;

	private void start()
	{
		spot.color = Color.red;
	}

	public void Change(string colour)
	{
		if (colour == "red")
		{
			spot.color = Color.red;	

		} 
		else
		{
			spot.color = Color.green;	
		}
	}
}
