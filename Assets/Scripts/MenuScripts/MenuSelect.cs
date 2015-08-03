using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
public class MenuSelect : MonoBehaviour {

	public GameObject textgameobject;
	public string  texto;
	public GameObject canvasMainMenu;
	public GameObject canvasSelecionarPersonagens;



	public void voltarMenuPrincipalVindoDoMenuSelecionarPersonagens()
	{
		canvasMainMenu.SetActive (true);
		canvasSelecionarPersonagens.SetActive (false);
	}
	
	public void comecaJogoRealmente(){

		Application.LoadLevel ("asda");
		
	}


	
	public void BotoesDireita(){
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
