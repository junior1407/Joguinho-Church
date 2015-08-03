using UnityEngine;
using System.Collections;

public class AplicarForçaRandom : MonoBehaviour {

	public string buttonName = "Fire1";
	public GameObject dado;
	public float angularTorque = 10.0f;
	public float força = 10.0f;
	public ForceMode forceMode;
	public Rigidbody corpo;

	void start()
	{
		corpo = GetComponent<Rigidbody> ();
	}
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetButtonDown(buttonName))
		{
			corpo.AddForce(Random.onUnitSphere * força, forceMode);
			corpo.AddTorque(Random.onUnitSphere * angularTorque, forceMode);
			corpo.IsSleeping();
		}
	}
}
