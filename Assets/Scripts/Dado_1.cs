using UnityEngine;
using System.Collections;

public class Dado_1 : MonoBehaviour {

	public LayerMask dieValueColliderLayer = -1;
	public  int currentValue = 1;
	public bool rollComplete = false;


	IEnumerator rolarDados(){

		RaycastHit hit;
		if (Physics.Raycast(transform.position, Vector3.up,out hit,Mathf.Infinity, dieValueColliderLayer))
		{	
			currentValue = hit.collider.GetComponent<valorDado>().valor;
		}
		if (GetComponent<Rigidbody>().IsSleeping () && !rollComplete) {
			rollComplete = true;
			//currentValue = hit.collider.GetComponent<valorDado>().valor;
		} else if (!GetComponent<Rigidbody>().IsSleeping()) {
			rollComplete = false;
		}
		yield return false;
	}


	void Update () 


	{


	}}
