using UnityEngine;
using System.Collections;

public class ScriptPause : MonoBehaviour {

	public GameObject canvasComum;
	public GameObject canvasPause;
	public AudioClip somClique;
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
		AudioSource.PlayClipAtPoint (somClique, Camera.main.transform.position);
		canvasPause.SetActive (false);
		canvasComum.SetActive (true);
		Time.timeScale = 1.0f;
	}

	public void voltarMainMenu()
	{
		AudioSource.PlayClipAtPoint (somClique, Camera.main.transform.position);
		Application.Quit();

	}

}
