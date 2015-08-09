using UnityEngine;
using System.Collections;

public class MostraComoJogar : MonoBehaviour {
	public AudioClip somClique;
	public GameObject canvasMainMenu;
	public GameObject canvasMenuComoJogar;
	public GameObject canvasSelecionarPersonagens;

	public void vaiMenuComoJogar(){
		AudioSource.PlayClipAtPoint (somClique, Camera.main.transform.position);
		canvasMainMenu.SetActive (false);
		canvasMenuComoJogar.SetActive(true);
	}

	public void voltaMenuPrincipalVindoDoMenuComoJogar(){
		AudioSource.PlayClipAtPoint (somClique, Camera.main.transform.position);
		canvasMainMenu.SetActive (true);
		canvasMenuComoJogar.SetActive(false);
	}

	public void comecaJogoMenu(){
		AudioSource.PlayClipAtPoint (somClique, Camera.main.transform.position);
		canvasMainMenu.SetActive (false);
		canvasSelecionarPersonagens.SetActive (true);
	}


}
