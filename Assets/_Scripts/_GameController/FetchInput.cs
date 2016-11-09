using UnityEngine;
using System.Collections;

public class FetchInput : MonoBehaviour 
{
    
    private HandleInput handleInput;
	private void Start()
	{
		handleInput = GetComponent<HandleInput>();
	}

	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.S)||Input.GetKeyDown(KeyCode.DownArrow))
		{
			handleInput.Down ();
		}
        
	}
}
