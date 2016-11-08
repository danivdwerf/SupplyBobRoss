using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour 
{
	public void ChangeScene(int sceneIndex)
	{
		SceneManager.LoadScene (sceneIndex);
	}
}
