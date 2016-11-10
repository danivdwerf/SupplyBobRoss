using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HandleButtonInput : MonoBehaviour 
{
	[SerializeField] private Button retryButton;
	[SerializeField] private Button mainMenuButton;
	private SceneSwitcher sceneSwitcher;

	private void Start()
	{
		sceneSwitcher = GameObject.FindObjectOfType<SceneSwitcher>();
		retryButton.onClick.AddListener(delegate(){sceneSwitcher.ChangeScene(1);});
		mainMenuButton.onClick.AddListener (delegate(){sceneSwitcher.ChangeScene (0);});
	}
}
