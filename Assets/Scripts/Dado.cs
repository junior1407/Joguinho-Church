using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Dado : MonoBehaviour
{
	public AudioClip somClique;
	GameBoardController controller;
	public Button botao_op;
	GameObject atual;
	public LayerMask dieValueColliderLayer = -1;
	public  int currentValue = 1;
	public bool rollComplete;
	public string buttonName = "Fire1";
	public GameObject dado;
	public float angularTorque = 10.0f;
	public float força = 10.0f;
	public ForceMode forceMode;
	public Rigidbody corpo;
	public Vector3 velocity;
	public Vector3 angular_velocity;


	void Awake ()
	{
		corpo = gameObject.GetComponent<Rigidbody> ();
		controller = GameObject.Find ("GameBoardController").GetComponent<GameBoardController>();
		GameObject botao_de_rolar = GameObject.Find ("Button");
		botao_op= botao_de_rolar.GetComponent<Button> ();

	}


	
	void Update ()
	{
		angular_velocity = corpo.angularVelocity;
		velocity = corpo.velocity;
	
		if (Input.GetKeyDown(KeyCode.Space)) {
			if (botao_op.IsInteractable()){
				botao_op.onClick.Invoke();

			}

		
		}




	
	}

	public void rolar()
	{
		AudioSource.PlayClipAtPoint(somClique, Camera.main.transform.position);
		botao_op.interactable = false;
		corpo.AddForce (Vector3.up * 200);
		corpo.AddTorque (Random.onUnitSphere * angularTorque * Mathf.PI, forceMode);
		Debug.Log ("Inicio rotina");
		StartCoroutine("rolarDados");




	}

	IEnumerator rolarDados ()
	{
		/**/

		yield return StartCoroutine("Checkagem");
		Debug.Log ("Fim rotina");
		gettarFaceDado ();
		//controller.mover (currentValue);
		controller.StartCoroutine (controller.mover (currentValue));



	}

	IEnumerator Checkagem(){
		Debug.Log ("inicio espera");
		yield return new WaitForSeconds (0.5f);
		Debug.Log ("FIM espera");
		for (float timer = 8; timer >= 0; timer -= Time.deltaTime) {
			yield return null;
			if (corpo.IsSleeping() ){
				timer=0;
				Debug.Log ("palou");
				yield return 0;
			}
		}
	

		Debug.Log ("Saiu");
	//	gettarFaceDado ();
	//	controller.mover  (currentValue);



	}



	public bool gettarFaceDado(){
		RaycastHit hit;
		if (Physics.Raycast (transform.position, Vector3.up, out hit, Mathf.Infinity, dieValueColliderLayer)) {	
			currentValue = hit.collider.GetComponent<valorDado> ().valor;
		}
		if (GetComponent<Rigidbody> ().IsSleeping () && !rollComplete) {
			rollComplete = true;
			//currentValue = hit.collider.GetComponent<valorDado>().valor;
		} else if (!GetComponent<Rigidbody> ().IsSleeping ()) {
			rollComplete = false;

		}

		if (rollComplete==true){
			return true;
	}
		return false;
	}}



