using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public abstract class BaseCasa

{
	int posicao{ get; set;}
	public GameObject objeto_quadro;
	Transform[] transform = new Transform[6];
	public Text quadro;
	public string mensagem{ get; set;}
	public BaseCasa(Transform pai, Text textinho, int pos){
		objeto_quadro = GameObject.Find ("Quadro");
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

	/*public IEnumerator PartStart(){


	}*/

	public void MostraParticulas(){
		GameObject x=	(GameObject)  GameObject.Instantiate (Resources.Load ("Estrelas"));
		x.transform.position = objeto_quadro.transform.position;
		GameObject y = (GameObject)GameObject.Instantiate (Resources.Load ("FumacinhaKawaii"));
		y.transform.position = objeto_quadro.transform.position;

   



}




}