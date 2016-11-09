using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour 
{
	[SerializeField] private Button startButton;
	[SerializeField] private Button instructionButton;
	[SerializeField] private Button quitButton;
	[SerializeField] private Button backButton;

	private SceneSwitcher sceneSwitch;
	private HandleUI ui;
	private void Start()
	{
		sceneSwitch = GetComponent<SceneSwitcher> ();
		ui = GetComponent<HandleUI> ();

		startButton.onClick.AddListener (delegate(){sceneSwitch.ChangeScene(1);});
		instructionButton.onClick.AddListener (delegate(){ui.ShowInstructions(true);});
		quitButton.onClick.AddListener (delegate(){Application.Quit();});
		backButton.onClick.AddListener(delegate(){ui.ShowInstructions(false);}); 
	}
}
