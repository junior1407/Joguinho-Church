using UnityEngine;
using System.Collections;

public class ScriptPause : MonoBehaviour {

	public GameObject canvasComum;
	public GameObject canvasPause;

	public void Update()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			canvasComum.SetActive(false);
			canvasPause.SetActive(true);
			Time.timeScale = 0.0f;
		}
	}

	public void resumirGame()
	{
		canvasPause.SetActive (false);
		canvasComum.SetActive (true);
		Time.timeScale = 1.0f;
	}

	public void voltarMainMenu()
	{
		Application.Quit();

	}

}
