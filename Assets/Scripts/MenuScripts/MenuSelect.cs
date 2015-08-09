using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
public class MenuSelect : MonoBehaviour {

	public GameObject textgameobject;
	public string  texto;
	public GameObject canvasMainMenu;
	public GameObject canvasSelecionarPersonagens;
	public AudioClip somClique;


	public void voltarMenuPrincipalVindoDoMenuSelecionarPersonagens()
	{
		AudioSource.PlayClipAtPoint (somClique, Camera.main.transform.position);
		canvasMainMenu.SetActive (true);
		canvasSelecionarPersonagens.SetActive (false);
	}
	
	public void comecaJogoRealmente(){

		AudioSource.PlayClipAtPoint(somClique, Camera.main.transform.position);;
		textgameobject.GetComponent<Text> ();
		Text text = textgameobject.GetComponent<Text>();
		Application.LoadLevel ("asda");
		Propriedes.numero_de_jogadores = System.Int32.Parse(text.text);
		
	}


	
	public void BotoesDireita(){
		AudioSource.PlayClipAtPoint(somClique, Camera.main.transform.position);
		textgameobject.GetComponent<Text> ();
		Text text = textgameobject.GetComponent<Text>();

		
		
		if (text.text == "1") {
			text.text = "2";

		}
		
		else if (text.text == "2") {
			text.text = "3";
		
		}
		
		else if (text.text == "3") {
			text.text = "4";

		}
		
		else if (text.text == "4") {
			text.text = "5";

		}
		
		else if (text.text == "5") {
			text.text = "6";

		}
		
	}

	public void botaoEsquerdo(){
		AudioSource.PlayClipAtPoint(somClique, Camera.main.transform.position);
		textgameobject.GetComponent<Text> ();
		Text text = textgameobject.GetComponent<Text>();

		
		
		if (text.text == "6") {
			text.text = "5";

		}
		
		else if (text.text == "5") {
			text.text = "4";

		}
		
		else if (text.text == "4") {
			text.text = "3";

		}
		
		else if (text.text == "3") {
			text.text = "2";

		}
		
		else if (text.text == "2") {
			text.text = "1";

		}
	}
}
