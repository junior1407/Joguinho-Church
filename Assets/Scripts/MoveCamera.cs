using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {
	//public Camera sacamera;
	public Transform target;
	public float smoothTime = 0.3F;
	private Vector3 velocity = Vector3.zero;

	
	public GameObject player;
	
	private Vector3 offset;
	
	void Start ()
	{
		offset = transform.position - target.transform.position;
	}
	



	void Update() {

		Vector3 targetPosition = target.TransformPoint(new Vector3(0, 5, -10));

		GetComponent<Camera>().transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
	}
}
