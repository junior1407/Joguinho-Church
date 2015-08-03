using UnityEngine;
using System.Collections;

public class MostraComoJogar : MonoBehaviour {

	public GameObject canvasMainMenu;
	public GameObject canvasMenuComoJogar;
	public GameObject canvasSelecionarPersonagens;

	public void vaiMenuComoJogar(){
		canvasMainMenu.SetActive (false);
		canvasMenuComoJogar.SetActive(true);
	}

	public void voltaMenuPrincipalVindoDoMenuComoJogar(){
		canvasMainMenu.SetActive (true);
		canvasMenuComoJogar.SetActive(false);
	}

	public void comecaJogoMenu(){
		canvasMainMenu.SetActive (false);
		canvasSelecionarPersonagens.SetActive (true);
	}


}
