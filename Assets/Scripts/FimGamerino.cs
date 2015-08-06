using UnityEngine;
using System.Collections;

public class FimGamerino : MonoBehaviour {
	public Animator animator;
	public GameObject luzNice;


	void start(){
		animator = GetComponent<Animator>();
	}



void OnCollisionEnter(Collider colisor)
	{
		if (colisor.gameObject.tag == "jogador") {
			Debug.Log ("aeho");
			animator.SetBool("Ativo", true);
			luzNice.SetActive (true);
		}


	}
}
