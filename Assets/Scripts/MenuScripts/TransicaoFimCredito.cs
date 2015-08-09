using UnityEngine;
using System.Collections;

public class TransicaoFimCredito : MonoBehaviour {
	public GameObject canvasFim;
	public GameObject canvasCredito;
	public AudioClip somClique;
	public void passar (){
		AudioSource.PlayClipAtPoint (somClique, Camera.main.transform.position);
		canvasFim.SetActive (false);
		canvasCredito.SetActive (true);
	}
}
