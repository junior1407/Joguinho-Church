using UnityEngine;
using System.Collections;

public class TransicaoFimCredito : MonoBehaviour {
	public GameObject canvasFim;
	public GameObject canvasCredito;

	public void passar (){
		canvasFim.SetActive (false);
		canvasCredito.SetActive (true);
	}
}
