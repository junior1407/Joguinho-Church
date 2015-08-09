using UnityEngine;
using System.Collections;

public class sair : MonoBehaviour {
	public AudioClip somClique;
	public void OnClick(){
		AudioSource.PlayClipAtPoint (somClique, Camera.main.transform.position);
		Application.Quit ();
	}
}
