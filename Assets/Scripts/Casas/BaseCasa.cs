using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public abstract class BaseCasa

{
	int posicao{ get; set;}
	Transform[] transform = new Transform[6];
	public Text quadro;
	public string mensagem{ get; set;}
	public BaseCasa(Transform pai, Text textinho, int pos){
		quadro = textinho;

		for (int i=0; i<6; i++) {

			transform [i] = pai.GetChild (i);		

		}
		posicao = pos;
	}

	public Vector3 getPositionparaPlayer(int num){

		return transform[num].position;

	}




	public abstract void Executar();
}




