using UnityEngine;
using System.Collections;

public class MenuVindoEnd : MonoBehaviour {
	public AudioClip somClique;
	public void goMainMenu()
	{
		AudioSource.PlayClipAtPoint (somClique, Camera.main.transform.position);
		Application.LoadLevel ("Menu");
	}
}
