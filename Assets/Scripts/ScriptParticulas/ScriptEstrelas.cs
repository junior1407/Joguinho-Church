using UnityEngine;
using System.Collections;

public class ScriptEstrelas : MonoBehaviour {

	public float tempopassado;
	void Awake(){
		tempopassado = 0;
	}
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		tempopassado += Time.deltaTime;
		if (tempopassado > 4) {
			Destroy (gameObject); 
		}

	}
}
