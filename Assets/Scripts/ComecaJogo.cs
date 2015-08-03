using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ComecaJogo : MonoBehaviour {

	bool comecaJogo = false;
	public GameObject botaoPlay;
	static public int num_jogadores;
	public GameObject textObject;
	public string textinho;
	void Awake(){

		textObject= GameObject.Find ("NumeroPlayers");

	}
	void Start () {

	}
	void Update(){
		textinho = textObject.GetComponent<Text> ().text;
	}
	public void comecaJoguinho()
	{

		GameObject.Find("propriedades_jogo").GetComponent<Propriedes>().numero_de_jogadores= System.Int32.Parse(textinho);
		comecaJogo = true;
		if (comecaJogo == true) {
			//num_jogadores = GameObject.Find ("NumeroPlayers").GetComponent<Text>();
			Debug.Log(num_jogadores);
			Application.LoadLevel ("asda");
		}
		
	}
}
